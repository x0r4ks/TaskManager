﻿using System.Drawing;
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
			this.listView_Processes = new TaskManager.ListViewSmooth();
			this.pID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.timer_processesUpdate = new System.Windows.Forms.Timer(this.components);
			this.tabControl.SuspendLayout();
			this.tabPageProcesses.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabPageProcesses);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(704, 416);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageProcesses
			// 
			this.tabPageProcesses.Controls.Add(this.listView_Processes);
			this.tabPageProcesses.Location = new System.Drawing.Point(4, 22);
			this.tabPageProcesses.Name = "tabPageProcesses";
			this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageProcesses.Size = new System.Drawing.Size(696, 390);
			this.tabPageProcesses.TabIndex = 0;
			this.tabPageProcesses.Text = "Processos";
			this.tabPageProcesses.UseVisualStyleBackColor = true;
			// 
			// listView_Processes
			// 
			this.listView_Processes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pID,
            this.pName,
            this.pPath});
			this.listView_Processes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView_Processes.FullRowSelect = true;
			this.listView_Processes.GridLines = true;
			this.listView_Processes.HideSelection = false;
			this.listView_Processes.Location = new System.Drawing.Point(3, 3);
			this.listView_Processes.MultiSelect = false;
			this.listView_Processes.Name = "listView_Processes";
			this.listView_Processes.Size = new System.Drawing.Size(690, 384);
			this.listView_Processes.TabIndex = 0;
			this.listView_Processes.UseCompatibleStateImageBehavior = false;
			this.listView_Processes.View = System.Windows.Forms.View.Details;
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
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(696, 390);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 441);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.tabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "TaskManager";
			this.tabControl.ResumeLayout(false);
			this.tabPageProcesses.ResumeLayout(false);
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
	}
}

