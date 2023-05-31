namespace Trabalho_2
{
    partial class cad_peca
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_cad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fab = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_nomepeca = new System.Windows.Forms.TextBox();
            this.txt_nserie = new System.Windows.Forms.TextBox();
            this.btn_cad = new System.Windows.Forms.Button();
            this.btnMprincipal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_cad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_mod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_fab);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.txt_nomepeca);
            this.groupBox1.Controls.Add(this.txt_nserie);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(462, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // cmb_cad
            // 
            this.cmb_cad.FormattingEnabled = true;
            this.cmb_cad.Items.AddRange(new object[] {
            "Maycon",
            "Walisson"});
            this.cmb_cad.Location = new System.Drawing.Point(194, 189);
            this.cmb_cad.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_cad.Name = "cmb_cad";
            this.cmb_cad.Size = new System.Drawing.Size(230, 33);
            this.cmb_cad.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cadastrado por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nº de série:";
            // 
            // txt_mod
            // 
            this.txt_mod.Location = new System.Drawing.Point(194, 150);
            this.txt_mod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mod.Name = "txt_mod";
            this.txt_mod.Size = new System.Drawing.Size(230, 30);
            this.txt_mod.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fabricante:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_fab
            // 
            this.txt_fab.Location = new System.Drawing.Point(194, 111);
            this.txt_fab.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fab.Name = "txt_fab";
            this.txt_fab.Size = new System.Drawing.Size(230, 30);
            this.txt_fab.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 75);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(158, 25);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Nome da peça:";
            // 
            // txt_nomepeca
            // 
            this.txt_nomepeca.Location = new System.Drawing.Point(194, 72);
            this.txt_nomepeca.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomepeca.Name = "txt_nomepeca";
            this.txt_nomepeca.Size = new System.Drawing.Size(230, 30);
            this.txt_nomepeca.TabIndex = 1;
            // 
            // txt_nserie
            // 
            this.txt_nserie.Location = new System.Drawing.Point(194, 33);
            this.txt_nserie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nserie.Name = "txt_nserie";
            this.txt_nserie.Size = new System.Drawing.Size(230, 30);
            this.txt_nserie.TabIndex = 0;
            // 
            // btn_cad
            // 
            this.btn_cad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad.Location = new System.Drawing.Point(306, 267);
            this.btn_cad.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cad.Name = "btn_cad";
            this.btn_cad.Size = new System.Drawing.Size(169, 50);
            this.btn_cad.TabIndex = 11;
            this.btn_cad.Text = "CADASTRAR";
            this.btn_cad.UseVisualStyleBackColor = true;
            this.btn_cad.Click += new System.EventHandler(this.btn_cad_Click);
            // 
            // btnMprincipal
            // 
            this.btnMprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMprincipal.Location = new System.Drawing.Point(13, 267);
            this.btnMprincipal.Name = "btnMprincipal";
            this.btnMprincipal.Size = new System.Drawing.Size(169, 50);
            this.btnMprincipal.TabIndex = 12;
            this.btnMprincipal.Text = "Menu Principal";
            this.btnMprincipal.UseVisualStyleBackColor = true;
            this.btnMprincipal.Click += new System.EventHandler(this.btnMprincipal_Click);
            // 
            // cad_peca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(488, 330);
            this.Controls.Add(this.btnMprincipal);
            this.Controls.Add(this.btn_cad);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cad_peca";
            this.Text = "Cadastrar peça";
            this.Load += new System.EventHandler(this.cad_peca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_cad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mod;
        private System.Windows.Forms.TextBox txt_fab;
        private System.Windows.Forms.TextBox txt_nomepeca;
        private System.Windows.Forms.TextBox txt_nserie;
        private System.Windows.Forms.Button btn_cad;
        private System.Windows.Forms.Button btnMprincipal;
    }
}