
namespace MyRemoteDesktop
{
    partial class RemoteDesktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteDesktop));
            this.rdp = new AxMSTSCLib.AxMsTscAxNotSafeForScripting();
            this.tb_servername = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.MaskedTextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_servername = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.bnt_disconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).BeginInit();
            this.SuspendLayout();
            // 
            // rdp
            // 
            this.rdp.Enabled = true;
            this.rdp.Location = new System.Drawing.Point(30, 26);
            this.rdp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdp.Name = "rdp";
            this.rdp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rdp.OcxState")));
            this.rdp.Size = new System.Drawing.Size(433, 240);
            this.rdp.TabIndex = 0;
            // 
            // tb_servername
            // 
            this.tb_servername.Location = new System.Drawing.Point(160, 345);
            this.tb_servername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_servername.Name = "tb_servername";
            this.tb_servername.Size = new System.Drawing.Size(148, 30);
            this.tb_servername.TabIndex = 1;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(160, 389);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(148, 30);
            this.tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(160, 429);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '●';
            this.tb_password.Size = new System.Drawing.Size(148, 30);
            this.tb_password.TabIndex = 3;
            // 
            // lbl_servername
            // 
            this.lbl_servername.AutoSize = true;
            this.lbl_servername.Location = new System.Drawing.Point(25, 345);
            this.lbl_servername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_servername.Name = "lbl_servername";
            this.lbl_servername.Size = new System.Drawing.Size(127, 25);
            this.lbl_servername.TabIndex = 4;
            this.lbl_servername.Text = "Server Name";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(25, 389);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(110, 25);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "User Name";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(25, 433);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(98, 25);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Password";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(160, 505);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(148, 36);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // bnt_disconnect
            // 
            this.bnt_disconnect.Location = new System.Drawing.Point(160, 561);
            this.bnt_disconnect.Name = "bnt_disconnect";
            this.bnt_disconnect.Size = new System.Drawing.Size(148, 36);
            this.bnt_disconnect.TabIndex = 8;
            this.bnt_disconnect.Text = "Disconnect";
            this.bnt_disconnect.UseVisualStyleBackColor = true;
            this.bnt_disconnect.Click += new System.EventHandler(this.bnt_disconnect_Click);
            // 
            // RemoteDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 630);
            this.Controls.Add(this.bnt_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_servername);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_servername);
            this.Controls.Add(this.rdp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RemoteDesktop";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMSTSCLib.AxMsTscAxNotSafeForScripting rdp;
        private System.Windows.Forms.TextBox tb_servername;
        private System.Windows.Forms.MaskedTextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_servername;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button bnt_disconnect;
    }
}

