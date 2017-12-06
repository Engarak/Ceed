namespace Ceed
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.dlgLoadPath = new System.Windows.Forms.FolderBrowserDialog();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.dlgSavePath = new System.Windows.Forms.FolderBrowserDialog();
			this.tmrColorChange = new System.Windows.Forms.Timer(this.components);
			this.tabConvert = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkAutoUnzip = new System.Windows.Forms.CheckBox();
			this.cboAppleType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.chkEmulatedDrive = new System.Windows.Forms.CheckBox();
			this.tabBrowser = new System.Windows.Forms.TabPage();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnBack = new System.Windows.Forms.ToolStripButton();
			this.btnFwd = new System.Windows.Forms.ToolStripButton();
			this.btnHome = new System.Windows.Forms.ToolStripButton();
			this.txtURLBar = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnStop = new System.Windows.Forms.ToolStripButton();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.picLoad = new System.Windows.Forms.PictureBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSavePath = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.lstFiles = new System.Windows.Forms.ListBox();
			this.txtLoadPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.tabConvert.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabBrowser.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 707);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(10, 17);
			this.lblStatus.Text = ".";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// tmrColorChange
			// 
			this.tmrColorChange.Interval = 1750;
			this.tmrColorChange.Tick += new System.EventHandler(this.tmrColorChange_Tick);
			// 
			// tabConvert
			// 
			this.tabConvert.Controls.Add(this.groupBox1);
			this.tabConvert.Controls.Add(this.groupBox2);
			this.tabConvert.Location = new System.Drawing.Point(4, 22);
			this.tabConvert.Name = "tabConvert";
			this.tabConvert.Padding = new System.Windows.Forms.Padding(3);
			this.tabConvert.Size = new System.Drawing.Size(995, 673);
			this.tabConvert.TabIndex = 1;
			this.tabConvert.Text = "Convert Disk Image";
			this.tabConvert.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.chkEmulatedDrive);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.cboAppleType);
			this.groupBox2.Controls.Add(this.chkAutoUnzip);
			this.groupBox2.Location = new System.Drawing.Point(3, 453);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(986, 214);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Advanced Settings";
			// 
			// chkAutoUnzip
			// 
			this.chkAutoUnzip.AutoSize = true;
			this.chkAutoUnzip.Location = new System.Drawing.Point(6, 19);
			this.chkAutoUnzip.Name = "chkAutoUnzip";
			this.chkAutoUnzip.Size = new System.Drawing.Size(132, 17);
			this.chkAutoUnzip.TabIndex = 0;
			this.chkAutoUnzip.Text = "Unzip files in load path";
			this.chkAutoUnzip.UseVisualStyleBackColor = true;
			// 
			// cboAppleType
			// 
			this.cboAppleType.FormattingEnabled = true;
			this.cboAppleType.Items.AddRange(new object[] {
            "Apple //",
            "Apple I"});
			this.cboAppleType.Location = new System.Drawing.Point(328, 15);
			this.cboAppleType.Name = "cboAppleType";
			this.cboAppleType.Size = new System.Drawing.Size(121, 21);
			this.cboAppleType.TabIndex = 1;
			this.cboAppleType.Text = "Apple //";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(261, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Apple Type";
			// 
			// chkEmulatedDrive
			// 
			this.chkEmulatedDrive.AutoSize = true;
			this.chkEmulatedDrive.Location = new System.Drawing.Point(6, 42);
			this.chkEmulatedDrive.Name = "chkEmulatedDrive";
			this.chkEmulatedDrive.Size = new System.Drawing.Size(232, 17);
			this.chkEmulatedDrive.TabIndex = 3;
			this.chkEmulatedDrive.Text = "Emulated Drive (CFFA3000, SDISK //, etc.)";
			this.chkEmulatedDrive.UseVisualStyleBackColor = true;
			// 
			// tabBrowser
			// 
			this.tabBrowser.Controls.Add(this.picLoad);
			this.tabBrowser.Controls.Add(this.webBrowser1);
			this.tabBrowser.Controls.Add(this.toolStrip1);
			this.tabBrowser.Location = new System.Drawing.Point(4, 22);
			this.tabBrowser.Name = "tabBrowser";
			this.tabBrowser.Padding = new System.Windows.Forms.Padding(3);
			this.tabBrowser.Size = new System.Drawing.Size(697, 510);
			this.tabBrowser.TabIndex = 0;
			this.tabBrowser.Text = "Web Browser";
			this.tabBrowser.UseVisualStyleBackColor = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnFwd,
            this.btnHome,
            this.txtURLBar,
            this.toolStripSeparator1,
            this.btnStop});
			this.toolStrip1.Location = new System.Drawing.Point(3, 3);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(691, 31);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnBack
			// 
			this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(28, 28);
			this.btnBack.Text = "Back";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFwd
			// 
			this.btnFwd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnFwd.Image = ((System.Drawing.Image)(resources.GetObject("btnFwd.Image")));
			this.btnFwd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFwd.Name = "btnFwd";
			this.btnFwd.Size = new System.Drawing.Size(28, 28);
			this.btnFwd.Text = "Forward";
			this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
			// 
			// btnHome
			// 
			this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(28, 28);
			this.btnHome.Text = "Home";
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// txtURLBar
			// 
			this.txtURLBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtURLBar.Name = "txtURLBar";
			this.txtURLBar.ReadOnly = true;
			this.txtURLBar.Size = new System.Drawing.Size(500, 31);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// btnStop
			// 
			this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
			this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(28, 28);
			this.btnStop.Text = "Stop";
			// 
			// webBrowser1
			// 
			this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.webBrowser1.Location = new System.Drawing.Point(0, 37);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScriptErrorsSuppressed = true;
			this.webBrowser1.Size = new System.Drawing.Size(694, 470);
			this.webBrowser1.TabIndex = 2;
			this.webBrowser1.Url = new System.Uri("https://archive.org/details/softwarelibrary_apple", System.UriKind.Absolute);
			this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
			this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
			// 
			// picLoad
			// 
			this.picLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picLoad.Image = ((System.Drawing.Image)(resources.GetObject("picLoad.Image")));
			this.picLoad.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLoad.InitialImage")));
			this.picLoad.Location = new System.Drawing.Point(662, 2);
			this.picLoad.Name = "picLoad";
			this.picLoad.Size = new System.Drawing.Size(32, 32);
			this.picLoad.TabIndex = 3;
			this.picLoad.TabStop = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabBrowser);
			this.tabControl1.Controls.Add(this.tabConvert);
			this.tabControl1.Location = new System.Drawing.Point(4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1003, 699);
			this.tabControl1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnClear);
			this.groupBox1.Controls.Add(this.btnConvert);
			this.groupBox1.Controls.Add(this.btnLoad);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtSavePath);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.lstFiles);
			this.groupBox1.Controls.Add(this.txtLoadPath);
			this.groupBox1.Controls.Add(this.btnBrowse);
			this.groupBox1.Location = new System.Drawing.Point(3, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(985, 441);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Files";
			// 
			// btnLoad
			// 
			this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoad.Enabled = false;
			this.btnLoad.Location = new System.Drawing.Point(915, 31);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(60, 20);
			this.btnLoad.TabIndex = 28;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 27;
			this.label2.Text = "Load Path";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 344);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 26;
			this.label1.Text = "Save Path:";
			// 
			// txtSavePath
			// 
			this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSavePath.Location = new System.Drawing.Point(6, 360);
			this.txtSavePath.Name = "txtSavePath";
			this.txtSavePath.ReadOnly = true;
			this.txtSavePath.Size = new System.Drawing.Size(939, 20);
			this.txtSavePath.TabIndex = 24;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(951, 360);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(24, 20);
			this.btnSave.TabIndex = 23;
			this.btnSave.Text = "...";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// lstFiles
			// 
			this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstFiles.ColumnWidth = 400;
			this.lstFiles.FormattingEnabled = true;
			this.lstFiles.Location = new System.Drawing.Point(7, 58);
			this.lstFiles.MultiColumn = true;
			this.lstFiles.Name = "lstFiles";
			this.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lstFiles.Size = new System.Drawing.Size(968, 277);
			this.lstFiles.TabIndex = 22;
			// 
			// txtLoadPath
			// 
			this.txtLoadPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLoadPath.Location = new System.Drawing.Point(6, 31);
			this.txtLoadPath.Name = "txtLoadPath";
			this.txtLoadPath.ReadOnly = true;
			this.txtLoadPath.Size = new System.Drawing.Size(868, 20);
			this.txtLoadPath.TabIndex = 21;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(880, 31);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(29, 21);
			this.btnBrowse.TabIndex = 20;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnClear.Location = new System.Drawing.Point(573, 396);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(197, 25);
			this.btnClear.TabIndex = 31;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// btnConvert
			// 
			this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnConvert.Enabled = false;
			this.btnConvert.Location = new System.Drawing.Point(235, 396);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(197, 25);
			this.btnConvert.TabIndex = 30;
			this.btnConvert.Text = "Convert";
			this.btnConvert.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Ceed";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabConvert.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabBrowser.ResumeLayout(false);
			this.tabBrowser.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.FolderBrowserDialog dlgLoadPath;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.FolderBrowserDialog dlgSavePath;
		private System.Windows.Forms.Timer tmrColorChange;
		private System.Windows.Forms.TabPage tabConvert;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkEmulatedDrive;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboAppleType;
		private System.Windows.Forms.CheckBox chkAutoUnzip;
		private System.Windows.Forms.TabPage tabBrowser;
		private System.Windows.Forms.PictureBox picLoad;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnBack;
		private System.Windows.Forms.ToolStripButton btnFwd;
		private System.Windows.Forms.ToolStripButton btnHome;
		private System.Windows.Forms.ToolStripTextBox txtURLBar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnStop;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSavePath;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ListBox lstFiles;
		private System.Windows.Forms.TextBox txtLoadPath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnConvert;
	}
}

