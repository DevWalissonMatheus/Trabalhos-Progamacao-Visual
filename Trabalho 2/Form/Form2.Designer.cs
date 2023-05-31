namespace Trabalho_2
{
    partial class menu_principal
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
            this.gpbox_func = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_excpeca = new System.Windows.Forms.Button();
            this.btn_cnspeca = new System.Windows.Forms.Button();
            this.btn_cadpeca = new System.Windows.Forms.Button();
            this.gpbox_func.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbox_func
            // 
            this.gpbox_func.Controls.Add(this.label1);
            this.gpbox_func.Controls.Add(this.btn_excpeca);
            this.gpbox_func.Controls.Add(this.btn_cnspeca);
            this.gpbox_func.Controls.Add(this.btn_cadpeca);
            this.gpbox_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbox_func.Location = new System.Drawing.Point(34, 39);
            this.gpbox_func.Margin = new System.Windows.Forms.Padding(4);
            this.gpbox_func.Name = "gpbox_func";
            this.gpbox_func.Padding = new System.Windows.Forms.Padding(4);
            this.gpbox_func.Size = new System.Drawing.Size(318, 246);
            this.gpbox_func.TabIndex = 0;
            this.gpbox_func.TabStop = false;
            this.gpbox_func.Text = "Funcionalidades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clique na opção desejada:";
            // 
            // btn_excpeca
            // 
            this.btn_excpeca.Location = new System.Drawing.Point(64, 177);
            this.btn_excpeca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excpeca.Name = "btn_excpeca";
            this.btn_excpeca.Size = new System.Drawing.Size(191, 46);
            this.btn_excpeca.TabIndex = 2;
            this.btn_excpeca.Text = "Excluir peça";
            this.btn_excpeca.UseVisualStyleBackColor = true;
            this.btn_excpeca.Click += new System.EventHandler(this.btn_excpeca_Click);
            // 
            // btn_cnspeca
            // 
            this.btn_cnspeca.Location = new System.Drawing.Point(64, 123);
            this.btn_cnspeca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cnspeca.Name = "btn_cnspeca";
            this.btn_cnspeca.Size = new System.Drawing.Size(191, 46);
            this.btn_cnspeca.TabIndex = 1;
            this.btn_cnspeca.Text = "Consultar peça";
            this.btn_cnspeca.UseVisualStyleBackColor = true;
            this.btn_cnspeca.Click += new System.EventHandler(this.btn_cnspeca_Click);
            // 
            // btn_cadpeca
            // 
            this.btn_cadpeca.Location = new System.Drawing.Point(64, 69);
            this.btn_cadpeca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadpeca.Name = "btn_cadpeca";
            this.btn_cadpeca.Size = new System.Drawing.Size(191, 46);
            this.btn_cadpeca.TabIndex = 0;
            this.btn_cadpeca.Text = "Cadastrar peça";
            this.btn_cadpeca.UseVisualStyleBackColor = true;
            this.btn_cadpeca.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(393, 335);
            this.Controls.Add(this.gpbox_func);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menu_principal";
            this.Text = "Menu principal";
            this.gpbox_func.ResumeLayout(false);
            this.gpbox_func.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbox_func;
        private System.Windows.Forms.Button btn_excpeca;
        private System.Windows.Forms.Button btn_cnspeca;
        private System.Windows.Forms.Button btn_cadpeca;
        private System.Windows.Forms.Label label1;
    }
}