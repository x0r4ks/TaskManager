using System.Drawing;
using System.Collections;

namespace TaskManager
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageProcesses = new System.Windows.Forms.TabPage();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.timer_processesUpdate = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.memSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cb_memSize = new System.Windows.Forms.ToolStripComboBox();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.columntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.workingSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.peakWorkingSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listView_Processes = new TaskManager.ListViewSmooth();
			this.pID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabControl.SuspendLayout();
			this.tabPageProcesses.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabPageProcesses);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Location = new System.Drawing.Point(0, 27);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(704, 389);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageProcesses
			// 
			this.tabPageProcesses.Controls.Add(this.listView_Processes);
			this.tabPageProcesses.Location = new System.Drawing.Point(4, 22);
			this.tabPageProcesses.Name = "tabPageProcesses";
			this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageProcesses.Size = new System.Drawing.Size(696, 363);
			this.tabPageProcesses.TabIndex = 0;
			this.tabPageProcesses.Text = "Processos";
			this.tabPageProcesses.UseVisualStyleBackColor = true;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(91, 26);
			// 
			// killToolStripMenuItem
			// 
			this.killToolStripMenuItem.Name = "killToolStripMenuItem";
			this.killToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
			this.killToolStripMenuItem.Text = "Kill";
			this.killToolStripMenuItem.Click += new System.EventHandler(this.killToolStripMenuItem_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(696, 363);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// statusStrip
			// 
			this.statusStrip.Location = new System.Drawing.Point(0, 419);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(704, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip";
			// 
			// timer_processesUpdate
			// 
			this.timer_processesUpdate.Enabled = true;
			this.timer_processesUpdate.Interval = 1000;
			this.timer_processesUpdate.Tick += new System.EventHandler(this.timer_processesUpdate_Tick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(704, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runNewTaskToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// runNewTaskToolStripMenuItem
			// 
			this.runNewTaskToolStripMenuItem.Name = "runNewTaskToolStripMenuItem";
			this.runNewTaskToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.runNewTaskToolStripMenuItem.Text = "Run new Task";
			this.runNewTaskToolStripMenuItem.Click += new System.EventHandler(this.runNewTaskToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memSizeToolStripMenuItem,
            this.findToolStripMenuItem,
            this.columntsToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// memSizeToolStripMenuItem
			// 
			this.memSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cb_memSize});
			this.memSizeToolStripMenuItem.Name = "memSizeToolStripMenuItem";
			this.memSizeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.memSizeToolStripMenuItem.Text = "Mem Size";
			// 
			// cb_memSize
			// 
			this.cb_memSize.Items.AddRange(new object[] {
            "Bytes",
            "KiB",
            "MiB",
            "GiB"});
			this.cb_memSize.Name = "cb_memSize";
			this.cb_memSize.Size = new System.Drawing.Size(121, 23);
			this.cb_memSize.TextChanged += new System.EventHandler(this.cb_memSize_TextChanged);
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.findToolStripMenuItem.Text = "Find (NOT WORKING)";
			this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
			// 
			// columntsToolStripMenuItem
			// 
			this.columntsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pIDToolStripMenuItem,
            this.nAMEToolStripMenuItem,
            this.workingSetToolStripMenuItem,
            this.peakWorkingSetToolStripMenuItem});
			this.columntsToolStripMenuItem.Name = "columntsToolStripMenuItem";
			this.columntsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.columntsToolStripMenuItem.Text = "Columnts";
			// 
			// pIDToolStripMenuItem
			// 
			this.pIDToolStripMenuItem.Checked = true;
			this.pIDToolStripMenuItem.CheckOnClick = true;
			this.pIDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.pIDToolStripMenuItem.Name = "pIDToolStripMenuItem";
			this.pIDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.pIDToolStripMenuItem.Text = "PID";
			this.pIDToolStripMenuItem.CheckedChanged += new System.EventHandler(this.pIDToolStripMenuItem_CheckedChanged);
			// 
			// nAMEToolStripMenuItem
			// 
			this.nAMEToolStripMenuItem.Checked = true;
			this.nAMEToolStripMenuItem.CheckOnClick = true;
			this.nAMEToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.nAMEToolStripMenuItem.Name = "nAMEToolStripMenuItem";
			this.nAMEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.nAMEToolStripMenuItem.Text = "NAME";
			this.nAMEToolStripMenuItem.CheckedChanged += new System.EventHandler(this.pIDToolStripMenuItem_CheckedChanged);
			// 
			// workingSetToolStripMenuItem
			// 
			this.workingSetToolStripMenuItem.Checked = true;
			this.workingSetToolStripMenuItem.CheckOnClick = true;
			this.workingSetToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.workingSetToolStripMenuItem.Name = "workingSetToolStripMenuItem";
			this.workingSetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.workingSetToolStripMenuItem.Text = "Working Set";
			this.workingSetToolStripMenuItem.CheckedChanged += new System.EventHandler(this.pIDToolStripMenuItem_CheckedChanged);
			// 
			// peakWorkingSetToolStripMenuItem
			// 
			this.peakWorkingSetToolStripMenuItem.Checked = true;
			this.peakWorkingSetToolStripMenuItem.CheckOnClick = true;
			this.peakWorkingSetToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.peakWorkingSetToolStripMenuItem.Name = "peakWorkingSetToolStripMenuItem";
			this.peakWorkingSetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.peakWorkingSetToolStripMenuItem.Text = "Peak Working Set";
			this.peakWorkingSetToolStripMenuItem.CheckedChanged += new System.EventHandler(this.pIDToolStripMenuItem_CheckedChanged);
			// 
			// listView_Processes
			// 
			this.listView_Processes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pID,
            this.pName,
            this.pPath});
			this.listView_Processes.ContextMenuStrip = this.contextMenuStrip1;
			this.listView_Processes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView_Processes.FullRowSelect = true;
			this.listView_Processes.GridLines = true;
			this.listView_Processes.HideSelection = false;
			this.listView_Processes.Location = new System.Drawing.Point(3, 3);
			this.listView_Processes.MultiSelect = false;
			this.listView_Processes.Name = "listView_Processes";
			this.listView_Processes.Size = new System.Drawing.Size(690, 357);
			this.listView_Processes.TabIndex = 0;
			this.listView_Processes.UseCompatibleStateImageBehavior = false;
			this.listView_Processes.View = System.Windows.Forms.View.Details;
			this.listView_Processes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Processes_ColumnClick);
			// 
			// pID
			// 
			this.pID.Text = "PID";
			// 
			// pName
			// 
			this.pName.Text = "Name";
			// 
			// pPath
			// 
			this.pPath.Text = "Path";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 441);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "TaskManager";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.tabControl.ResumeLayout(false);
			this.tabPageProcesses.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageProcesses;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.StatusStrip statusStrip;
		//private System.Windows.Forms.ListView listView_Processes;
		private ListViewSmooth listView_Processes;
		private System.Windows.Forms.ColumnHeader pID;
		private System.Windows.Forms.ColumnHeader pName;
		private System.Windows.Forms.ColumnHeader pPath;
		private System.Windows.Forms.Timer timer_processesUpdate;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runNewTaskToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem memSizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripComboBox cb_memSize;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem columntsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pIDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nAMEToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem workingSetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem peakWorkingSetToolStripMenuItem;
	}
}

