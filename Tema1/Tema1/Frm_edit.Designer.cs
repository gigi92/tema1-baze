namespace Tema1
{
    partial class Frm_edit
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.rtf_nume = new System.Windows.Forms.RichTextBox();
            this.rtf_numar = new System.Windows.Forms.RichTextBox();
            this.rtf_email = new System.Windows.Forms.RichTextBox();
            this.but_gata = new System.Windows.Forms.Button();
            this.Nume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(26, 32);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(623, 267);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // rtf_nume
            // 
            this.rtf_nume.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtf_nume.Location = new System.Drawing.Point(736, 54);
            this.rtf_nume.Name = "rtf_nume";
            this.rtf_nume.Size = new System.Drawing.Size(171, 25);
            this.rtf_nume.TabIndex = 1;
            this.rtf_nume.Text = "";
            // 
            // rtf_numar
            // 
            this.rtf_numar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtf_numar.Location = new System.Drawing.Point(736, 102);
            this.rtf_numar.Name = "rtf_numar";
            this.rtf_numar.Size = new System.Drawing.Size(171, 25);
            this.rtf_numar.TabIndex = 2;
            this.rtf_numar.Text = "";
            // 
            // rtf_email
            // 
            this.rtf_email.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtf_email.Location = new System.Drawing.Point(736, 153);
            this.rtf_email.Name = "rtf_email";
            this.rtf_email.Size = new System.Drawing.Size(171, 25);
            this.rtf_email.TabIndex = 3;
            this.rtf_email.Text = "";
            // 
            // but_gata
            // 
            this.but_gata.Location = new System.Drawing.Point(740, 237);
            this.but_gata.Name = "but_gata";
            this.but_gata.Size = new System.Drawing.Size(75, 23);
            this.but_gata.TabIndex = 4;
            this.but_gata.Text = "Editeaza";
            this.but_gata.UseVisualStyleBackColor = true;
            this.but_gata.Click += new System.EventHandler(this.but_gata_Click);
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume.Location = new System.Drawing.Point(678, 55);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(52, 16);
            this.Nume.TabIndex = 5;
            this.Nume.Text = "Nume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-mail:";
            // 
            // Frm_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.but_gata);
            this.Controls.Add(this.rtf_email);
            this.Controls.Add(this.rtf_numar);
            this.Controls.Add(this.rtf_nume);
            this.Controls.Add(this.dgv);
            this.Name = "Frm_edit";
            this.Text = "Editare Contact";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RichTextBox rtf_nume;
        private System.Windows.Forms.RichTextBox rtf_numar;
        private System.Windows.Forms.RichTextBox rtf_email;
        private System.Windows.Forms.Button but_gata;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}