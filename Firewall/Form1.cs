using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetFwTypeLib;

namespace Firewall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            protocolListbox.SelectedIndex = 2;

            //first path

            //INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            //firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            //firewallRule.Description = "Used to block all internet access.";
            //firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            //firewallRule.Enabled = true;
            //firewallRule.InterfaceTypes = "All";
            //firewallRule.Name = "Block Internet";

            //INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(
            //    Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            //firewallPolicy.Rules.Add(firewallRule);


        }

        //SECOND PATH

        //disable IP
        private void DisableIpAddress(string port, string displayName, string ipAddress, string protocol, string inborout)
        {
            //var psCommand = $"New-NetFirewallRule -DisplayName \"<rule description>\" -Direction Inbound -LocalPort {port} -Protocol TCP -Action Allow";
            var powershell = PowerShell.Create();

            var blockCommand = $"New-NetFirewallRule -DisplayName {displayName} -Direction {inborout} -LocalPort {port} -Protocol {protocol} -Action Block -RemoteAddress {ipAddress}";

            powershell.Commands.AddScript(blockCommand);

            powershell.Invoke();

            var ifAnyError = powershell.Streams.Error;

            errorLabel.Visible = true;
            try
            {
                errorLabel.Text = ifAnyError[0].ToString();
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
                errorLabel.BackColor = Color.Green;
                errorLabel.Text = "Operation was successful";
            }
            
        }

        //enable IP
        private void AllowIpAddress(string port,string displayName, string ipAddress, string protocol,string inborout)
        {
            var powershell = PowerShell.Create();

            var allowCommand = $"New-NetFirewallRule -DisplayName {displayName} -Direction {inborout} -LocalPort {port} -Protocol {protocol} -Action Allow -RemoteAddress {ipAddress}";

            powershell.Commands.AddScript(allowCommand);
            var result = powershell.Invoke();
            var ifAnyError = powershell.Streams.Error;

            errorLabel.Visible = true;
            try
            {
                errorLabel.Text = ifAnyError[0].ToString();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                errorLabel.BackColor = Color.Green;
                errorLabel.Text = "Operation was successful";
            }
        }

        private void allowButton_Click(object sender, EventArgs e)
        {
            if (anyChecked.Checked)
            {
                port.Text = "Any";
            }
            AllowIpAddress(port.Text, displayName.Text, ipAddress.Text, protocolListbox.SelectedItem.ToString(),boundListbox.SelectedItem.ToString());
        }

        private void anyChecked_CheckedChanged(object sender, EventArgs e)
        {
            port.Text = "Any";
        }

        private void port_TextChanged(object sender, EventArgs e)
        {
            anyChecked.Checked = false;
        }

        private void blockButton_Click(object sender, EventArgs e)
        {
            if (anyChecked.Checked)
            {
                port.Text = "Any";
            }
            DisableIpAddress(port.Text, displayName.Text, ipAddress.Text, protocolListbox.SelectedItem.ToString(),boundListbox.SelectedItem.ToString());
        }
    }
}
