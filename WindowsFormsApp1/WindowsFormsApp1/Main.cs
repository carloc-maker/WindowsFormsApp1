using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static WindowsFormsApp1.Login;

namespace WindowsFormsApp1
{
    public partial class Main: Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginwindow = new Login();

            loginwindow.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Network networkwindow = new Network();

            networkwindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Upload GPG file",
                Filter = "File GPG (*.gpg)|*.gpg",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string filePath = openFileDialog.FileName;
            MessageBox.Show($"File selezionato:\n{filePath}", "File Selezionato");

            // Caricare il file via API
            // await UploadFile(filePath);

        }

        private async void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
