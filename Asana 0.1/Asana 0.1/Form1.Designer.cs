namespace Asana_0._1
{
    partial class Puttask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puttask));
            this.button1 = new System.Windows.Forms.Button();
            this.NAMELBL = new System.Windows.Forms.Label();
            this.NAMETB = new System.Windows.Forms.TextBox();
            this.NUMBERLBL = new System.Windows.Forms.Label();
            this.NUMBERTB = new System.Windows.Forms.TextBox();
            this.MAILLBL = new System.Windows.Forms.Label();
            this.MAILTB = new System.Windows.Forms.TextBox();
            this.TASKLBL = new System.Windows.Forms.Label();
            this.TASKTB = new System.Windows.Forms.TextBox();
            this.COCHRB = new System.Windows.Forms.RadioButton();
            this.CORB = new System.Windows.Forms.RadioButton();
            this.PHRB = new System.Windows.Forms.RadioButton();
            this.PADRB = new System.Windows.Forms.RadioButton();
            this.DIVRB = new System.Windows.Forms.RadioButton();
            this.DIVTB = new System.Windows.Forms.TextBox();
            this.PASSLBL = new System.Windows.Forms.Label();
            this.PASSTB = new System.Windows.Forms.TextBox();
            this.APIK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Publicera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NAMELBL
            // 
            this.NAMELBL.AutoSize = true;
            this.NAMELBL.Location = new System.Drawing.Point(13, 13);
            this.NAMELBL.Name = "NAMELBL";
            this.NAMELBL.Size = new System.Drawing.Size(35, 13);
            this.NAMELBL.TabIndex = 1;
            this.NAMELBL.Text = "Namn";
            // 
            // NAMETB
            // 
            this.NAMETB.Location = new System.Drawing.Point(16, 30);
            this.NAMETB.Name = "NAMETB";
            this.NAMETB.Size = new System.Drawing.Size(242, 20);
            this.NAMETB.TabIndex = 2;
            // 
            // NUMBERLBL
            // 
            this.NUMBERLBL.AutoSize = true;
            this.NUMBERLBL.Location = new System.Drawing.Point(13, 57);
            this.NUMBERLBL.Name = "NUMBERLBL";
            this.NUMBERLBL.Size = new System.Drawing.Size(55, 13);
            this.NUMBERLBL.TabIndex = 3;
            this.NUMBERLBL.Text = "Telefon nr";
            // 
            // NUMBERTB
            // 
            this.NUMBERTB.Location = new System.Drawing.Point(16, 73);
            this.NUMBERTB.Name = "NUMBERTB";
            this.NUMBERTB.Size = new System.Drawing.Size(242, 20);
            this.NUMBERTB.TabIndex = 4;
            // 
            // MAILLBL
            // 
            this.MAILLBL.AutoSize = true;
            this.MAILLBL.Location = new System.Drawing.Point(13, 105);
            this.MAILLBL.Name = "MAILLBL";
            this.MAILLBL.Size = new System.Drawing.Size(38, 13);
            this.MAILLBL.TabIndex = 5;
            this.MAILLBL.Text = "E-Post";
            // 
            // MAILTB
            // 
            this.MAILTB.Location = new System.Drawing.Point(16, 121);
            this.MAILTB.Name = "MAILTB";
            this.MAILTB.Size = new System.Drawing.Size(242, 20);
            this.MAILTB.TabIndex = 6;
            // 
            // TASKLBL
            // 
            this.TASKLBL.AutoSize = true;
            this.TASKLBL.Location = new System.Drawing.Point(13, 242);
            this.TASKLBL.Name = "TASKLBL";
            this.TASKLBL.Size = new System.Drawing.Size(49, 13);
            this.TASKLBL.TabIndex = 7;
            this.TASKLBL.Text = "Gällande";
            // 
            // TASKTB
            // 
            this.TASKTB.Location = new System.Drawing.Point(16, 258);
            this.TASKTB.Multiline = true;
            this.TASKTB.Name = "TASKTB";
            this.TASKTB.Size = new System.Drawing.Size(242, 64);
            this.TASKTB.TabIndex = 8;
            // 
            // COCHRB
            // 
            this.COCHRB.AutoSize = true;
            this.COCHRB.Location = new System.Drawing.Point(16, 351);
            this.COCHRB.Name = "COCHRB";
            this.COCHRB.Size = new System.Drawing.Size(102, 17);
            this.COCHRB.TabIndex = 9;
            this.COCHRB.TabStop = true;
            this.COCHRB.Text = "Dator + Laddare";
            this.COCHRB.UseVisualStyleBackColor = true;
            this.COCHRB.CheckedChanged += new System.EventHandler(this.COCHRB_CheckedChanged);
            // 
            // CORB
            // 
            this.CORB.AutoSize = true;
            this.CORB.Location = new System.Drawing.Point(16, 328);
            this.CORB.Name = "CORB";
            this.CORB.Size = new System.Drawing.Size(87, 17);
            this.CORB.TabIndex = 10;
            this.CORB.TabStop = true;
            this.CORB.Text = "Endast Dator";
            this.CORB.UseVisualStyleBackColor = true;
            this.CORB.CheckedChanged += new System.EventHandler(this.CORB_CheckedChanged);
            // 
            // PHRB
            // 
            this.PHRB.AutoSize = true;
            this.PHRB.Location = new System.Drawing.Point(16, 374);
            this.PHRB.Name = "PHRB";
            this.PHRB.Size = new System.Drawing.Size(61, 17);
            this.PHRB.TabIndex = 11;
            this.PHRB.TabStop = true;
            this.PHRB.Text = "Telefon";
            this.PHRB.UseVisualStyleBackColor = true;
            this.PHRB.CheckedChanged += new System.EventHandler(this.PHRB_CheckedChanged);
            // 
            // PADRB
            // 
            this.PADRB.AutoSize = true;
            this.PADRB.Location = new System.Drawing.Point(16, 397);
            this.PADRB.Name = "PADRB";
            this.PADRB.Size = new System.Drawing.Size(96, 17);
            this.PADRB.TabIndex = 12;
            this.PADRB.TabStop = true;
            this.PADRB.Text = "Ipad/Surfplatta";
            this.PADRB.UseVisualStyleBackColor = true;
            this.PADRB.CheckedChanged += new System.EventHandler(this.PADRB_CheckedChanged);
            // 
            // DIVRB
            // 
            this.DIVRB.AutoSize = true;
            this.DIVRB.Location = new System.Drawing.Point(16, 420);
            this.DIVRB.Name = "DIVRB";
            this.DIVRB.Size = new System.Drawing.Size(64, 17);
            this.DIVRB.TabIndex = 13;
            this.DIVRB.TabStop = true;
            this.DIVRB.Text = "Diverse:";
            this.DIVRB.UseVisualStyleBackColor = true;
            this.DIVRB.CheckedChanged += new System.EventHandler(this.DIVRB_CheckedChanged);
            // 
            // DIVTB
            // 
            this.DIVTB.Location = new System.Drawing.Point(16, 443);
            this.DIVTB.Multiline = true;
            this.DIVTB.Name = "DIVTB";
            this.DIVTB.Size = new System.Drawing.Size(242, 65);
            this.DIVTB.TabIndex = 14;
            // 
            // PASSLBL
            // 
            this.PASSLBL.AutoSize = true;
            this.PASSLBL.Location = new System.Drawing.Point(13, 158);
            this.PASSLBL.Name = "PASSLBL";
            this.PASSLBL.Size = new System.Drawing.Size(51, 13);
            this.PASSLBL.TabIndex = 17;
            this.PASSLBL.Text = "Lösenord";
            // 
            // PASSTB
            // 
            this.PASSTB.Location = new System.Drawing.Point(16, 174);
            this.PASSTB.Name = "PASSTB";
            this.PASSTB.Size = new System.Drawing.Size(242, 20);
            this.PASSTB.TabIndex = 18;
            // 
            // APIK
            // 
            this.APIK.Location = new System.Drawing.Point(13, 609);
            this.APIK.Name = "APIK";
            this.APIK.Size = new System.Drawing.Size(245, 20);
            this.APIK.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "API KEY";
            // 
            // Puttask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.APIK);
            this.Controls.Add(this.PASSTB);
            this.Controls.Add(this.PASSLBL);
            this.Controls.Add(this.DIVTB);
            this.Controls.Add(this.DIVRB);
            this.Controls.Add(this.PADRB);
            this.Controls.Add(this.PHRB);
            this.Controls.Add(this.CORB);
            this.Controls.Add(this.COCHRB);
            this.Controls.Add(this.TASKTB);
            this.Controls.Add(this.TASKLBL);
            this.Controls.Add(this.MAILTB);
            this.Controls.Add(this.MAILLBL);
            this.Controls.Add(this.NUMBERTB);
            this.Controls.Add(this.NUMBERLBL);
            this.Controls.Add(this.NAMETB);
            this.Controls.Add(this.NAMELBL);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Puttask";
            this.Text = "PUTTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NAMELBL;
        private System.Windows.Forms.TextBox NAMETB;
        private System.Windows.Forms.Label NUMBERLBL;
        private System.Windows.Forms.TextBox NUMBERTB;
        private System.Windows.Forms.Label MAILLBL;
        private System.Windows.Forms.TextBox MAILTB;
        private System.Windows.Forms.Label TASKLBL;
        private System.Windows.Forms.TextBox TASKTB;
        private System.Windows.Forms.RadioButton COCHRB;
        private System.Windows.Forms.RadioButton CORB;
        private System.Windows.Forms.RadioButton PHRB;
        private System.Windows.Forms.RadioButton PADRB;
        private System.Windows.Forms.RadioButton DIVRB;
        private System.Windows.Forms.TextBox DIVTB;
        private System.Windows.Forms.Label PASSLBL;
        private System.Windows.Forms.TextBox PASSTB;
        private System.Windows.Forms.TextBox APIK;
        private System.Windows.Forms.Label label1;
    }
}

