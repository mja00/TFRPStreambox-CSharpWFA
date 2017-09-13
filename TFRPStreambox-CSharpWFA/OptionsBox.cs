using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCustomMessageBox;
using System.Windows.Forms;
using System.Windows;

namespace TFRPStreambox
{
    public partial class OptionsBox : Form
    {

        public OptionsBox()
        {
            InitializeComponent();
            maskedTextBox1.Text = Properties.Settings.Default.VLCLocation;
            maskedTextBox2.Text = Properties.Settings.Default.OAuth;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VLCLocation = @maskedTextBox1.Text;
        }

        private async void cancelButton_Click(object sender, EventArgs e)
        {
            await Task.Delay(200);
            this.Close();
        }

        private async void applyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OAuth = maskedTextBox2.Text;
            Properties.Settings.Default.Save();
            await Task.Delay(500);
            this.Close();
        }

        private async void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = CustomMessageBox.ShowYesNo(
                "Are you sure you want to reset to default settings?",
                "Are you sure?",
                "Yes",
                "No");
            if (result == MessageBoxResult.Yes)
            {
                Properties.Settings.Default.VLCLocation = @"C:\Program Files\VideoLAN\VLC\vlc.exe";
                Properties.Settings.Default.Save();
                await Task.Delay(200);
                this.Close();
            }
        }

        private void vlcplayerlocationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
