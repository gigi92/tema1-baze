namespace Tema1
{
    partial class Frm_del
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.dgv.Location = new System.Drawing.Point(21, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(623, 299);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // rtf_nume
            // 
            this.rtf_nume.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtf_nume.Location = new System.Drawing.Point(733, 57);
            this.rtf_nume.Name = "rtf_nume";
            this.rtf_nume.ReadOnly = true;
            this.rtf_nume.Size = new System.Drawing.Size(148, 28);
            this.rtf_nume.TabIndex = 1;
            this.rtf_nume.Text = "";
            // 
            // rtf_numar
            // 
            this.rtf_numar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtf_numar.Location = new System.Drawing.Point(733, 122);
            this.rtf_numar.Name = "rtf_numar";
            this.rtf_numar.ReadOnly = true;
            this.rtf_numar.Size = new System.Drawing.Size(148, 28);
            this.rtf_numar.TabIndex = 2;
            this.rtf_numar.Text = "";
            // 
            // rtf_email
            // 
            this.rtf_email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtf_email.Location = new System.Drawing.Point(733, 182);
            this.rtf_email.Name = "rtf_email";
            this.rtf_email.ReadOnly = true;
            this.rtf_email.Size = new System.Drawing.Size(148, 28);
            this.rtf_email.TabIndex = 3;
            this.rtf_email.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sterge";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume.Location = new System.Drawing.Point(675, 58);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(52, 16);
            this.Nume.TabIndex = 6;
            this.Nume.Text = "Nume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(675, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "E-mail:";
            // 
            // Frm_del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtf_email);
            this.Controls.Add(this.rtf_numar);
            this.Controls.Add(this.rtf_nume);
            this.Controls.Add(this.dgv);
            this.Name = "Frm_del";
            this.Text = "Stergere contact";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RichTextBox rtf_nume;
        private System.Windows.Forms.RichTextBox rtf_numar;
        private System.Windows.Forms.RichTextBox rtf_email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}