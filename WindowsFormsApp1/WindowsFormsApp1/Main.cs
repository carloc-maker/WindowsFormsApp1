using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static WindowsFormsApp1.Login;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        private string Token => SessionData.Token;
        private string Ip => SessionData.IpLogin;


        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Login loginWindow = new Login();
            loginWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Network networkWindow = new Network();
            networkWindow.Show();
        }

        private async void button3_Click(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(Token))
            {
                MessageBox.Show("Il token utente non è valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string apiUrl = $"http://{Ip}/api/v1/system/update";

            try
            {
                using (var httpClient = new HttpClient())
                using (var multipartContent = new MultipartFormDataContent())
                using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (var fileContent = new StreamContent(fileStream))
                {
                    
                    fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                    
                    multipartContent.Add(fileContent, "file", Path.GetFileName(filePath));

                    
                    httpClient.DefaultRequestHeaders.Clear();
                    httpClient.DefaultRequestHeaders.Add("x-user-token", Token);

                    
                    HttpResponseMessage response = await httpClient.PostAsync(apiUrl, multipartContent);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Risposta: {responseString}", "Risposta API", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Errore: {errorMessage}", "Errore API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la richiesta: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void button4_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Token))
            {
                MessageBox.Show("Il token utente non è valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
                return;
            }


            string apiUrl = $"http://{Ip}/api/v1/system/reboot";

            
            var payload = new { };
            string jsonPayload = JsonConvert.SerializeObject(payload);

            
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");


            try
            {
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("x-user-token", Token);

                HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

                
                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Risposta: {responseString}", "Risposta API", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Errore: {errorMessage}", "Errore API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Errore durante la richiesta: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Token))
            {
                MessageBox.Show("Il token utente non è valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string apiUrl = $"http://{Ip}/api/v1/system/device-description";

            try
            {
                
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("x-user-token", Token);

                
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Risposta: {responseString}", "Risposta API", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Errore: {errorMessage}", "Errore API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la richiesta: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Token))
            {
                MessageBox.Show("Il token utente non è valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string apiUrl = $"http://{Ip}/api/v1/system/status";

            try
            {

                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("x-user-token", Token);


                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Risposta: {responseString}", "Risposta API", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Errore: {errorMessage}", "Errore API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la richiesta: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
