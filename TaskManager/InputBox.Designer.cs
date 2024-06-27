namespace TaskManager
{
	partial class InputBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBox));
			this.btn_acept = new System.Windows.Forms.Button();
			this.bnt_cancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_overview = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cb_executeProcess = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_acept
			// 
			this.btn_acept.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_acept.Location = new System.Drawing.Point(183, 89);
			this.btn_acept.Name = "btn_acept";
			this.btn_acept.Size = new System.Drawing.Size(72, 19);
			this.btn_acept.TabIndex = 0;
			this.btn_acept.Text = "Acept";
			this.btn_acept.UseVisualStyleBackColor = true;
			this.btn_acept.Click += new System.EventHandler(this.btn_acept_Click);
			// 
			// bnt_cancel
			// 
			this.bnt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bnt_cancel.Location = new System.Drawing.Point(261, 89);
			this.bnt_cancel.Name = "bnt_cancel";
			this.bnt_cancel.Size = new System.Drawing.Size(72, 19);
			this.bnt_cancel.TabIndex = 0;
			this.bnt_cancel.Text = "Cancel";
			this.bnt_cancel.UseVisualStyleBackColor = true;
			this.bnt_cancel.Click += new System.EventHandler(this.bnt_cancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(114, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Execute:";
			// 
			// btn_overview
			// 
			this.btn_overview.Location = new System.Drawing.Point(339, 89);
			this.btn_overview.Name = "btn_overview";
			this.btn_overview.Size = new System.Drawing.Size(72, 19);
			this.btn_overview.TabIndex = 0;
			this.btn_overview.Text = "Overview ";
			this.btn_overview.UseVisualStyleBackColor = true;
			this.btn_overview.Click += new System.EventHandler(this.btn_overview_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 96);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// cb_executeProcess
			// 
			this.cb_executeProcess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cb_executeProcess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cb_executeProcess.FormattingEnabled = true;
			this.cb_executeProcess.Location = new System.Drawing.Point(117, 28);
			this.cb_executeProcess.Name = "cb_executeProcess";
			this.cb_executeProcess.Size = new System.Drawing.Size(294, 21);
			this.cb_executeProcess.TabIndex = 4;
			// 
			// InputBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 120);
			this.Controls.Add(this.cb_executeProcess);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_overview);
			this.Controls.Add(this.bnt_cancel);
			this.Controls.Add(this.btn_acept);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InputBox";
			this.Text = "InputBox";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_acept;
		private System.Windows.Forms.Button bnt_cancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_overview;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cb_executeProcess;
	}
}