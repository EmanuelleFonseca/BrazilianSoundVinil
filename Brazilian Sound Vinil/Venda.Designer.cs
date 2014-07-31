namespace Brazilian_Sound_Vinil
{
    partial class Venda
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
            this.lblNomeAlbum = new System.Windows.Forms.Label();
            this.lblQntIndividual = new System.Windows.Forms.Label();
            this.txtQntIndividual = new System.Windows.Forms.TextBox();
            this.btnAddVinil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbVinil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeAlbum
            // 
            this.lblNomeAlbum.AutoSize = true;
            this.lblNomeAlbum.Location = new System.Drawing.Point(12, 76);
            this.lblNomeAlbum.Name = "lblNomeAlbum";
            this.lblNomeAlbum.Size = new System.Drawing.Size(78, 13);
            this.lblNomeAlbum.TabIndex = 1;
            this.lblNomeAlbum.Text = "Nome do Vinil: ";
            // 
            // lblQntIndividual
            // 
            this.lblQntIndividual.AutoSize = true;
            this.lblQntIndividual.Location = new System.Drawing.Point(768, 76);
            this.lblQntIndividual.Name = "lblQntIndividual";
            this.lblQntIndividual.Size = new System.Drawing.Size(65, 13);
            this.lblQntIndividual.TabIndex = 2;
            this.lblQntIndividual.Text = "Quantidade:";
            // 
            // txtQntIndividual
            // 
            this.txtQntIndividual.Location = new System.Drawing.Point(855, 73);
            this.txtQntIndividual.Name = "txtQntIndividual";
            this.txtQntIndividual.Size = new System.Drawing.Size(51, 20);
            this.txtQntIndividual.TabIndex = 3;
            // 
            // btnAddVinil
            // 
            this.btnAddVinil.Location = new System.Drawing.Point(937, 70);
            this.btnAddVinil.Name = "btnAddVinil";
            this.btnAddVinil.Size = new System.Drawing.Size(75, 23);
            this.btnAddVinil.TabIndex = 4;
            this.btnAddVinil.Text = "Adicionar";
            this.btnAddVinil.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(997, 171);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(771, 324);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(112, 23);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar Compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(895, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar Compra";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbVinil
            // 
            this.cmbVinil.FormattingEnabled = true;
            this.cmbVinil.Location = new System.Drawing.Point(96, 72);
            this.cmbVinil.Name = "cmbVinil";
            this.cmbVinil.Size = new System.Drawing.Size(649, 21);
            this.cmbVinil.TabIndex = 8;
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 369);
            this.Controls.Add(this.cmbVinil);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddVinil);
            this.Controls.Add(this.txtQntIndividual);
            this.Controls.Add(this.lblQntIndividual);
            this.Controls.Add(this.lblNomeAlbum);
            this.Name = "Venda";
            this.Text = "Painel de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeAlbum;
        private System.Windows.Forms.Label lblQntIndividual;
        private System.Windows.Forms.TextBox txtQntIndividual;
        private System.Windows.Forms.Button btnAddVinil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbVinil;
    }
}

