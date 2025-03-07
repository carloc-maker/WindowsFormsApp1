using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Network : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        public string N_Trigger { get; private set; }
        public string Frequency { get; private set; }
        public string Data { get; private set; }
        public string Shift { get; private set; }
        public string Pre { get; private set; }
        public string Post { get; private set; }
        public string TriggerID { get; private set; }
        public string LaneID { get; private set; }
        private string Token => Login.SessionData.Token;
        private string Ip => Login.SessionData.IpLogin;

        public Network()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) => N_Trigger = textBox1.Text.Trim();
        private void textBox2_TextChanged(object sender, EventArgs e) => Frequency = textBox2.Text.Trim();
        private void textBox3_TextChanged(object sender, EventArgs e) => Data = textBox3.Text.Trim();
        private void textBox4_TextChanged(object sender, EventArgs e) => Shift = textBox4.Text.Trim();
        private void textBox5_TextChanged(object sender, EventArgs e) => Pre = textBox5.Text.Trim();
        private void textBox6_TextChanged(object sender, EventArgs e) => Post = textBox6.Text.Trim();
        private void textBox7_TextChanged(object sender, EventArgs e) => TriggerID = textBox7.Text.Trim();
        private void textBox8_TextChanged(object sender, EventArgs e) => LaneID = textBox8.Text.Trim();

        private async void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Token))
            {
                MessageBox.Show("Il token non è valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(N_Trigger, out int nTrigger) ||
                !int.TryParse(Frequency, out int frequency) ||
                !int.TryParse(Shift, out int shift) ||
                !int.TryParse(Pre, out int pre) ||
                !int.TryParse(Post, out int post))
            {
                MessageBox.Show("Inserisci valori numerici validi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string apiUrl = $"http://{Ip}/api/v1/application/triggers/immediate/{TriggerID}";

            var payload = new
            {
                data = Data,
                lane_alias = LaneID,
                shift_ms = shift,
                pre_ms = pre,
                post_ms = post
            };

            string jsonPayload = JsonConvert.SerializeObject(payload); 

            try
            {
                int counter = 0;
                int successCount = 0; 

                while (counter < nTrigger)
                {
                    httpClient.DefaultRequestHeaders.Clear();
                    httpClient.DefaultRequestHeaders.Add("x-user-token", Token);

                    using (var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json"))
                    {
                        HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);
                        string responseString = await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            successCount++; 
                        }
                        else
                        {
                            MessageBox.Show($"Errore nella risposta API: {responseString}", "Errore API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    counter++;
                    await Task.Delay(frequency * 1000);
                }

                
                MessageBox.Show($"Inviati con successo {successCount} trigger sulla lane {LaneID}.", "Operazione completata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
