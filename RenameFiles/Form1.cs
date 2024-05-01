using System.Windows.Forms;

namespace RenameFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();

            string project = folderBrowserDialog.SelectedPath;

            txtFolder.Text = project;           
        }

        private void txtFolder_TextChanged(object sender, EventArgs e)
        {
            if (txtFolder.Text.Length > 0)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            List<string> lstFiles = Directory.GetFiles(txtFolder.Text).ToList();

            foreach (var file in lstFiles)
            {
                if (file.Contains(txtOldName.Text))
                {
                    File.Move(file, file.Replace(txtOldName.Text, txtNewName.Text));
                }
            }

            MessageBox.Show("Finalizado com sucesso");
        }
    }
}
