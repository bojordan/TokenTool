
namespace TokenTool.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cbResourceScope = new System.Windows.Forms.ComboBox();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.cbClientId = new System.Windows.Forms.ComboBox();
            this.cbAuthCert = new System.Windows.Forms.ComboBox();
            this.tbGetTokenOutput = new System.Windows.Forms.TextBox();
            this.tbDecryptTokenOutput = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.cbEncryptionCert = new System.Windows.Forms.ComboBox();
            this.lblResourceScopes = new System.Windows.Forms.Label();
            this.lblClientId = new System.Windows.Forms.Label();
            this.lblAuthCert = new System.Windows.Forms.Label();
            this.lblEncryptionCert = new System.Windows.Forms.Label();
            this.rbAdalS2s = new System.Windows.Forms.RadioButton();
            this.rbMsalS2s = new System.Windows.Forms.RadioButton();
            this.rbMsalObo = new System.Windows.Forms.RadioButton();
            this.tbUserAssertJwt = new System.Windows.Forms.TextBox();
            this.cbEncrypted = new System.Windows.Forms.CheckBox();
            this.lblUserAssertionJwt = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlAuthCertStore = new System.Windows.Forms.Panel();
            this.rbAuthCertCurrentUser = new System.Windows.Forms.RadioButton();
            this.rbAuthCertLocalMachine = new System.Windows.Forms.RadioButton();
            this.lblAuthority = new System.Windows.Forms.Label();
            this.cbAuthority = new System.Windows.Forms.ComboBox();
            this.pnlEncryptionCertStore = new System.Windows.Forms.Panel();
            this.rbEncryptionCertCurrentUser = new System.Windows.Forms.RadioButton();
            this.rbEncryptionCertLocalMachine = new System.Windows.Forms.RadioButton();
            this.cbSubjectNameIssuer = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlAuthCertStore.SuspendLayout();
            this.pnlEncryptionCertStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbResourceScope
            // 
            this.cbResourceScope.FormattingEnabled = true;
            this.cbResourceScope.Location = new System.Drawing.Point(160, 11);
            this.cbResourceScope.Name = "cbResourceScope";
            this.cbResourceScope.Size = new System.Drawing.Size(548, 33);
            this.cbResourceScope.TabIndex = 0;
            // 
            // btnGetToken
            // 
            this.btnGetToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetToken.Location = new System.Drawing.Point(1275, 88);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(112, 34);
            this.btnGetToken.TabIndex = 1;
            this.btnGetToken.Text = "Get token";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbClientId
            // 
            this.cbClientId.FormattingEnabled = true;
            this.cbClientId.Location = new System.Drawing.Point(160, 50);
            this.cbClientId.Name = "cbClientId";
            this.cbClientId.Size = new System.Drawing.Size(548, 33);
            this.cbClientId.TabIndex = 4;
            // 
            // cbAuthCert
            // 
            this.cbAuthCert.FormattingEnabled = true;
            this.cbAuthCert.Location = new System.Drawing.Point(160, 89);
            this.cbAuthCert.Name = "cbAuthCert";
            this.cbAuthCert.Size = new System.Drawing.Size(548, 33);
            this.cbAuthCert.TabIndex = 5;
            // 
            // tbGetTokenOutput
            // 
            this.tbGetTokenOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGetTokenOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.tbGetTokenOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbGetTokenOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.tbGetTokenOutput.Location = new System.Drawing.Point(0, 167);
            this.tbGetTokenOutput.Multiline = true;
            this.tbGetTokenOutput.Name = "tbGetTokenOutput";
            this.tbGetTokenOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGetTokenOutput.Size = new System.Drawing.Size(1399, 581);
            this.tbGetTokenOutput.TabIndex = 7;
            // 
            // tbDecryptTokenOutput
            // 
            this.tbDecryptTokenOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDecryptTokenOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.tbDecryptTokenOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDecryptTokenOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(195)))), ((int)(((byte)(121)))));
            this.tbDecryptTokenOutput.Location = new System.Drawing.Point(0, 57);
            this.tbDecryptTokenOutput.Multiline = true;
            this.tbDecryptTokenOutput.Name = "tbDecryptTokenOutput";
            this.tbDecryptTokenOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDecryptTokenOutput.Size = new System.Drawing.Size(1399, 602);
            this.tbDecryptTokenOutput.TabIndex = 8;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecrypt.Location = new System.Drawing.Point(1266, 17);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(112, 34);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbEncryptionCert
            // 
            this.cbEncryptionCert.FormattingEnabled = true;
            this.cbEncryptionCert.Location = new System.Drawing.Point(140, 17);
            this.cbEncryptionCert.Name = "cbEncryptionCert";
            this.cbEncryptionCert.Size = new System.Drawing.Size(568, 33);
            this.cbEncryptionCert.TabIndex = 10;
            // 
            // lblResourceScopes
            // 
            this.lblResourceScopes.AutoSize = true;
            this.lblResourceScopes.Location = new System.Drawing.Point(15, 14);
            this.lblResourceScopes.Name = "lblResourceScopes";
            this.lblResourceScopes.Size = new System.Drawing.Size(139, 25);
            this.lblResourceScopes.TabIndex = 11;
            this.lblResourceScopes.Text = "Resource/Scope";
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(15, 53);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(79, 25);
            this.lblClientId.TabIndex = 12;
            this.lblClientId.Text = "Client ID";
            // 
            // lblAuthCert
            // 
            this.lblAuthCert.AutoSize = true;
            this.lblAuthCert.Location = new System.Drawing.Point(15, 92);
            this.lblAuthCert.Name = "lblAuthCert";
            this.lblAuthCert.Size = new System.Drawing.Size(84, 25);
            this.lblAuthCert.TabIndex = 13;
            this.lblAuthCert.Text = "Auth cert";
            // 
            // lblEncryptionCert
            // 
            this.lblEncryptionCert.AutoSize = true;
            this.lblEncryptionCert.Location = new System.Drawing.Point(4, 20);
            this.lblEncryptionCert.Name = "lblEncryptionCert";
            this.lblEncryptionCert.Size = new System.Drawing.Size(130, 25);
            this.lblEncryptionCert.TabIndex = 14;
            this.lblEncryptionCert.Text = "Encryption cert";
            // 
            // rbAdalS2s
            // 
            this.rbAdalS2s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAdalS2s.AutoSize = true;
            this.rbAdalS2s.Location = new System.Drawing.Point(923, 12);
            this.rbAdalS2s.Name = "rbAdalS2s";
            this.rbAdalS2s.Size = new System.Drawing.Size(117, 29);
            this.rbAdalS2s.TabIndex = 16;
            this.rbAdalS2s.Text = "ADAL S2S";
            this.rbAdalS2s.UseVisualStyleBackColor = true;
            // 
            // rbMsalS2s
            // 
            this.rbMsalS2s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMsalS2s.AutoSize = true;
            this.rbMsalS2s.Checked = true;
            this.rbMsalS2s.Location = new System.Drawing.Point(1046, 12);
            this.rbMsalS2s.Name = "rbMsalS2s";
            this.rbMsalS2s.Size = new System.Drawing.Size(118, 29);
            this.rbMsalS2s.TabIndex = 17;
            this.rbMsalS2s.TabStop = true;
            this.rbMsalS2s.Text = "MSAL S2S";
            this.rbMsalS2s.UseVisualStyleBackColor = true;
            this.rbMsalS2s.CheckedChanged += new System.EventHandler(this.rbMsalS2s_CheckedChanged);
            // 
            // rbMsalObo
            // 
            this.rbMsalObo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMsalObo.AutoSize = true;
            this.rbMsalObo.Location = new System.Drawing.Point(1170, 12);
            this.rbMsalObo.Name = "rbMsalObo";
            this.rbMsalObo.Size = new System.Drawing.Size(126, 29);
            this.rbMsalObo.TabIndex = 18;
            this.rbMsalObo.Text = "MSAL OBO";
            this.rbMsalObo.UseVisualStyleBackColor = true;
            // 
            // tbUserAssertJwt
            // 
            this.tbUserAssertJwt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserAssertJwt.Location = new System.Drawing.Point(898, 50);
            this.tbUserAssertJwt.Name = "tbUserAssertJwt";
            this.tbUserAssertJwt.Size = new System.Drawing.Size(489, 31);
            this.tbUserAssertJwt.TabIndex = 20;
            // 
            // cbEncrypted
            // 
            this.cbEncrypted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEncrypted.AutoSize = true;
            this.cbEncrypted.Checked = true;
            this.cbEncrypted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEncrypted.Location = new System.Drawing.Point(1122, 90);
            this.cbEncrypted.Name = "cbEncrypted";
            this.cbEncrypted.Size = new System.Drawing.Size(125, 29);
            this.cbEncrypted.TabIndex = 21;
            this.cbEncrypted.Text = "Encrypted?";
            this.cbEncrypted.UseVisualStyleBackColor = true;
            // 
            // lblUserAssertionJwt
            // 
            this.lblUserAssertionJwt.AutoSize = true;
            this.lblUserAssertionJwt.Location = new System.Drawing.Point(732, 53);
            this.lblUserAssertionJwt.Name = "lblUserAssertionJwt";
            this.lblUserAssertionJwt.Size = new System.Drawing.Size(160, 25);
            this.lblUserAssertionJwt.TabIndex = 22;
            this.lblUserAssertionJwt.Text = "User assertion JWT";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbSubjectNameIssuer);
            this.splitContainer1.Panel1.Controls.Add(this.pnlAuthCertStore);
            this.splitContainer1.Panel1.Controls.Add(this.lblAuthority);
            this.splitContainer1.Panel1.Controls.Add(this.cbAuthority);
            this.splitContainer1.Panel1.Controls.Add(this.cbAuthCert);
            this.splitContainer1.Panel1.Controls.Add(this.lblUserAssertionJwt);
            this.splitContainer1.Panel1.Controls.Add(this.cbResourceScope);
            this.splitContainer1.Panel1.Controls.Add(this.cbEncrypted);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetToken);
            this.splitContainer1.Panel1.Controls.Add(this.tbGetTokenOutput);
            this.splitContainer1.Panel1.Controls.Add(this.tbUserAssertJwt);
            this.splitContainer1.Panel1.Controls.Add(this.cbClientId);
            this.splitContainer1.Panel1.Controls.Add(this.rbMsalObo);
            this.splitContainer1.Panel1.Controls.Add(this.lblResourceScopes);
            this.splitContainer1.Panel1.Controls.Add(this.rbMsalS2s);
            this.splitContainer1.Panel1.Controls.Add(this.lblClientId);
            this.splitContainer1.Panel1.Controls.Add(this.rbAdalS2s);
            this.splitContainer1.Panel1.Controls.Add(this.lblAuthCert);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlEncryptionCertStore);
            this.splitContainer1.Panel2.Controls.Add(this.tbDecryptTokenOutput);
            this.splitContainer1.Panel2.Controls.Add(this.lblEncryptionCert);
            this.splitContainer1.Panel2.Controls.Add(this.btnDecrypt);
            this.splitContainer1.Panel2.Controls.Add(this.cbEncryptionCert);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Size = new System.Drawing.Size(1399, 1456);
            this.splitContainer1.SplitterDistance = 748;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 23;
            // 
            // pnlAuthCertStore
            // 
            this.pnlAuthCertStore.Controls.Add(this.rbAuthCertCurrentUser);
            this.pnlAuthCertStore.Controls.Add(this.rbAuthCertLocalMachine);
            this.pnlAuthCertStore.Location = new System.Drawing.Point(718, 85);
            this.pnlAuthCertStore.Name = "pnlAuthCertStore";
            this.pnlAuthCertStore.Size = new System.Drawing.Size(299, 40);
            this.pnlAuthCertStore.TabIndex = 27;
            // 
            // rbAuthCertCurrentUser
            // 
            this.rbAuthCertCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAuthCertCurrentUser.AutoSize = true;
            this.rbAuthCertCurrentUser.Location = new System.Drawing.Point(16, 5);
            this.rbAuthCertCurrentUser.Name = "rbAuthCertCurrentUser";
            this.rbAuthCertCurrentUser.Size = new System.Drawing.Size(130, 29);
            this.rbAuthCertCurrentUser.TabIndex = 25;
            this.rbAuthCertCurrentUser.Text = "CurrentUser";
            this.rbAuthCertCurrentUser.UseVisualStyleBackColor = true;
            // 
            // rbAuthCertLocalMachine
            // 
            this.rbAuthCertLocalMachine.AutoSize = true;
            this.rbAuthCertLocalMachine.Checked = true;
            this.rbAuthCertLocalMachine.Location = new System.Drawing.Point(148, 5);
            this.rbAuthCertLocalMachine.Name = "rbAuthCertLocalMachine";
            this.rbAuthCertLocalMachine.Size = new System.Drawing.Size(143, 29);
            this.rbAuthCertLocalMachine.TabIndex = 26;
            this.rbAuthCertLocalMachine.TabStop = true;
            this.rbAuthCertLocalMachine.Text = "LocalMachine";
            this.rbAuthCertLocalMachine.UseVisualStyleBackColor = true;
            // 
            // lblAuthority
            // 
            this.lblAuthority.AutoSize = true;
            this.lblAuthority.Location = new System.Drawing.Point(15, 131);
            this.lblAuthority.Name = "lblAuthority";
            this.lblAuthority.Size = new System.Drawing.Size(86, 25);
            this.lblAuthority.TabIndex = 24;
            this.lblAuthority.Text = "Authority";
            // 
            // cbAuthority
            // 
            this.cbAuthority.FormattingEnabled = true;
            this.cbAuthority.Location = new System.Drawing.Point(160, 128);
            this.cbAuthority.Name = "cbAuthority";
            this.cbAuthority.Size = new System.Drawing.Size(548, 33);
            this.cbAuthority.TabIndex = 23;
            // 
            // pnlEncryptionCertStore
            // 
            this.pnlEncryptionCertStore.Controls.Add(this.rbEncryptionCertCurrentUser);
            this.pnlEncryptionCertStore.Controls.Add(this.rbEncryptionCertLocalMachine);
            this.pnlEncryptionCertStore.Location = new System.Drawing.Point(741, 13);
            this.pnlEncryptionCertStore.Name = "pnlEncryptionCertStore";
            this.pnlEncryptionCertStore.Size = new System.Drawing.Size(299, 40);
            this.pnlEncryptionCertStore.TabIndex = 28;
            // 
            // rbEncryptionCertCurrentUser
            // 
            this.rbEncryptionCertCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEncryptionCertCurrentUser.AutoSize = true;
            this.rbEncryptionCertCurrentUser.Location = new System.Drawing.Point(16, 5);
            this.rbEncryptionCertCurrentUser.Name = "rbEncryptionCertCurrentUser";
            this.rbEncryptionCertCurrentUser.Size = new System.Drawing.Size(130, 29);
            this.rbEncryptionCertCurrentUser.TabIndex = 25;
            this.rbEncryptionCertCurrentUser.Text = "CurrentUser";
            this.rbEncryptionCertCurrentUser.UseVisualStyleBackColor = true;
            // 
            // rbEncryptionCertLocalMachine
            // 
            this.rbEncryptionCertLocalMachine.AutoSize = true;
            this.rbEncryptionCertLocalMachine.Checked = true;
            this.rbEncryptionCertLocalMachine.Location = new System.Drawing.Point(148, 5);
            this.rbEncryptionCertLocalMachine.Name = "rbEncryptionCertLocalMachine";
            this.rbEncryptionCertLocalMachine.Size = new System.Drawing.Size(143, 29);
            this.rbEncryptionCertLocalMachine.TabIndex = 26;
            this.rbEncryptionCertLocalMachine.TabStop = true;
            this.rbEncryptionCertLocalMachine.Text = "LocalMachine";
            this.rbEncryptionCertLocalMachine.UseVisualStyleBackColor = true;
            // 
            // cbSubjectNameIssuer
            // 
            this.cbSubjectNameIssuer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubjectNameIssuer.AutoSize = true;
            this.cbSubjectNameIssuer.Checked = true;
            this.cbSubjectNameIssuer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSubjectNameIssuer.Location = new System.Drawing.Point(1038, 125);
            this.cbSubjectNameIssuer.Name = "cbSubjectNameIssuer";
            this.cbSubjectNameIssuer.Size = new System.Drawing.Size(209, 29);
            this.cbSubjectNameIssuer.TabIndex = 28;
            this.cbSubjectNameIssuer.Text = "Subject Name/Issuer?";
            this.cbSubjectNameIssuer.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 1456);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 600);
            this.Name = "MainForm";
            this.Text = "TokenTool";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlAuthCertStore.ResumeLayout(false);
            this.pnlAuthCertStore.PerformLayout();
            this.pnlEncryptionCertStore.ResumeLayout(false);
            this.pnlEncryptionCertStore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbResourceScope;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.ComboBox cbClientId;
        private System.Windows.Forms.ComboBox cbAuthCert;
        private System.Windows.Forms.TextBox tbGetTokenOutput;
        private System.Windows.Forms.TextBox tbDecryptTokenOutput;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.ComboBox cbEncryptionCert;
        private System.Windows.Forms.Label lblResourceScopes;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblAuthCert;
        private System.Windows.Forms.Label lblEncryptionCert;
        private System.Windows.Forms.RadioButton rbAdalS2s;
        private System.Windows.Forms.RadioButton rbMsalS2s;
        private System.Windows.Forms.RadioButton rbMsalObo;
        private System.Windows.Forms.TextBox tbUserAssertJwt;
        private System.Windows.Forms.CheckBox cbEncrypted;
        private System.Windows.Forms.Label lblUserAssertionJwt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblAuthority;
        private System.Windows.Forms.ComboBox cbAuthority;
        private System.Windows.Forms.RadioButton rbAuthCertLocalMachine;
        private System.Windows.Forms.RadioButton rbAuthCertCurrentUser;
        private System.Windows.Forms.Panel pnlAuthCertStore;
        private System.Windows.Forms.Panel pnlEncryptionCertStore;
        private System.Windows.Forms.RadioButton rbEncryptionCertCurrentUser;
        private System.Windows.Forms.RadioButton rbEncryptionCertLocalMachine;
        private System.Windows.Forms.CheckBox cbSubjectNameIssuer;
    }
}

