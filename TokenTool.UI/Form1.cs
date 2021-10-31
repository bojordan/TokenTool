using System;
using System.Data;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using TokenTool.Core;

namespace TokenTool.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var configFile = System.IO.File.ReadAllText("config.json");
            var config = JsonSerializer.Deserialize<TokenToolConfig>(configFile);

            InitializeComponent();

            this.cbResourceScope.Items.AddRange(config.ResourceScopes.Select(x => x.ResourceOrScope).ToArray());
            this.cbClientId.Items.AddRange(config.ClientIds.Select(x => x.ClientId).ToArray());
            this.cbAuthCert.Items.AddRange(config.AuthenticationCertificates.Select(x => x.Thumbprint).ToArray());
            this.cbEncryptionCert.Items.AddRange(config.EncryptionCertificates.Select(x => x.SubjectName).ToArray());

            if (this.cbResourceScope.Items.Count > 0)
            {
                this.cbResourceScope.SelectedIndex = 0;
            }

            if (cbClientId.Items.Count > 0)
            {
                this.cbClientId.SelectedIndex = 0;
            }

            if (cbAuthCert.Items.Count > 0)
            {
                this.cbAuthCert.SelectedIndex = 0;
            }

            if (cbEncryptionCert.Items.Count > 0)
            {
                this.cbEncryptionCert.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var resource = this.cbResourceScope.Text;
                var clientId = this.cbClientId.Text;
                var thumbprint = this.cbAuthCert.Text;
                if (rbAdalS2s.Checked)
                {
                    var token = TokenRetrieverAdalS2s.GetAccessTokenAsync(resource, clientId, thumbprint).GetAwaiter().GetResult();
                    this.tbGetTokenOutput.Text = token;
                }
                if (rbMsalS2s.Checked)
                {
                    var token = TokenRetrieverMsalS2s.GetToken(new[] { resource }, clientId, thumbprint);
                    this.tbGetTokenOutput.Text = token;
                }
                if (rbMsalObo.Checked)
                {
                    var jwtToken = this.tbUserAssertJwt.Text;
                    string encryptionCertName = null;
                    if (cbEncrypted.Checked)
                    {
                        encryptionCertName = cbEncryptionCert.Text;
                    }
                    var token = TokenRetrieverMsalObo.GetToken(new[] { resource }, clientId, thumbprint, jwtToken, encryptionCertName);
                    this.tbGetTokenOutput.Text = token;
                }

            }
            catch (Exception ex)
            {
                this.tbGetTokenOutput.Text = ex.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tbGetTokenOutput.Text != null)
                {
                    var encryptionCertSubjectName = this.cbEncryptionCert.Text?.Trim();
                    var output = TokenValidator.ValidateReadable(this.tbGetTokenOutput.Text?.Trim(), encryptionCertSubjectName);
                    this.tbDecryptTokenOutput.Text = output;
                }
            }
            catch (Exception ex)
            {
                this.tbDecryptTokenOutput.Text = ex.ToString();
            }
        }

        private void rbMsalS2s_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMsalS2s.Checked || rbMsalObo.Checked)
            {
                if (this.cbResourceScope.Text.IndexOf("/", 8) <= 0)
                {
                    this.cbResourceScope.Text += "/.default";
                }
            }
        }
    }
}
