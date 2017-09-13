namespace TFRPStreambox
{
    partial class OAuthPrompt
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
            this.OAuthPromptLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.OAuthTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.saveButton = new System.Windows.Forms.Button();
            this.errorLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.helpButton = new System.Windows.Forms.Button();
            this.tokenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OAuthPromptLabel
            // 
            this.OAuthPromptLabel.AutoSize = true;
            this.OAuthPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OAuthPromptLabel.Location = new System.Drawing.Point(27, 9);
            this.OAuthPromptLabel.Name = "OAuthPromptLabel";
            this.OAuthPromptLabel.Size = new System.Drawing.Size(338, 34);
            this.OAuthPromptLabel.TabIndex = 0;
            this.OAuthPromptLabel.Text = "To make this program work you\'ll need to input your \r\nTwitch OAuth key to access " +
    "Twitch\'s API";
            // 
            // OAuthTextbox
            // 
            this.OAuthTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.OAuthTextbox.Location = new System.Drawing.Point(66, 66);
            this.OAuthTextbox.Name = "OAuthTextbox";
            this.OAuthTextbox.Size = new System.Drawing.Size(334, 20);
            this.OAuthTextbox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(135, 145);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 49);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.errorLabel.Enabled = false;
            this.errorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.errorLabel.Location = new System.Drawing.Point(132, 50);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(123, 13);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "Error: Box can\'t be blank";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(12, 66);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(25, 23);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // tokenButton
            // 
            this.tokenButton.Location = new System.Drawing.Point(297, 92);
            this.tokenButton.Name = "tokenButton";
            this.tokenButton.Size = new System.Drawing.Size(103, 29);
            this.tokenButton.TabIndex = 5;
            this.tokenButton.Text = "Get OAuth token";
            this.tokenButton.UseVisualStyleBackColor = true;
            this.tokenButton.Click += new System.EventHandler(this.tokenButton_Click);
            // 
            // OAuthPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 206);
            this.Controls.Add(this.tokenButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.OAuthTextbox);
            this.Controls.Add(this.OAuthPromptLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OAuthPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OAuthPrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel OAuthPromptLabel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox OAuthTextbox;
        private System.Windows.Forms.Button saveButton;
        private Bunifu.Framework.UI.BunifuCustomLabel errorLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button tokenButton;
    }
}