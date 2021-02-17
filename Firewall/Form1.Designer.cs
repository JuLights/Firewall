namespace Firewall
{
    partial class Form1
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
            this.displayName = new System.Windows.Forms.TextBox();
            this.displayNameLabel = new System.Windows.Forms.Label();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.allowButton = new System.Windows.Forms.Button();
            this.protocolLabel = new System.Windows.Forms.Label();
            this.protocolListbox = new System.Windows.Forms.ListBox();
            this.anyChecked = new System.Windows.Forms.CheckBox();
            this.orLabel = new System.Windows.Forms.Label();
            this.blockButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.boundListbox = new System.Windows.Forms.ListBox();
            this.labelSelectInborOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayName
            // 
            this.displayName.Location = new System.Drawing.Point(287, 120);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(209, 20);
            this.displayName.TabIndex = 0;
            // 
            // displayNameLabel
            // 
            this.displayNameLabel.AutoSize = true;
            this.displayNameLabel.Location = new System.Drawing.Point(209, 123);
            this.displayNameLabel.Name = "displayNameLabel";
            this.displayNameLabel.Size = new System.Drawing.Size(72, 13);
            this.displayNameLabel.TabIndex = 1;
            this.displayNameLabel.Text = "Display Name";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(287, 159);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(209, 20);
            this.ipAddress.TabIndex = 2;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(287, 192);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(70, 20);
            this.port.TabIndex = 3;
            this.port.TextChanged += new System.EventHandler(this.port_TextChanged);
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(211, 162);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(58, 13);
            this.ipAddressLabel.TabIndex = 4;
            this.ipAddressLabel.Text = "IP Address";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(241, 194);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 5;
            this.portLabel.Text = "Port";
            // 
            // allowButton
            // 
            this.allowButton.Location = new System.Drawing.Point(287, 292);
            this.allowButton.Name = "allowButton";
            this.allowButton.Size = new System.Drawing.Size(75, 23);
            this.allowButton.TabIndex = 6;
            this.allowButton.Text = "Allow";
            this.allowButton.UseVisualStyleBackColor = true;
            this.allowButton.Click += new System.EventHandler(this.allowButton_Click);
            // 
            // protocolLabel
            // 
            this.protocolLabel.AutoSize = true;
            this.protocolLabel.Location = new System.Drawing.Point(235, 224);
            this.protocolLabel.Name = "protocolLabel";
            this.protocolLabel.Size = new System.Drawing.Size(46, 13);
            this.protocolLabel.TabIndex = 8;
            this.protocolLabel.Text = "Protocol";
            // 
            // protocolListbox
            // 
            this.protocolListbox.FormattingEnabled = true;
            this.protocolListbox.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "Any"});
            this.protocolListbox.Location = new System.Drawing.Point(304, 224);
            this.protocolListbox.Name = "protocolListbox";
            this.protocolListbox.Size = new System.Drawing.Size(120, 43);
            this.protocolListbox.TabIndex = 9;
            // 
            // anyChecked
            // 
            this.anyChecked.AutoSize = true;
            this.anyChecked.Checked = true;
            this.anyChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.anyChecked.Location = new System.Drawing.Point(404, 194);
            this.anyChecked.Name = "anyChecked";
            this.anyChecked.Size = new System.Drawing.Size(44, 17);
            this.anyChecked.TabIndex = 10;
            this.anyChecked.Text = "Any";
            this.anyChecked.UseVisualStyleBackColor = true;
            this.anyChecked.CheckedChanged += new System.EventHandler(this.anyChecked_CheckedChanged);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(372, 195);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(16, 13);
            this.orLabel.TabIndex = 11;
            this.orLabel.Text = "or";
            // 
            // blockButton
            // 
            this.blockButton.Location = new System.Drawing.Point(386, 292);
            this.blockButton.Name = "blockButton";
            this.blockButton.Size = new System.Drawing.Size(75, 23);
            this.blockButton.TabIndex = 12;
            this.blockButton.Text = "Block";
            this.blockButton.UseVisualStyleBackColor = true;
            this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 348);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 13;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorLabel.Visible = false;
            // 
            // boundListbox
            // 
            this.boundListbox.FormattingEnabled = true;
            this.boundListbox.Items.AddRange(new object[] {
            "Inbound",
            "Outbound"});
            this.boundListbox.Location = new System.Drawing.Point(304, 84);
            this.boundListbox.Name = "boundListbox";
            this.boundListbox.Size = new System.Drawing.Size(65, 30);
            this.boundListbox.TabIndex = 14;
            // 
            // labelSelectInborOut
            // 
            this.labelSelectInborOut.AutoSize = true;
            this.labelSelectInborOut.Location = new System.Drawing.Point(211, 91);
            this.labelSelectInborOut.Name = "labelSelectInborOut";
            this.labelSelectInborOut.Size = new System.Drawing.Size(58, 13);
            this.labelSelectInborOut.TabIndex = 15;
            this.labelSelectInborOut.Text = "Select one";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSelectInborOut);
            this.Controls.Add(this.boundListbox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.blockButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.anyChecked);
            this.Controls.Add(this.protocolListbox);
            this.Controls.Add(this.protocolLabel);
            this.Controls.Add(this.allowButton);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipAddressLabel);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ipAddress);
            this.Controls.Add(this.displayNameLabel);
            this.Controls.Add(this.displayName);
            this.Name = "Form1";
            this.Text = "Firewall Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayName;
        private System.Windows.Forms.Label displayNameLabel;
        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button allowButton;
        private System.Windows.Forms.Label protocolLabel;
        private System.Windows.Forms.ListBox protocolListbox;
        private System.Windows.Forms.CheckBox anyChecked;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button blockButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ListBox boundListbox;
        private System.Windows.Forms.Label labelSelectInborOut;
    }
}

