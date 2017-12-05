using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
using Microsoft.Win32;
using System.Diagnostics;
using System.Configuration;

namespace Ceed
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string arguments = string.Empty;

		private void Form1_Load(object sender, EventArgs e)
		{
			var appName = Process.GetCurrentProcess().ProcessName + ".exe";
			var loadPath = ConfigurationManager.AppSettings["loadPath"];
			var savePath = ConfigurationManager.AppSettings["savePath"];
			System.Uri uri = new System.Uri(ConfigurationManager.AppSettings["homeLink"]);
			webBrowser1.Url=uri;
			var runPath = Environment.CurrentDirectory.ToString();
			if(loadPath!=@"c:\")
			{
				txtLoadPath.Text = loadPath;
				btnLoad.Enabled = true;
				loadGames();
			}
			if (savePath != @"c:\")
			{
				txtSavePath.Text = savePath;
			}
			SetIEKeyforWebBrowserControl(appName);
			try
			{
				System.IO.DirectoryInfo di = new DirectoryInfo(runPath + @"\temp");
				if (!(di.Exists))
				{
					di.Create();
				}
				WebClient Client = new WebClient();
				Client.DownloadFile("https://github.com/datajerk/c2t/archive/master.zip", @".\temp\master.zip");
			}
			catch
			{
				statusDetails("Cannot Download C2T, using prior downloaded version.");
			}

			try
			{
				DirectoryInfo di = new DirectoryInfo(runPath+@"\c2t-master");
				if (di.Exists)
				{
					foreach (FileInfo file in di.GetFiles())
					{
						file.Delete();
					}
					foreach (DirectoryInfo dir in di.GetDirectories())
					{
						dir.Delete(true);
					}
					di.Delete();
				}
				di = new DirectoryInfo(runPath + @"\c2t");
				if (di.Exists)
				{
					foreach (FileInfo file in di.GetFiles())
					{
						file.Delete();
					}
					foreach (DirectoryInfo dir in di.GetDirectories())
					{
						dir.Delete(true);
					}
					di.Delete();
				}
				string zipPath = runPath+@"\temp\master.zip";
				string extractPath = runPath;
				ZipFile.ExtractToDirectory(zipPath, extractPath);
				Directory.Move(runPath + @"\c2t-master", runPath +@"\c2t");
				if (File.Exists(@".\temp\master.zip"))
				{
					File.Delete(@".\temp\master.zip");
				}
			}
			catch (Exception exc)
			{
				statusDetails(exc.Message);
			}
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate(ConfigurationManager.AppSettings["homeLink"]);
		}

		private void btnFwd_Click(object sender, EventArgs e)
		{
			if(webBrowser1.CanGoForward)
			webBrowser1.GoForward();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			if (webBrowser1.CanGoBack)
				webBrowser1.GoBack();
		}
		
		private void SetIEKeyforWebBrowserControl(string appName)
		{
			RegistryKey Regkey = null;
			try
			{
				int BrowserVer, RegVal;

				// get the installed IE version
				using (WebBrowser Wb = new WebBrowser())
					BrowserVer = Wb.Version.Major;

				// set the appropriate IE version
				if (BrowserVer >= 11)
					RegVal = 11001;
				else if (BrowserVer == 10)
					RegVal = 10001;
				else if (BrowserVer == 9)
					RegVal = 9999;
				else if (BrowserVer == 8)
					RegVal = 8888;
				else
					RegVal = 7000;

				// For 64 bit machine
				if (Environment.Is64BitOperatingSystem)
					Regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
				else  //For 32 bit machine
					Regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);


				//If the path is not correct or 
				//If user't have priviledges to access registry 
				if (Regkey == null)
				{
					MessageBox.Show("Registry Key for setting IE WebBrowser Rendering Address Not found. Try run the program with administrator's right.");
					return;
				}

				string FindAppkey = Convert.ToString(Regkey.GetValue(appName));

				//Check if key is already present 
				if (FindAppkey == RegVal.ToString())
				{
					Regkey.Close();
					return;
				}

				Regkey.SetValue(appName, RegVal, RegistryValueKind.DWord);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Registry Key for setting IE WebBrowser Rendering failed to setup");
				MessageBox.Show(ex.Message);
			}
			finally
			{
				//Close the Registry 
				if (Regkey != null)
					Regkey.Close();
			}
		}

		private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
		{
			txtURLBar.Text = "Loading...";
		}

		private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			try
			{
				txtURLBar.Text = webBrowser1.Url.ToString();
			}
			catch
			{
				txtURLBar.Text = "Loading...";
			}
		}
		private void unzipFiles(string filePath)
		{
			try
			{				
				DirectoryInfo directory = new DirectoryInfo(filePath);
				FileInfo[] files = directory.GetFiles("*.zip");
				for (int i = 0; i < files.Length; i++)
				{
					string zipPath = filePath + @"\"+ files;
					string extractPath = filePath;
					ZipFile.ExtractToDirectory(zipPath, extractPath);
				}
			}
			catch (Exception exc)
			{
				statusDetails(exc.Message);
			}
		}
		private void loadGames()
		{
			try
			{
				string loadPath = ConfigurationManager.AppSettings["loadPath"];
				if (chkAutoUnzip.Checked == true)
				{
					unzipFiles(loadPath);
				}
				lstFiles.Items.Clear();
				DirectoryInfo directory = new DirectoryInfo(loadPath);
				FileInfo[] files = directory.GetFiles("*.dsk");
				for (int i = 0; i < files.Length; i++)
				{
					lstFiles.Items.Add(files[i].ToString());
				}
				statusDetails("Loaded " + files.Length + " disk images to the list");
				
			}
			catch (Exception exc)
			{
				statusDetails(exc.Message);
			}
		}
		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (dlgLoadPath.ShowDialog() == DialogResult.OK)
			{
				//save new path to app.config
				txtLoadPath.Text = dlgLoadPath.SelectedPath.ToString();
				string ProviderKey = "loadPath";
				Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
				config.AppSettings.Settings[ProviderKey].Value = txtLoadPath.Text;
				config.Save();
				ConfigurationManager.RefreshSection("appSettings");
				statusDetails("Path captured, click load to list disk images.");
				btnLoad.Enabled = true;
			}
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			//save new path to app.config
			string ProviderKey = "loadPath";
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			config.AppSettings.Settings[ProviderKey].Value = txtLoadPath.Text;
			config.Save();
			ConfigurationManager.RefreshSection("appSettings");
			loadGames();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (txtLoadPath.Text != "" && txtSavePath.Text != "" && lstFiles.Items.Count>0)
			{
				btnConvert.Enabled = true;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (dlgSavePath.ShowDialog() == DialogResult.OK)
			{
				//save new path to app.config
				txtSavePath.Text = dlgSavePath.SelectedPath.ToString();
				string ProviderKey = "savePath";
				Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
				config.AppSettings.Settings[ProviderKey].Value = txtSavePath.Text;
				config.Save();
				ConfigurationManager.RefreshSection("appSettings");
				statusDetails("Save path selected successfully!");
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			string ProviderKey = "savePath";
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			config.AppSettings.Settings[ProviderKey].Value = @"c:\";
			config.Save();
			ConfigurationManager.RefreshSection("appSettings");
			ProviderKey = "loadPath";
			config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			config.AppSettings.Settings[ProviderKey].Value = @"c:\";
			config.Save();
			ConfigurationManager.RefreshSection("appSettings");
			statusDetails("Save and Load path cleared successfully!");
		}
		
		private void statusDetails(string statusMessage)
		{
			lblStatus.ForeColor = System.Drawing.Color.Red;
			lblStatus.Text = statusMessage;
			tmrColorChange.Start();

		}
		private void btnConvert_Click(object sender, EventArgs e)
		{
			var converCount = 0;
			if (lstFiles.SelectedItems.Count > 0)
			{
				foreach (var diskImage in lstFiles.SelectedItems)
				{
					arguments = string.Empty;
					var appPath = @"""" + Environment.CurrentDirectory.ToString() + @"\c2t\bin\c2t-96h.exe""";
					if (cboAppleType.Text == "Apple //")
					{
						arguments = arguments + " -2 ";
					}
					else
					{

						arguments = arguments + " -1 ";
					}
					if (chkEmulatedDrive.Checked == true)
					{
						arguments = arguments + " -n ";
					}
					string[] outputFile = diskImage.ToString().Split('.');

					arguments = arguments + @" """ + txtLoadPath.Text + @"\" + diskImage.ToString() + @""" """ + txtSavePath.Text + @"\" + outputFile[0] + @".wav""";
					try
					{
						statusDetails("converting " + diskImage.ToString());
						System.Diagnostics.Process process = new System.Diagnostics.Process();
						System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
						startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
						startInfo.FileName = appPath;
						startInfo.Arguments = arguments;
						process.StartInfo = startInfo;
						process.Start();
						converCount++;
					}
					catch (Exception exc)
					{
						statusDetails(exc.Message);
					}
					statusDetails("Conversion of " + converCount + " disk images completed.  Check " + txtSavePath.Text + " for converted files");
				}
			}
			else
			{
				statusDetails("Please select one or more disk images.");
			}
		}

		private void tmrColorChange_Tick(object sender, EventArgs e)
		{
			lblStatus.ForeColor= System.Drawing.Color.Black;
		}
	}
}
