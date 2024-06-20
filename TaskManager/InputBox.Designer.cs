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
			this.tb_executeProg = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_acept
			// 
			this.btn_acept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_acept.Location = new System.Drawing.Point(238, 38);
			this.btn_acept.Name = "btn_acept";
			this.btn_acept.Size = new System.Drawing.Size(72, 19);
			this.btn_acept.TabIndex = 0;
			this.btn_acept.Text = "Acept";
			this.btn_acept.UseVisualStyleBackColor = true;
			this.btn_acept.Click += new System.EventHandler(this.btn_acept_Click);
			// 
			// bnt_cancel
			// 
			this.bnt_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bnt_cancel.Location = new System.Drawing.Point(319, 38);
			this.bnt_cancel.Name = "bnt_cancel";
			this.bnt_cancel.Size = new System.Drawing.Size(72, 19);
			this.bnt_cancel.TabIndex = 0;
			this.bnt_cancel.Text = "Cancel";
			this.bnt_cancel.UseVisualStyleBackColor = true;
			this.bnt_cancel.Click += new System.EventHandler(this.bnt_cancel_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Execute:";
			// 
			// tb_executeProg
			// 
			this.tb_executeProg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_executeProg.Location = new System.Drawing.Point(74, 12);
			this.tb_executeProg.Name = "tb_executeProg";
			this.tb_executeProg.Size = new System.Drawing.Size(319, 20);
			this.tb_executeProg.TabIndex = 2;
			// 
			// InputBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 81);
			this.Controls.Add(this.tb_executeProg);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bnt_cancel);
			this.Controls.Add(this.btn_acept);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(420, 120);
			this.MinimumSize = new System.Drawing.Size(420, 120);
			this.Name = "InputBox";
			this.Text = "InputBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_acept;
		private System.Windows.Forms.Button bnt_cancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_executeProg;
	}
}