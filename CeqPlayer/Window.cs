using System;
using System.Windows.Forms;
namespace CeqPlayer {
	public partial class Window : Form {
		public Window() {
			InitializeComponent();
		}
		private void PlayBtn_Click(object sender, EventArgs e) {
			if (OpenFileDialog.ShowDialog() == DialogResult.Cancel) return;
			Ceq.Main.Play(OpenFileDialog.FileName);
		}
	}
}