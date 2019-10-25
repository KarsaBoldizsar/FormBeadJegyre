namespace RegisztracioAlkalmazas
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
            this.nevLabel = new System.Windows.Forms.Label();
            this.szuldatLabel = new System.Windows.Forms.Label();
            this.nemLabel = new System.Windows.Forms.Label();
            this.nevText = new System.Windows.Forms.TextBox();
            this.szuldatText = new System.Windows.Forms.TextBox();
            this.kedvencLabel = new System.Windows.Forms.Label();
            this.ujhobbiLabel = new System.Windows.Forms.Label();
            this.ujhobbiText = new System.Windows.Forms.TextBox();
            this.hozzaadButton = new System.Windows.Forms.Button();
            this.mentesButton = new System.Windows.Forms.Button();
            this.betoltesButton = new System.Windows.Forms.Button();
            this.fButton = new System.Windows.Forms.RadioButton();
            this.nButton = new System.Windows.Forms.RadioButton();
            this.kedvenclistbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nevLabel
            // 
            this.nevLabel.AutoSize = true;
            this.nevLabel.Location = new System.Drawing.Point(12, 9);
            this.nevLabel.Name = "nevLabel";
            this.nevLabel.Size = new System.Drawing.Size(30, 13);
            this.nevLabel.TabIndex = 0;
            this.nevLabel.Text = "Név:";
            this.nevLabel.Click += new System.EventHandler(this.nevLabel_Click);
            // 
            // szuldatLabel
            // 
            this.szuldatLabel.AutoSize = true;
            this.szuldatLabel.Location = new System.Drawing.Point(12, 43);
            this.szuldatLabel.Name = "szuldatLabel";
            this.szuldatLabel.Size = new System.Drawing.Size(67, 13);
            this.szuldatLabel.TabIndex = 1;
            this.szuldatLabel.Text = "Szül. Dátum:";
            // 
            // nemLabel
            // 
            this.nemLabel.AutoSize = true;
            this.nemLabel.Location = new System.Drawing.Point(12, 83);
            this.nemLabel.Name = "nemLabel";
            this.nemLabel.Size = new System.Drawing.Size(32, 13);
            this.nemLabel.TabIndex = 2;
            this.nemLabel.Text = "Nem:";
            // 
            // nevText
            // 
            this.nevText.Location = new System.Drawing.Point(102, 9);
            this.nevText.Name = "nevText";
            this.nevText.Size = new System.Drawing.Size(155, 20);
            this.nevText.TabIndex = 3;
            // 
            // szuldatText
            // 
            this.szuldatText.Location = new System.Drawing.Point(102, 43);
            this.szuldatText.Name = "szuldatText";
            this.szuldatText.Size = new System.Drawing.Size(155, 20);
            this.szuldatText.TabIndex = 4;
            // 
            // kedvencLabel
            // 
            this.kedvencLabel.AutoSize = true;
            this.kedvencLabel.Location = new System.Drawing.Point(301, 27);
            this.kedvencLabel.Name = "kedvencLabel";
            this.kedvencLabel.Size = new System.Drawing.Size(90, 13);
            this.kedvencLabel.TabIndex = 5;
            this.kedvencLabel.Text = "Kedvenc Hobbik:";
            this.kedvencLabel.Click += new System.EventHandler(this.kedvencLabel_Click);
            // 
            // ujhobbiLabel
            // 
            this.ujhobbiLabel.AutoSize = true;
            this.ujhobbiLabel.Location = new System.Drawing.Point(342, 143);
            this.ujhobbiLabel.Name = "ujhobbiLabel";
            this.ujhobbiLabel.Size = new System.Drawing.Size(49, 13);
            this.ujhobbiLabel.TabIndex = 7;
            this.ujhobbiLabel.Text = "Új hobbi:";
            // 
            // ujhobbiText
            // 
            this.ujhobbiText.Location = new System.Drawing.Point(397, 140);
            this.ujhobbiText.Name = "ujhobbiText";
            this.ujhobbiText.Size = new System.Drawing.Size(100, 20);
            this.ujhobbiText.TabIndex = 8;
            // 
            // hozzaadButton
            // 
            this.hozzaadButton.Location = new System.Drawing.Point(397, 166);
            this.hozzaadButton.Name = "hozzaadButton";
            this.hozzaadButton.Size = new System.Drawing.Size(75, 23);
            this.hozzaadButton.TabIndex = 9;
            this.hozzaadButton.Text = "Hozzáad";
            this.hozzaadButton.UseVisualStyleBackColor = true;
            this.hozzaadButton.Click += new System.EventHandler(this.hozzaadButton_Click);
            // 
            // mentesButton
            // 
            this.mentesButton.Location = new System.Drawing.Point(304, 238);
            this.mentesButton.Name = "mentesButton";
            this.mentesButton.Size = new System.Drawing.Size(75, 23);
            this.mentesButton.TabIndex = 10;
            this.mentesButton.Text = "Mentés";
            this.mentesButton.UseVisualStyleBackColor = true;
            this.mentesButton.Click += new System.EventHandler(this.mentesButton_Click);
            // 
            // betoltesButton
            // 
            this.betoltesButton.Location = new System.Drawing.Point(397, 238);
            this.betoltesButton.Name = "betoltesButton";
            this.betoltesButton.Size = new System.Drawing.Size(75, 23);
            this.betoltesButton.TabIndex = 11;
            this.betoltesButton.Text = "Betöltés";
            this.betoltesButton.UseVisualStyleBackColor = true;
            this.betoltesButton.Click += new System.EventHandler(this.betoltesButton_Click);
            // 
            // fButton
            // 
            this.fButton.AutoSize = true;
            this.fButton.Location = new System.Drawing.Point(102, 83);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(31, 17);
            this.fButton.TabIndex = 12;
            this.fButton.TabStop = true;
            this.fButton.Text = "F";
            this.fButton.UseVisualStyleBackColor = true;
            // 
            // nButton
            // 
            this.nButton.AutoSize = true;
            this.nButton.Location = new System.Drawing.Point(139, 83);
            this.nButton.Name = "nButton";
            this.nButton.Size = new System.Drawing.Size(33, 17);
            this.nButton.TabIndex = 13;
            this.nButton.TabStop = true;
            this.nButton.Text = "N";
            this.nButton.UseVisualStyleBackColor = true;
            this.nButton.CheckedChanged += new System.EventHandler(this.nButton_click);
            // 
            // kedvenclistbox
            // 
            this.kedvenclistbox.FormattingEnabled = true;
            this.kedvenclistbox.Location = new System.Drawing.Point(397, 27);
            this.kedvenclistbox.Name = "kedvenclistbox";
            this.kedvenclistbox.Size = new System.Drawing.Size(356, 95);
            this.kedvenclistbox.TabIndex = 14;
            this.kedvenclistbox.SelectedIndexChanged += new System.EventHandler(this.kedvenclistbox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kedvenclistbox);
            this.Controls.Add(this.nButton);
            this.Controls.Add(this.fButton);
            this.Controls.Add(this.betoltesButton);
            this.Controls.Add(this.mentesButton);
            this.Controls.Add(this.hozzaadButton);
            this.Controls.Add(this.ujhobbiText);
            this.Controls.Add(this.ujhobbiLabel);
            this.Controls.Add(this.kedvencLabel);
            this.Controls.Add(this.szuldatText);
            this.Controls.Add(this.nevText);
            this.Controls.Add(this.nemLabel);
            this.Controls.Add(this.szuldatLabel);
            this.Controls.Add(this.nevLabel);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nevLabel;
        private System.Windows.Forms.Label szuldatLabel;
        private System.Windows.Forms.Label nemLabel;
        private System.Windows.Forms.TextBox nevText;
        private System.Windows.Forms.TextBox szuldatText;
        private System.Windows.Forms.Label kedvencLabel;
        private System.Windows.Forms.Label ujhobbiLabel;
        private System.Windows.Forms.TextBox ujhobbiText;
        private System.Windows.Forms.Button hozzaadButton;
        private System.Windows.Forms.Button mentesButton;
        private System.Windows.Forms.Button betoltesButton;
        private System.Windows.Forms.RadioButton fButton;
        private System.Windows.Forms.RadioButton nButton;
        private System.Windows.Forms.ListBox kedvenclistbox;
    }
}

