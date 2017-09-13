using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using WPFCustomMessageBox;

namespace TFRPStreambox
{
    public partial class OAuthPrompt : Form
    {
        public OAuthPrompt()
        {
            InitializeComponent();
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            if (OAuthTextbox.Text != "")
            {
                Properties.Settings.Default.OAuth = OAuthTextbox.Text;
                Properties.Settings.Default.Save();
                await Task.Delay(200);
                this.Close();
            }
            else
            {
                errorLabel.Enabled = true;
                errorLabel.ForeColor = Color.IndianRed;
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = CustomMessageBox.ShowOK(
            "The OAuth token is stored locally in your /AppData/Local folder. This token is only passed through to Twitch's API to allow authentification on their end. As of now this is only used to check if a streamer is live. In the future it may be used for a follow button on the program.",
            "Help",
            "Ok");
        }

        private void tokenButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://twitchapps.com/tmi/");
        }
    }
}
