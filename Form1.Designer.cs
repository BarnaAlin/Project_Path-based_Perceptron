namespace ProiectB5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lista_Trace = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_ALL = new System.Windows.Forms.RadioButton();
            this.radioButton_saltConditionat = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_prag = new System.Windows.Forms.TextBox();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.buton_Simulare = new System.Windows.Forms.Button();
            this.buton_Sterge = new System.Windows.Forms.Button();
            this.buton_Grafic = new System.Windows.Forms.Button();
            this.radioButton_Psimplu = new System.Windows.Forms.RadioButton();
            this.textBox_Rezultate = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lista_Trace);
            this.panel1.Location = new System.Drawing.Point(33, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 394);
            this.panel1.TabIndex = 0;
            // 
            // lista_Trace
            // 
            this.lista_Trace.FormattingEnabled = true;
            this.lista_Trace.Items.AddRange(new object[] {
            "FBUBBLE.TRA",
            "FMATRIX.TRA",
            "FPERM.TRA",
            "FPUZZLE.TRA",
            "FQUEENS.TRA",
            "FSORT.TRA",
            "FTOWER.TRA",
            "FTREE.TRA"});
            this.lista_Trace.Location = new System.Drawing.Point(19, 19);
            this.lista_Trace.Name = "lista_Trace";
            this.lista_Trace.Size = new System.Drawing.Size(304, 310);
            this.lista_Trace.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.radioButton_ALL);
            this.panel2.Controls.Add(this.radioButton_saltConditionat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_prag);
            this.panel2.Controls.Add(this.textBox_h);
            this.panel2.Controls.Add(this.textBox_N);
            this.panel2.Location = new System.Drawing.Point(33, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 296);
            this.panel2.TabIndex = 1;
            // 
            // radioButton_ALL
            // 
            this.radioButton_ALL.AutoSize = true;
            this.radioButton_ALL.Checked = true;
            this.radioButton_ALL.Location = new System.Drawing.Point(27, 223);
            this.radioButton_ALL.Name = "radioButton_ALL";
            this.radioButton_ALL.Size = new System.Drawing.Size(115, 20);
            this.radioButton_ALL.TabIndex = 8;
            this.radioButton_ALL.TabStop = true;
            this.radioButton_ALL.Text = "Toate Salturile";
            this.radioButton_ALL.UseVisualStyleBackColor = true;
            // 
            // radioButton_saltConditionat
            // 
            this.radioButton_saltConditionat.AutoSize = true;
            this.radioButton_saltConditionat.Location = new System.Drawing.Point(197, 223);
            this.radioButton_saltConditionat.Name = "radioButton_saltConditionat";
            this.radioButton_saltConditionat.Size = new System.Drawing.Size(143, 20);
            this.radioButton_saltConditionat.TabIndex = 7;
            this.radioButton_saltConditionat.Text = "Salturi Conditionate";
            this.radioButton_saltConditionat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Istorie Globala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numer perceptroni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parametrii Necesari";
            // 
            // textBox_prag
            // 
            this.textBox_prag.Location = new System.Drawing.Point(196, 159);
            this.textBox_prag.Name = "textBox_prag";
            this.textBox_prag.Size = new System.Drawing.Size(128, 22);
            this.textBox_prag.TabIndex = 2;
            this.textBox_prag.Text = "50";
            // 
            // textBox_h
            // 
            this.textBox_h.Location = new System.Drawing.Point(196, 110);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(128, 22);
            this.textBox_h.TabIndex = 1;
            this.textBox_h.Text = "4";
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(196, 57);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(128, 22);
            this.textBox_N.TabIndex = 0;
            this.textBox_N.Text = "40";
            // 
            // buton_Simulare
            // 
            this.buton_Simulare.Location = new System.Drawing.Point(606, 645);
            this.buton_Simulare.Name = "buton_Simulare";
            this.buton_Simulare.Size = new System.Drawing.Size(194, 67);
            this.buton_Simulare.TabIndex = 3;
            this.buton_Simulare.Text = "Simulare";
            this.buton_Simulare.UseVisualStyleBackColor = true;
            this.buton_Simulare.Click += new System.EventHandler(this.buton_Simulare_Click);
            // 
            // buton_Sterge
            // 
            this.buton_Sterge.Location = new System.Drawing.Point(1024, 52);
            this.buton_Sterge.Name = "buton_Sterge";
            this.buton_Sterge.Size = new System.Drawing.Size(182, 57);
            this.buton_Sterge.TabIndex = 4;
            this.buton_Sterge.Text = "Sterge Rezultat";
            this.buton_Sterge.UseVisualStyleBackColor = true;
            this.buton_Sterge.Click += new System.EventHandler(this.buton_Sterge_Click);
            // 
            // buton_Grafic
            // 
            this.buton_Grafic.Location = new System.Drawing.Point(1024, 174);
            this.buton_Grafic.Name = "buton_Grafic";
            this.buton_Grafic.Size = new System.Drawing.Size(182, 57);
            this.buton_Grafic.TabIndex = 5;
            this.buton_Grafic.Text = "Afiseaza Grafic";
            this.buton_Grafic.UseVisualStyleBackColor = true;
            this.buton_Grafic.Click += new System.EventHandler(this.buton_Grafic_Click);
            // 
            // radioButton_Psimplu
            // 
            this.radioButton_Psimplu.AutoSize = true;
            this.radioButton_Psimplu.Checked = true;
            this.radioButton_Psimplu.Location = new System.Drawing.Point(1052, 277);
            this.radioButton_Psimplu.Name = "radioButton_Psimplu";
            this.radioButton_Psimplu.Size = new System.Drawing.Size(138, 20);
            this.radioButton_Psimplu.TabIndex = 9;
            this.radioButton_Psimplu.TabStop = true;
            this.radioButton_Psimplu.Text = "Perceptron Simplu";
            this.radioButton_Psimplu.UseVisualStyleBackColor = true;
            // 
            // textBox_Rezultate
            // 
            this.textBox_Rezultate.Location = new System.Drawing.Point(445, 24);
            this.textBox_Rezultate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Rezultate.Multiline = true;
            this.textBox_Rezultate.Name = "textBox_Rezultate";
            this.textBox_Rezultate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Rezultate.Size = new System.Drawing.Size(558, 581);
            this.textBox_Rezultate.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1254, 753);
            this.Controls.Add(this.textBox_Rezultate);
            this.Controls.Add(this.radioButton_Psimplu);
            this.Controls.Add(this.buton_Grafic);
            this.Controls.Add(this.buton_Sterge);
            this.Controls.Add(this.buton_Simulare);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buton_Simulare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_prag;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Button buton_Sterge;
        private System.Windows.Forms.Button buton_Grafic;
        private System.Windows.Forms.RadioButton radioButton_ALL;
        private System.Windows.Forms.RadioButton radioButton_saltConditionat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_Psimplu;
        private System.Windows.Forms.CheckedListBox lista_Trace;
        private System.Windows.Forms.TextBox textBox_Rezultate;
    }
}

