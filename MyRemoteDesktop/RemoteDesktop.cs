using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSTSCLib;

namespace MyRemoteDesktop
{
    public partial class RemoteDesktop : Form
    {
        public RemoteDesktop()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try 
            {
                rdp.Server = tb_servername.Text;
                rdp.Server = tb_username.Text;
                rdp.Server = tb_password.Text;
                IMsTscNonScriptable secured = (IMsTscNonScriptable)rdp.GetOcx();
                secured.ClearTextPassword = tb_password.Text;
                rdp.Connect();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error", "Error" + tb_servername.Text + "Error" + ex.Message, MessageBoxButtons.OK); 
            }
        }

        private void bnt_disconnect_Click(object sender, EventArgs e)
        {
            try 
            {
                if (rdp.Connected.ToString() == "1")
                    rdp.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Error" + tb_servername.Text + "Error" + ex.Message, MessageBoxButtons.OK);
            }
        }
    }
}
