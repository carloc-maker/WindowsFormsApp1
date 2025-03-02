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
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(102, 41);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(280, 80);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Network_Trigger
            // 
            this.Network_Trigger.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Network_Trigger.Location = new System.Drawing.Point(102, 127);
            this.Network_Trigger.Name = "Network_Trigger";
            this.Network_Trigger.Size = new System.Drawing.Size(280, 80);
            this.Network_Trigger.TabIndex = 1;
            this.Network_Trigger.Text = "Network Trigger";
            this.Network_Trigger.UseVisualStyleBackColor = true;
            this.Network_Trigger.Click += new System.EventHandler(this.button2_Click);
            // 
            // Firmware_Update
            // 
            this.Firmware_Update.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firmware_Update.Location = new System.Drawing.Point(102, 213);
            this.Firmware_Update.Name = "Firmware_Update";
            this.Firmware_Update.Size = new System.Drawing.Size(280, 80);
            this.Firmware_Update.TabIndex = 2;
            this.Firmware_Update.Text = "Firmware Update";
            this.Firmware_Update.UseVisualStyleBackColor = true;
            this.Firmware_Update.Click += new System.EventHandler(this.button3_Click);
            // 
            // Device_Reboot
            // 
            this.Device_Reboot.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Device_Reboot.Location = new System.Drawing.Point(102, 299);
            this.Device_Reboot.Name = "Device_Reboot";
            this.Device_Reboot.Size = new System.Drawing.Size(280, 80);
            this.Device_Reboot.TabIndex = 3;
            this.Device_Reboot.Text = "Device Reboot";
            this.Device_Reboot.UseVisualStyleBackColor = true;
            this.Device_Reboot.Click += new System.EventHandler(this.button4_Click);
            // 
            // Device_Information
            // 
            this.Device_Information.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Device_Information.Location = new System.Drawing.Point(102, 385);
            this.Device_Information.Name = "Device_Information";
            this.Device_Information.Size = new System.Drawing.Size(280, 80);
            this.Device_Information.TabIndex = 4;
            this.Device_Information.Text = "Device Information";
            this.Device_Information.UseVisualStyleBackColor = true;
            this.Device_Information.Click += new System.EventHandler(this.button5_Click);
            // 
            // Camera_Status
            // 
            this.Camera_Status.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera_Status.Location = new System.Drawing.Point(102, 471);
            this.Camera_Status.Name = "Camera_Status";
            this.Camera_Status.Size = new System.Drawing.Size(280, 80);
            this.Camera_Status.TabIndex = 5;
            this.Camera_Status.Text = "Camera Status";
            this.Camera_Status.UseVisualStyleBackColor = true;
            this.Camera_Status.Click += new System.EventHandler(this.button6_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 639);
            this.Controls.Add(this.Camera_Status);
            this.Controls.Add(this.Device_Information);
            this.Controls.Add(this.Device_Reboot);
            this.Controls.Add(this.Firmware_Update);
            this.Controls.Add(this.Network_Trigger);
            this.Controls.Add(this.Login);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Stark Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Network_Trigger;
        private System.Windows.Forms.Button Firmware_Update;
        private System.Windows.Forms.Button Device_Reboot;
        private System.Windows.Forms.Button Device_Information;
        private System.Windows.Forms.Button Camera_Status;
    }
}

