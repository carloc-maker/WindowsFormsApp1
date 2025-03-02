using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace WindowsFormsApp1
{
    public partial class Network: Form
    {

        public string N_Trigger { get; private set; }
        public string Frequency { get; private set; }
        public string Data { get; private set; }
        public string Shift { get; private set; }
        public string Pre { get; private set; }
        public string Post { get; private set; }
        public string TriggerID { get; private set; }
        public string LaneID { get; private set; }

        string token = Login.SessionData.Token;

        string Ip = Login.SessionData.Ip;


        public Network()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            N_Trigger = textBox1.Text.Trim();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Frequency = textBox2.Text.Trim();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Data = textBox3.Text.Trim();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Shift = textBox4.Text.Trim();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Pre = textBox5.Text.Trim();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Post = textBox6.Text.Trim();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            TriggerID = textBox7.Text.Trim();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            LaneID = textBox7.Text.Trim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // string apiUrl = $"http://{Ip}/api/v1/application/triggers/immediate/{TriggerID}";
            MessageBox.Show($"Token: {token}");
        }
    }
}
