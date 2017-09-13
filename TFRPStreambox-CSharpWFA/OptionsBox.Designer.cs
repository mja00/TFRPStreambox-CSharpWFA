namespace TFRPStreambox
{
    partial class OptionsBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsBox));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.vlcplayerlocationLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.applyButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cancelButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.oauthLable = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(121, 12);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // vlcplayerlocationLabel
            // 
            this.vlcplayerlocationLabel.AutoSize = true;
            this.vlcplayerlocationLabel.Location = new System.Drawing.Point(12, 16);
            this.vlcplayerlocationLabel.Name = "vlcplayerlocationLabel";
            this.vlcplayerlocationLabel.Size = new System.Drawing.Size(106, 13);
            this.vlcplayerlocationLabel.TabIndex = 1;
            this.vlcplayerlocationLabel.Text = "VLC Player Location:";
            this.vlcplayerlocationLabel.Click += new System.EventHandler(this.vlcplayerlocationLabel_Click);
            // 
            // applyButton
            // 
            this.applyButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.applyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.applyButton.BorderRadius = 0;
            this.applyButton.ButtonText = "Apply";
            this.applyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyButton.DisabledColor = System.Drawing.Color.Gray;
            this.applyButton.Iconcolor = System.Drawing.Color.Transparent;
            this.applyButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("applyButton.Iconimage")));
            this.applyButton.Iconimage_right = null;
            this.applyButton.Iconimage_right_Selected = null;
            this.applyButton.Iconimage_Selected = null;
            this.applyButton.IconMarginLeft = 0;
            this.applyButton.IconMarginRight = 0;
            this.applyButton.IconRightVisible = true;
            this.applyButton.IconRightZoom = 0D;
            this.applyButton.IconVisible = true;
            this.applyButton.IconZoom = 90D;
            this.applyButton.IsTab = false;
            this.applyButton.Location = new System.Drawing.Point(12, 146);
            this.applyButton.Name = "applyButton";
            this.applyButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.applyButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.applyButton.OnHoverTextColor = System.Drawing.Color.White;
            this.applyButton.selected = false;
            this.applyButton.Size = new System.Drawing.Size(91, 23);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply";
            this.applyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.applyButton.Textcolor = System.Drawing.Color.White;
            this.applyButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Activecolor = System.Drawing.Color.IndianRed;
            this.cancelButton.BackColor = System.Drawing.Color.IndianRed;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.BorderRadius = 0;
            this.cancelButton.ButtonText = "Cancel";
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.DisabledColor = System.Drawing.Color.Gray;
            this.cancelButton.Iconcolor = System.Drawing.Color.Transparent;
            this.cancelButton.Iconimage = null;
            this.cancelButton.Iconimage_right = null;
            this.cancelButton.Iconimage_right_Selected = null;
            this.cancelButton.Iconimage_Selected = null;
            this.cancelButton.IconMarginLeft = 0;
            this.cancelButton.IconMarginRight = 0;
            this.cancelButton.IconRightVisible = true;
            this.cancelButton.IconRightZoom = 0D;
            this.cancelButton.IconVisible = true;
            this.cancelButton.IconZoom = 90D;
            this.cancelButton.IsTab = false;
            this.cancelButton.Location = new System.Drawing.Point(297, 146);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Normalcolor = System.Drawing.Color.IndianRed;
            this.cancelButton.OnHovercolor = System.Drawing.Color.Red;
            this.cancelButton.OnHoverTextColor = System.Drawing.Color.White;
            this.cancelButton.selected = false;
            this.cancelButton.Size = new System.Drawing.Size(91, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.Textcolor = System.Drawing.Color.White;
            this.cancelButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Reset";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(162, 146);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(82, 23);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "Reset";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // oauthLable
            // 
            this.oauthLable.AutoSize = true;
            this.oauthLable.Location = new System.Drawing.Point(12, 47);
            this.oauthLable.Name = "oauthLable";
            this.oauthLable.Size = new System.Drawing.Size(74, 13);
            this.oauthLable.TabIndex = 6;
            this.oauthLable.Text = "OAuth Token:";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(92, 44);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(213, 20);
            this.maskedTextBox2.TabIndex = 7;
            // 
            // OptionsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 172);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.oauthLable);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.vlcplayerlocationLabel);
            this.Controls.Add(this.maskedTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel vlcplayerlocationLabel;
        private Bunifu.Framework.UI.BunifuFlatButton applyButton;
        private Bunifu.Framework.UI.BunifuFlatButton cancelButton;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label oauthLable;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}