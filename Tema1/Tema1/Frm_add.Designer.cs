namespace Tema1
{
    partial class Frm_add
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
            this.rtf_nume = new System.Windows.Forms.RichTextBox();
            this.rtf_nr = new System.Windows.Forms.RichTextBox();
            this.rtf_em = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_gata = new System.Windows.Forms.Button();
            this.but_renunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtf_nume
            // 
            this.rtf_nume.Location = new System.Drawing.Point(170, 54);
            this.rtf_nume.Name = "rtf_nume";
            this.rtf_nume.Size = new System.Drawing.Size(257, 25);
            this.rtf_nume.TabIndex = 0;
            this.rtf_nume.Text = "";
            this.rtf_nume.TextChanged += new System.EventHandler(this.rtf_nume_TextChanged);
            // 
            // rtf_nr
            // 
            this.rtf_nr.Location = new System.Drawing.Point(170, 115);
            this.rtf_nr.Name = "rtf_nr";
            this.rtf_nr.Size = new System.Drawing.Size(257, 25);
            this.rtf_nr.TabIndex = 3;
            this.rtf_nr.Text = "";
            // 
            // rtf_em
            // 
            this.rtf_em.Location = new System.Drawing.Point(170, 170);
            this.rtf_em.Name = "rtf_em";
            this.rtf_em.Size = new System.Drawing.Size(257, 25);
            this.rtf_em.TabIndex = 4;
            this.rtf_em.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numar de telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-mail";
            // 
            // but_gata
            // 
            this.but_gata.Location = new System.Drawing.Point(196, 222);
            this.but_gata.Name = "but_gata";
            this.but_gata.Size = new System.Drawing.Size(75, 23);
            this.but_gata.TabIndex = 8;
            this.but_gata.Text = "Gata";
            this.but_gata.UseVisualStyleBackColor = true;
            this.but_gata.Click += new System.EventHandler(this.but_gata_click);
            // 
            // but_renunta
            // 
            this.but_renunta.Location = new System.Drawing.Point(335, 223);
            this.but_renunta.Name = "but_renunta";
            this.but_renunta.Size = new System.Drawing.Size(75, 21);
            this.but_renunta.TabIndex = 9;
            this.but_renunta.Text = "Renunta";
            this.but_renunta.UseVisualStyleBackColor = true;
            this.but_renunta.Click += new System.EventHandler(this.but_renunta_Click);
            // 
            // Frm_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 259);
            this.Controls.Add(this.but_renunta);
            this.Controls.Add(this.but_gata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtf_em);
            this.Controls.Add(this.rtf_nr);
            this.Controls.Add(this.rtf_nume);
            this.Name = "Frm_add";
            this.Text = "Adaugare Contact";
            this.Load += new System.EventHandler(this.Frm_add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtf_nume;
        private System.Windows.Forms.RichTextBox rtf_nr;
        private System.Windows.Forms.RichTextBox rtf_em;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_gata;
        private System.Windows.Forms.Button but_renunta;
    }
}