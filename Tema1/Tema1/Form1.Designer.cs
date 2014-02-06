namespace Tema1
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label_cautare = new System.Windows.Forms.Label();
            this.rtf_search = new System.Windows.Forms.RichTextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.rtf_search2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtf_search3 = new System.Windows.Forms.RichTextBox();
            this.but_add = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_edit = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sfd2 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_cautare
            // 
            this.label_cautare.AutoSize = true;
            this.label_cautare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cautare.Location = new System.Drawing.Point(47, 32);
            this.label_cautare.Name = "label_cautare";
            this.label_cautare.Size = new System.Drawing.Size(66, 16);
            this.label_cautare.TabIndex = 2;
            this.label_cautare.Text = "Cautare:";
            // 
            // rtf_search
            // 
            this.rtf_search.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.rtf_search.Location = new System.Drawing.Point(169, 32);
            this.rtf_search.Name = "rtf_search";
            this.rtf_search.Size = new System.Drawing.Size(216, 23);
            this.rtf_search.TabIndex = 3;
            this.rtf_search.Text = "";
            this.rtf_search.TextChanged += new System.EventHandler(this.rtf_search_TextChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Location = new System.Drawing.Point(50, 144);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(623, 210);
            this.dgv.TabIndex = 7;
            // 
            // rtf_search2
            // 
            this.rtf_search2.Location = new System.Drawing.Point(169, 66);
            this.rtf_search2.Name = "rtf_search2";
            this.rtf_search2.Size = new System.Drawing.Size(216, 22);
            this.rtf_search2.TabIndex = 9;
            this.rtf_search2.Text = "";
            this.rtf_search2.TextChanged += new System.EventHandler(this.rtf_search2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Adresa de e-mail";
            // 
            // rtf_search3
            // 
            this.rtf_search3.Location = new System.Drawing.Point(169, 100);
            this.rtf_search3.Name = "rtf_search3";
            this.rtf_search3.Size = new System.Drawing.Size(216, 22);
            this.rtf_search3.TabIndex = 13;
            this.rtf_search3.Text = "";
            this.rtf_search3.TextChanged += new System.EventHandler(this.rtf_search3_TextChanged);
            // 
            // but_add
            // 
            this.but_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add.Image = ((System.Drawing.Image)(resources.GetObject("but_add.Image")));
            this.but_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_add.Location = new System.Drawing.Point(40, 390);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(181, 55);
            this.but_add.TabIndex = 6;
            this.but_add.Text = "Adaugare Contact";
            this.but_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_del
            // 
            this.but_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_del.Image = global::Tema1.Properties.Resources.Close_2_icon;
            this.but_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_del.Location = new System.Drawing.Point(510, 390);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(163, 55);
            this.but_del.TabIndex = 5;
            this.but_del.Text = "Stergere Contact";
            this.but_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // but_edit
            // 
            this.but_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_edit.Image = global::Tema1.Properties.Resources.Pencil_icon;
            this.but_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_edit.Location = new System.Drawing.Point(283, 390);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(163, 55);
            this.but_edit.TabIndex = 4;
            this.but_edit.Text = "Editare Contact";
            this.but_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_Edit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salveaza in XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Salveaza in Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(453, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salvare Agenda";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtf_search3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtf_search2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_del);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.rtf_search);
            this.Controls.Add(this.label_cautare);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Agenda Telefonica";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cautare;
        private System.Windows.Forms.RichTextBox rtf_search;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RichTextBox rtf_search2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtf_search3;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog sfd2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

