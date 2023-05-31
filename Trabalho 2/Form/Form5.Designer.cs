namespace Trabalho_2
{
    partial class fExclusao
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnMenuPrinc = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblExclusao = new System.Windows.Forms.Label();
            this.lblAtenção = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(742, 250);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnMenuPrinc
            // 
            this.btnMenuPrinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrinc.Location = new System.Drawing.Point(18, 316);
            this.btnMenuPrinc.Name = "btnMenuPrinc";
            this.btnMenuPrinc.Size = new System.Drawing.Size(188, 46);
            this.btnMenuPrinc.TabIndex = 3;
            this.btnMenuPrinc.Text = "Menu Principal";
            this.btnMenuPrinc.UseVisualStyleBackColor = true;
            this.btnMenuPrinc.Click += new System.EventHandler(this.btnMenuPrinc_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(623, 316);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 46);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblExclusao
            // 
            this.lblExclusao.AutoSize = true;
            this.lblExclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExclusao.Location = new System.Drawing.Point(205, 13);
            this.lblExclusao.Name = "lblExclusao";
            this.lblExclusao.Size = new System.Drawing.Size(419, 29);
            this.lblExclusao.TabIndex = 0;
            this.lblExclusao.Text = "Escolha a peça que deseja excluir:";
            // 
            // lblAtenção
            // 
            this.lblAtenção.AutoSize = true;
            this.lblAtenção.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtenção.Location = new System.Drawing.Point(209, 331);
            this.lblAtenção.Name = "lblAtenção";
            this.lblAtenção.Size = new System.Drawing.Size(377, 22);
            this.lblAtenção.TabIndex = 5;
            this.lblAtenção.Text = "Clique no quadrado branco ao lado do ID";
            // 
            // fExclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(793, 374);
            this.Controls.Add(this.lblAtenção);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnMenuPrinc);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblExclusao);
            this.Name = "fExclusao";
            this.Text = "Excluir peça";
            this.Load += new System.EventHandler(this.fExclusao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnMenuPrinc;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblExclusao;
        private System.Windows.Forms.Label lblAtenção;
    }
}