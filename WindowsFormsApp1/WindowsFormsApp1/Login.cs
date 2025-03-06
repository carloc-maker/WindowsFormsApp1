using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        
        public string Ip { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        
        public static class SessionData
        {
            public static string Token { get; set; }
            public static string Ip { get; set; }
        }

        public Login()
        {
            InitializeComponent();
        }

        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Ip = textBox3.Text.Trim();
            SessionData.Ip = Ip;
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Username = textBox1.Text.Trim();
        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Password = textBox2.Text.Trim();
        }

        
        private async void button3_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(Ip))
            {
                MessageBox.Show("L'IP non può essere vuoto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Username e Password non possono essere vuoti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string apiUrl = $"http://{Ip}/api/v1/security/login/{Username}/{Password}";

            
            var response = await SendApiRequest(apiUrl);

            if (response != null)
            {
                
                SessionData.Token = response;
                MessageBox.Show($"Token: {SessionData.Token}");

                
                Close();
            }
            else
            {
                MessageBox.Show("Errore nella chiamata API.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private async Task<string> SendApiRequest(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show($"Errore durante la chiamata API: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        
        private void label3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        
        private void Login_Load(object sender, EventArgs e) { }
    }
}
