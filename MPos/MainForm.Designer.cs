namespace MPos
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conShowScaled = new System.Windows.Forms.ToolStripMenuItem();
            this.conShowRelative = new System.Windows.Forms.ToolStripMenuItem();
            this.conShowDpi = new System.Windows.Forms.ToolStripMenuItem();
            this.conShowResolution = new System.Windows.Forms.ToolStripMenuItem();
            this.conShowColor = new System.Windows.Forms.ToolStripMenuItem();
            this.conShowMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.conShownData = new System.Windows.Forms.ToolStripMenuItem();
            this.lstPositions = new System.Windows.Forms.ListBox();
            this.contextList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conPositionsCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.conPositionsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.conCopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.conClearPositionLog = new System.Windows.Forms.ToolStripMenuItem();
            this.panDraw = new System.Windows.Forms.Panel();
            this.contextMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conStart = new System.Windows.Forms.ToolStripMenuItem();
            this.conLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.conTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.conPositionsVisibleMain = new System.Windows.Forms.ToolStripMenuItem();
            this.conShowInTaskbar = new System.Windows.Forms.ToolStripMenuItem();
            this.conDarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.conOpacity = new System.Windows.Forms.ToolStripMenuItem();
            this.trackOpacity = new MPos.Controls.TrackBarMenuItem();
            this.conCustomizeMain = new System.Windows.Forms.ToolStripMenuItem();
            this.conShortcut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.conAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.conExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblHelp = new System.Windows.Forms.Label();
            this.contextView.SuspendLayout();
            this.contextList.SuspendLayout();
            this.contextMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextView
            // 
            this.contextView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conShowScaled,
            this.conShowRelative,
            this.conShowDpi,
            this.conShowResolution,
            this.conShowColor,
            this.conShowMonitor});
            this.contextView.Name = "contextView";
            this.contextView.OwnerItem = this.conShownData;
            this.contextView.Size = new System.Drawing.Size(234, 124);
            this.contextView.Opening += new System.ComponentModel.CancelEventHandler(this.contextView_Opening);
            // 
            // conShowScaled
            // 
            this.conShowScaled.Name = "conShowScaled";
            this.conShowScaled.Size = new System.Drawing.Size(233, 24);
            this.conShowScaled.Tag = "Scaled";
            this.conShowScaled.Text = "Dpi-Scaled Position";
            this.conShowScaled.Click += new System.EventHandler(this.shownDataItem_Click);
            // 
            // conShowRelative
            // 
            this.conShowRelative.Name = "conShowRelative";
            this.conShowRelative.Size = new System.Drawing.Size(233, 24);
            this.conShowRelative.Tag = "Relative";
            this.conShowRelative.Text = "Relative Position";
            this.conShowRelative.Click += new System.EventHandler(this.shownDataItem_Click);
            // 
            // conShowDpi
            // 
            this.conShowDpi.Name = "conShowDpi";
            this.conShowDpi.Size = new System.Drawing.Size(233, 24);
            this.conShowDpi.Tag = "Dpi";
            this.conShowDpi.Text = "Dpi Information";
            this.conShowDpi.Click += new System.EventHandler(this.shownDataItem_Click);

            // 
            // conShowResolution
            // 
            this.conShowResolution.Name = "conShowResolution";
            this.conShowResolution.Size = new System.Drawing.Size(233, 24);
            this.conShowResolution.Tag = "ScreenResolution";
            this.conShowResolution.Text = "Screen Resolution";
            this.conShowResolution.Click += new System.EventHandler(this.shownDataItem_Click);
            // 
            // conShowColor
            // 
            this.conShowColor.Name = "conShowColor";
            this.conShowColor.Size = new System.Drawing.Size(233, 24);
            this.conShowColor.Tag = "PixelColor";
            this.conShowColor.Text = "Color at Cursor Position";
            this.conShowColor.Click += new System.EventHandler(this.shownDataItem_Click);
            // Monitor
            this.conShowMonitor.Name = "conShowMonitor";
            this.conShowMonitor.Size = new System.Drawing.Size(200, 22);
            this.conShowMonitor.Tag = "ShowMonitorName";
            this.conShowMonitor.Text = "Monitor Name";
            this.conShowMonitor.Click += new System.EventHandler(this.shownDataItem_Click);
            // 
            // conShownData
            // 
            this.conShownData.DropDown = this.contextView;
            this.conShownData.Name = "conShownData";
            this.conShownData.Size = new System.Drawing.Size(248, 24);
            this.conShownData.Text = "Shown Data";
            // 
            // lstPositions
            // 
            this.lstPositions.BackColor = System.Drawing.SystemColors.Control;
            this.lstPositions.ContextMenuStrip = this.contextList;
            this.lstPositions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstPositions.FormattingEnabled = true;
            this.lstPositions.IntegralHeight = false;
            this.lstPositions.ItemHeight = 16;
            this.lstPositions.Location = new System.Drawing.Point(0, 244);
            this.lstPositions.Margin = new System.Windows.Forms.Padding(0);
            this.lstPositions.Name = "lstPositions";
            this.lstPositions.Size = new System.Drawing.Size(293, 73);
            this.lstPositions.TabIndex = 1;
            this.lstPositions.Click += new System.EventHandler(this.lstPositions_Click);
            this.lstPositions.LocationChanged += new System.EventHandler(this.lstPositions_LocationChanged);
            this.lstPositions.SizeChanged += new System.EventHandler(this.lstPositions_SizeChanged);
            this.lstPositions.VisibleChanged += new System.EventHandler(this.lstPositions_VisibleChanged);
            // 
            // contextList
            // 
            this.contextList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conPositionsCopy,
            this.conPositionsDelete,
            this.toolStripSeparator4,
            this.conCopyAll,
            this.conClearPositionLog});
            this.contextList.Name = "contextList";
            this.contextList.Size = new System.Drawing.Size(187, 106);
            this.contextList.Opening += new System.ComponentModel.CancelEventHandler(this.contextList_Opening);
            // 
            // conPositionsCopy
            // 
            this.conPositionsCopy.Name = "conPositionsCopy";
            this.conPositionsCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.conPositionsCopy.Size = new System.Drawing.Size(186, 24);
            this.conPositionsCopy.Text = "Copy";
            this.conPositionsCopy.Click += new System.EventHandler(this.conPositionsCopy_Click);
            // 
            // conPositionsDelete
            // 
            this.conPositionsDelete.Name = "conPositionsDelete";
            this.conPositionsDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.conPositionsDelete.Size = new System.Drawing.Size(186, 24);
            this.conPositionsDelete.Text = "Delete";
            this.conPositionsDelete.Click += new System.EventHandler(this.conPositionsDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(183, 6);
            // 
            // conCopyAll
            // 
            this.conCopyAll.Name = "conCopyAll";
            this.conCopyAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.conCopyAll.Size = new System.Drawing.Size(186, 24);
            this.conCopyAll.Text = "Copy All";
            this.conCopyAll.Click += new System.EventHandler(this.conCopyAll_Click);
            // 
            // conClearPositionLog
            // 
            this.conClearPositionLog.Name = "conClearPositionLog";
            this.conClearPositionLog.Size = new System.Drawing.Size(186, 24);
            this.conClearPositionLog.Text = "Delete All";
            this.conClearPositionLog.Click += new System.EventHandler(this.conClearPositions_Click);
            // 
            // panDraw
            // 
            this.panDraw.ContextMenuStrip = this.contextMain;
            this.panDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDraw.Location = new System.Drawing.Point(0, 0);
            this.panDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panDraw.Name = "panDraw";
            this.panDraw.Size = new System.Drawing.Size(293, 244);
            this.panDraw.TabIndex = 3;
            // 
            // contextMain
            // 
            this.contextMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conStart,
            this.conLog,
            this.conShownData,
            this.toolStripSeparator1,
            this.conTopmost,
            this.conPositionsVisibleMain,
            this.conShowInTaskbar,
            this.conDarkMode,
            this.conOpacity,
            this.conCustomizeMain,
            this.conShortcut,
            this.toolStripSeparator2,
            this.conAbout,
            this.conExit});
            this.contextMain.Name = "contextMain";
            this.contextMain.ShowCheckMargin = true;
            this.contextMain.ShowImageMargin = false;
            this.contextMain.Size = new System.Drawing.Size(249, 304);
            this.contextMain.Opening += new System.ComponentModel.CancelEventHandler(this.contextMain_Opening);
            // 
            // conStart
            // 
            this.conStart.Name = "conStart";
            this.conStart.ShortcutKeyDisplayString = "F5";
            this.conStart.Size = new System.Drawing.Size(248, 24);
            this.conStart.Text = "Start/ Stop Capturing";
            this.conStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // conLog
            // 
            this.conLog.Name = "conLog";
            this.conLog.Size = new System.Drawing.Size(248, 24);
            this.conLog.Text = "Grab Position";
            this.conLog.Click += new System.EventHandler(this.conLog_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // conTopmost
            // 
            this.conTopmost.Name = "conTopmost";
            this.conTopmost.ShortcutKeyDisplayString = "Ctrl+T";
            this.conTopmost.Size = new System.Drawing.Size(248, 24);
            this.conTopmost.Text = "Stay on Top";
            this.conTopmost.Click += new System.EventHandler(this.conTopmost_Click);
            // 
            // conPositionsVisibleMain
            // 
            this.conPositionsVisibleMain.Name = "conPositionsVisibleMain";
            this.conPositionsVisibleMain.ShortcutKeyDisplayString = "Ctrl+L";
            this.conPositionsVisibleMain.Size = new System.Drawing.Size(248, 24);
            this.conPositionsVisibleMain.Text = "Show Position Log";
            this.conPositionsVisibleMain.Click += new System.EventHandler(this.conPositionsVisible_Click);
            // 
            // conShowInTaskbar
            // 
            this.conShowInTaskbar.Name = "conShowInTaskbar";
            this.conShowInTaskbar.Size = new System.Drawing.Size(248, 24);
            this.conShowInTaskbar.Text = "Show in Taskbar";
            this.conShowInTaskbar.Click += new System.EventHandler(this.conShowInTaskbar_Click);
            // 
            // conDarkMode
            // 
            this.conDarkMode.Name = "conDarkMode";
            this.conDarkMode.Size = new System.Drawing.Size(248, 24);
            this.conDarkMode.Text = "Dark Mode";
            this.conDarkMode.Click += new System.EventHandler(this.conDarkMode_Click);
            // 
            // conOpacity
            // 
            this.conOpacity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trackOpacity});
            this.conOpacity.Name = "conOpacity";
            this.conOpacity.Size = new System.Drawing.Size(248, 24);
            this.conOpacity.Text = "Opacity";
            // 
            // trackOpacity
            // 
            this.trackOpacity.Name = "trackOpacity";
            this.trackOpacity.Size = new System.Drawing.Size(104, 20);
            this.trackOpacity.Text = "trackBarMenuItem2";
            this.trackOpacity.ToolTipText = "Set Opacity";
            this.trackOpacity.TrackBarValue = 10;
            this.trackOpacity.ValueChanged += new System.EventHandler<MPos.Controls.TrackBarEventArgs>(this.trackOpacity_ValueChanged);
            // 
            // conCustomizeMain
            // 
            this.conCustomizeMain.Name = "conCustomizeMain";
            this.conCustomizeMain.ShortcutKeyDisplayString = "Ctrl+,";
            this.conCustomizeMain.Size = new System.Drawing.Size(248, 24);
            this.conCustomizeMain.Text = "Customize...";
            this.conCustomizeMain.Click += new System.EventHandler(this.conCustomize_Click);
            // 
            // conShortcut
            // 
            this.conShortcut.Name = "conShortcut";
            this.conShortcut.Size = new System.Drawing.Size(248, 24);
            this.conShortcut.Text = "Configure Shortcut...";
            this.conShortcut.Click += new System.EventHandler(this.conShortcut_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(245, 6);
            // 
            // conAbout
            // 
            this.conAbout.Name = "conAbout";
            this.conAbout.ShortcutKeyDisplayString = "F1";
            this.conAbout.Size = new System.Drawing.Size(248, 24);
            this.conAbout.Text = "About";
            this.conAbout.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // conExit
            // 
            this.conExit.Name = "conExit";
            this.conExit.ShortcutKeyDisplayString = "Esc";
            this.conExit.Size = new System.Drawing.Size(248, 24);
            this.conExit.Text = "Exit";
            this.conExit.Click += new System.EventHandler(this.conExit_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMain;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MPos - Mouse Position Tracker";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHelp.Location = new System.Drawing.Point(0, 207);
            this.lblHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(293, 74);
            this.lblHelp.TabIndex = 4;
            this.lblHelp.Text = "No shortcut.";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHelp.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(293, 317);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.panDraw);
            this.Controls.Add(this.lstPositions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MPos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextView.ResumeLayout(false);
            this.contextList.ResumeLayout(false);
            this.contextMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstPositions;
        private System.Windows.Forms.Panel panDraw;
        private System.Windows.Forms.ContextMenuStrip contextMain;
        private System.Windows.Forms.ToolStripMenuItem conShownData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem conTopmost;
        private System.Windows.Forms.ToolStripMenuItem conShowInTaskbar;
        private System.Windows.Forms.ToolStripMenuItem conDarkMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem conAbout;
        private System.Windows.Forms.ToolStripMenuItem conExit;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem conOpacity;
        private Controls.TrackBarMenuItem trackOpacity;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextList;
        private System.Windows.Forms.ToolStripMenuItem conPositionsCopy;
        private System.Windows.Forms.ToolStripMenuItem conPositionsDelete;
        private System.Windows.Forms.ToolStripMenuItem conStart;
        private System.Windows.Forms.ToolStripMenuItem conLog;
        private System.Windows.Forms.ToolStripMenuItem conCopyAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem conPositionsVisibleMain;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.ContextMenuStrip contextView;
        private System.Windows.Forms.ToolStripMenuItem conShowScaled;
        private System.Windows.Forms.ToolStripMenuItem conShowRelative;
        private System.Windows.Forms.ToolStripMenuItem conShowDpi;
        private System.Windows.Forms.ToolStripMenuItem conShowColor;
        private System.Windows.Forms.ToolStripMenuItem conShowMonitor;
        private System.Windows.Forms.ToolStripMenuItem conShowResolution;
        private System.Windows.Forms.ToolStripMenuItem conCustomizeMain;
        private System.Windows.Forms.ToolStripMenuItem conClearPositionLog;
        private System.Windows.Forms.ToolStripMenuItem conShortcut;
    }
}

