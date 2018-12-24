namespace CeqPlayer {
	partial class Window {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.PlayBtn = new System.Windows.Forms.Button();
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// PlayBtn
			// 
			this.PlayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PlayBtn.Location = new System.Drawing.Point(12, 12);
			this.PlayBtn.Name = "PlayBtn";
			this.PlayBtn.Size = new System.Drawing.Size(153, 24);
			this.PlayBtn.TabIndex = 0;
			this.PlayBtn.Text = "Play .ceq file";
			this.PlayBtn.UseVisualStyleBackColor = true;
			this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
			// 
			// OpenFileDialog
			// 
			this.OpenFileDialog.AddExtension = false;
			this.OpenFileDialog.DefaultExt = "ceq";
			this.OpenFileDialog.Filter = "CEQ File|*.ceq";
			this.OpenFileDialog.Title = "Open File";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(177, 48);
			this.Controls.Add(this.PlayBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "CEQ Player";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button PlayBtn;
		private System.Windows.Forms.OpenFileDialog OpenFileDialog;
	}
}

