namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Login = new System.Windows.Forms.Button();
            this.Network_Trigger = new System.Windows.Forms.Button();
            this.Firmware_Update = new System.Windows.Forms.Button();
            this.Device_Reboot = new System.Windows.Forms.Button();
            this.Device_Information = new System.Windows.Forms.Button();
            this.Camera_Status = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(37, 35);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(160, 71);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Network_Trigger
            // 
            this.Network_Trigger.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Network_Trigger.Location = new System.Drawing.Point(37, 159);
            this.Network_Trigger.Name = "Network_Trigger";
            this.Network_Trigger.Size = new System.Drawing.Size(244, 75);
            this.Network_Trigger.TabIndex = 4;
            this.Network_Trigger.Text = "Network Trigger";
            this.Network_Trigger.UseVisualStyleBackColor = true;
            this.Network_Trigger.Click += new System.EventHandler(this.button2_Click);
            // 
            // Firmware_Update
            // 
            this.Firmware_Update.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firmware_Update.Location = new System.Drawing.Point(298, 159);
            this.Firmware_Update.Name = "Firmware_Update";
            this.Firmware_Update.Size = new System.Drawing.Size(245, 75);
            this.Firmware_Update.TabIndex = 5;
            this.Firmware_Update.Text = "Firmware Update";
            this.Firmware_Update.UseVisualStyleBackColor = true;
            this.Firmware_Update.Click += new System.EventHandler(this.button3_Click);
            // 
            // Device_Reboot
            // 
            this.Device_Reboot.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Device_Reboot.Location = new System.Drawing.Point(37, 321);
            this.Device_Reboot.Name = "Device_Reboot";
            this.Device_Reboot.Size = new System.Drawing.Size(244, 75);
            this.Device_Reboot.TabIndex = 8;
            this.Device_Reboot.Text = "Device Reboot";
            this.Device_Reboot.UseVisualStyleBackColor = true;
            this.Device_Reboot.Click += new System.EventHandler(this.button4_Click);
            // 
            // Device_Information
            // 
            this.Device_Information.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Device_Information.Location = new System.Drawing.Point(297, 240);
            this.Device_Information.Name = "Device_Information";
            this.Device_Information.Size = new System.Drawing.Size(244, 75);
            this.Device_Information.TabIndex = 7;
            this.Device_Information.Text = "Device Information";
            this.Device_Information.UseVisualStyleBackColor = true;
            this.Device_Information.Click += new System.EventHandler(this.button5_Click);
            // 
            // Camera_Status
            // 
            this.Camera_Status.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera_Status.Location = new System.Drawing.Point(298, 321);
            this.Camera_Status.Name = "Camera_Status";
            this.Camera_Status.Size = new System.Drawing.Size(244, 75);
            this.Camera_Status.TabIndex = 9;
            this.Camera_Status.Text = "Camera Status";
            this.Camera_Status.UseVisualStyleBackColor = true;
            this.Camera_Status.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(37, 240);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(244, 75);
            this.button7.TabIndex = 6;
            this.button7.Text = "Support Package";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(218, 463);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(63, 28);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 21);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(606, 513);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Camera_Status);
            this.Controls.Add(this.Device_Information);
            this.Controls.Add(this.Device_Reboot);
            this.Controls.Add(this.Firmware_Update);
            this.Controls.Add(this.Network_Trigger);
            this.Controls.Add(this.Login);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Stark FAE Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Network_Trigger;
        private System.Windows.Forms.Button Firmware_Update;
        private System.Windows.Forms.Button Device_Reboot;
        private System.Windows.Forms.Button Device_Information;
        private System.Windows.Forms.Button Camera_Status;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

