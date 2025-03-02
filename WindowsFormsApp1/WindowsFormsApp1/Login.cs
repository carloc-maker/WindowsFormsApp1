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

        public string token;

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

            string apiUrl = $"http://{Ip}/api/v1/security/login/{Username}/{Password}";

            //MessageBox.Show($"Chiamata: {apiUrl}"); //Test Chiamata

            // Invio la richiesta API
            var response = await SendApiRequest(apiUrl);

            if (response != null)
            {
                token = response;
                MessageBox.Show($"Token: {token}");
                SessionData.Token = token;
                Close();
            }
            else
            {
                MessageBox.Show("Errore nella chiamata API.");
            }
        }

        private async Task<string> SendApiRequest(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Invia la richiesta GET
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // Restituisci il contenuto della risposta come stringa
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        // Se la risposta non è valida, restituisci null
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante la chiamata API: {ex.Message}");
                    return null;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Puoi aggiungere logica qui se necessario
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Puoi aggiungere logica qui se necessario
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Puoi aggiungere logica qui se necessario
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
