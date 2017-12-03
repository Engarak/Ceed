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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabBrowser = new System.Windows.Forms.TabPage();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnBack = new System.Windows.Forms.ToolStripButton();
			this.btnFwd = new System.Windows.Forms.ToolStripButton();
			this.btnHome = new System.Windows.Forms.ToolStripButton();
			this.txtURLBar = new System.Windows.Forms.ToolStripTextBox();
			this.btnStop = new System.Windows.Forms.ToolStripButton();
			this.tabConvert = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkAutoUnzip = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnConvert = new System.Windows.Forms.Button();
			this.txtSavePath = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.lstFiles = new System.Windows.Forms.ListBox();
			this.txtLoadPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.dlgLoadPath = new System.Windows.Forms.FolderBrowserDialog();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.dlgSavePath = new System.Windows.Forms.FolderBrowserDialog();
			this.tabControl1.SuspendLayout();
			this.tabBrowser.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tabConvert.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
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
			this.tabControl1.Size = new System.Drawing.Size(705, 536);
			this.tabControl1.TabIndex = 0;
			// 
			// tabBrowser
			// 
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
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnFwd,
            this.btnHome,
            this.txtURLBar,
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
			// btnStop
			// 
			this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
			this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(28, 28);
			this.btnStop.Text = "Stop";
			// 
			// tabConvert
			// 
			this.tabConvert.Controls.Add(this.groupBox2);
			this.tabConvert.Controls.Add(this.groupBox1);
			this.tabConvert.Location = new System.Drawing.Point(4, 22);
			this.tabConvert.Name = "tabConvert";
			this.tabConvert.Padding = new System.Windows.Forms.Padding(3);
			this.tabConvert.Size = new System.Drawing.Size(697, 510);
			this.tabConvert.TabIndex = 1;
			this.tabConvert.Text = "Convert Disk Image";
			this.tabConvert.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.chkAutoUnzip);
			this.groupBox2.Location = new System.Drawing.Point(7, 354);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(684, 150);
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
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnLoad);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnConvert);
			this.groupBox1.Controls.Add(this.txtSavePath);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.lstFiles);
			this.groupBox1.Controls.Add(this.txtLoadPath);
			this.groupBox1.Controls.Add(this.btnBrowse);
			this.groupBox1.Location = new System.Drawing.Point(7, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(684, 341);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Files";
			// 
			// btnLoad
			// 
			this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoad.Enabled = false;
			this.btnLoad.Location = new System.Drawing.Point(614, 38);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(63, 19);
			this.btnLoad.TabIndex = 8;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Load Path";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 256);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Save Path:";
			// 
			// btnConvert
			// 
			this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnConvert.Enabled = false;
			this.btnConvert.Location = new System.Drawing.Point(254, 304);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(147, 25);
			this.btnConvert.TabIndex = 5;
			this.btnConvert.Text = "Convert";
			this.btnConvert.UseVisualStyleBackColor = true;
			// 
			// txtSavePath
			// 
			this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSavePath.Location = new System.Drawing.Point(7, 272);
			this.txtSavePath.Name = "txtSavePath";
			this.txtSavePath.ReadOnly = true;
			this.txtSavePath.Size = new System.Drawing.Size(635, 20);
			this.txtSavePath.TabIndex = 4;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(648, 272);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(29, 20);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "...";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lstFiles
			// 
			this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstFiles.FormattingEnabled = true;
			this.lstFiles.Location = new System.Drawing.Point(6, 73);
			this.lstFiles.MultiColumn = true;
			this.lstFiles.Name = "lstFiles";
			this.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lstFiles.Size = new System.Drawing.Size(671, 173);
			this.lstFiles.TabIndex = 2;
			// 
			// txtLoadPath
			// 
			this.txtLoadPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLoadPath.Location = new System.Drawing.Point(7, 39);
			this.txtLoadPath.Name = "txtLoadPath";
			this.txtLoadPath.ReadOnly = true;
			this.txtLoadPath.Size = new System.Drawing.Size(565, 20);
			this.txtLoadPath.TabIndex = 1;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(578, 38);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(29, 20);
			this.btnBrowse.TabIndex = 0;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 544);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(710, 22);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 566);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Ceed";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabBrowser.ResumeLayout(false);
			this.tabBrowser.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tabConvert.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabBrowser;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnBack;
		private System.Windows.Forms.ToolStripButton btnFwd;
		private System.Windows.Forms.ToolStripButton btnHome;
		private System.Windows.Forms.ToolStripTextBox txtURLBar;
		private System.Windows.Forms.ToolStripButton btnStop;
		private System.Windows.Forms.TabPage tabConvert;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox lstFiles;
		private System.Windows.Forms.TextBox txtLoadPath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.FolderBrowserDialog dlgLoadPath;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtSavePath;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.CheckBox chkAutoUnzip;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.FolderBrowserDialog dlgSavePath;
	}
}

