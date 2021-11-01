using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using TokenTool.Core;

namespace TokenTool.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                var configFile = File.ReadAllText("config.json");
                var config = JsonSerializer.Deserialize<TokenToolConfig>(configFile);

                this.cbResourceScope.Items.AddRange(config.ResourceScopes.Select(x => AddLabel(x.Label, x.ResourceOrScope)).ToArray());
                this.cbClientId.Items.AddRange(config.ClientIds.Select(x => AddLabel(x.Label, x.ClientId)).ToArray());
                this.cbAuthCert.Items.AddRange(config.AuthenticationCertificates.Select(x => AddLabel(x.Label, x.Thumbprint)).ToArray());
                this.cbEncryptionCert.Items.AddRange(config.EncryptionCertificates.Select(x => AddLabel(x.Label, x.SubjectName)).ToArray());
                this.cbAuthority.Items.AddRange(config.Authorities.Select(x => AddLabel(x.Label, x.Authority)).ToArray());
            }
            catch (Exception ex)
            {
                this.tbGetTokenOutput.AppendText(ex.ToString());
            }

            if (this.cbResourceScope.Items.Count > 0)
            {
                this.cbResourceScope.SelectedIndex = 0;
                AppendDefaultScopeToActive();
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

            if (cbAuthority.Items.Count > 0)
            {
                this.cbAuthority.SelectedIndex = 0;
            }
        }

        private static string AddLabel(string label, string payload)
        {
            return $"{label} | {payload}";
        }

        private static string RemoveLabel(string withLabel)
        {
            if (withLabel.Contains("|"))
            {
                var entries = withLabel.Split("|", StringSplitOptions.TrimEntries);
                return entries.Last();
            }
            return withLabel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AppendDefaultScopeToActive();

                var resource = RemoveLabel(this.cbResourceScope.Text);
                var clientId = RemoveLabel(this.cbClientId.Text);
                var thumbprint = RemoveLabel(this.cbAuthCert.Text);
                var authority = RemoveLabel(this.cbAuthority.Text);

                var storeLocation = CertStoreLocation.CurrentUser;
                if (rbAuthCertLocalMachine.Checked)
                {
                    storeLocation = CertStoreLocation.LocalMachine;
                }

                if (rbAdalS2s.Checked)
                {
                    var token = TokenRetrieverAdalS2s.GetAccessTokenAsync(resource, clientId, storeLocation, thumbprint, authority).GetAwaiter().GetResult();
                    this.tbGetTokenOutput.Text = token;
                }
                if (rbMsalS2s.Checked)
                {
                    var token = TokenRetrieverMsalS2s.GetToken(new[] { resource }, clientId, storeLocation, thumbprint, authority);
                    this.tbGetTokenOutput.Text = token;
                }
                if (rbMsalObo.Checked)
                {
                    var jwtToken = this.tbUserAssertJwt.Text;
                    string encryptionCertName = null;
                    if (cbEncrypted.Checked)
                    {
                        encryptionCertName = RemoveLabel(cbEncryptionCert.Text);
                    }
                    var token = TokenRetrieverMsalObo.GetToken(new[] { resource }, clientId, storeLocation, thumbprint, jwtToken, authority, encryptionCertName);
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
                var storeLocation = CertStoreLocation.CurrentUser;
                if (rbEncryptionCertLocalMachine.Checked)
                {
                    storeLocation = CertStoreLocation.LocalMachine;
                }

                if (this.tbGetTokenOutput.Text != null)
                {
                    var encryptionCertSubjectName = RemoveLabel(this.cbEncryptionCert.Text?.Trim());
                    var output = TokenValidator.ValidateReadable(this.tbGetTokenOutput.Text?.Trim(), storeLocation, encryptionCertSubjectName);
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
            AppendDefaultScopeToActive();
        }

        private void AppendDefaultScopeToActive()
        {
            const string defaultScope = "/.default";
            if (rbMsalS2s.Checked || rbMsalObo.Checked)
            {
                if (RemoveLabel(this.cbResourceScope.Text).IndexOf("/", 8) <= 0)
                {
                    this.cbResourceScope.Text += defaultScope;
                }
            }
            else
            {
                var previousValue = this.cbResourceScope.Text;
                if (RemoveLabel(previousValue).EndsWith(defaultScope))
                {
                    this.cbResourceScope.Text = previousValue.Replace(defaultScope, string.Empty);
                }
            }
        }
    }
}
