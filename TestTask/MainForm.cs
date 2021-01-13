using System;
using System.Windows.Forms;
using System.IO;

namespace TestTask {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		Finder finder;

		private void buttonOpenFolder_Click(object sender, EventArgs e) {
			folderBrowser.ShowDialog();
			textBoxFolder.Text = folderBrowser.SelectedPath;
		}

		private void buttonStartFind_Click(object sender, EventArgs e) {
			try {
				
				finder = new Finder(textBoxFolder.Text, textBoxFileName.Text);
				finder.GetAll();
				String[] files = finder.cutPath();
				listBox1.Items.Clear();
				listBox1.Items.AddRange(files);
			} catch (Exception ex) {
				Status.Text = "Не верный путь";
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			Show();
		}

		private void radioText_CheckedChanged(object sender, EventArgs e) {
			if (richTextBox2.Text != "") {
				Show();
			}
		}

		private void Show() {
			if (radioText.Checked) {
				richTextBox2.Text = ShowerText.ShowText(finder.Folder + "\\" + listBox1.SelectedItem.ToString());
			}

			if (radioByte.Checked) {
				richTextBox2.Text = ShowerText.ShowBytes(finder.Folder + "\\" + listBox1.SelectedItem.ToString());
			}
		}

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e){
            FileInfo saveOptions = new FileInfo("opt.conf");
            StreamWriter wSaveOptions = saveOptions.CreateText();
            wSaveOptions.WriteLine(textBoxFolder.Text);
            wSaveOptions.WriteLine(textBoxFileName.Text);
            wSaveOptions.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FileInfo saveOptions = new FileInfo("opt.conf");
            if (saveOptions.Exists) {
                StreamReader rSaveOptions = saveOptions.OpenText();
                textBoxFolder.Text = rSaveOptions.ReadLine();
                textBoxFileName.Text = rSaveOptions.ReadLine();
                rSaveOptions.Close();
            }
        }
    }
}
