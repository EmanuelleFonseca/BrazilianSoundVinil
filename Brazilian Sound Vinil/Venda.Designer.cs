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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venda));
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
            this.lblNomeAlbum.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeAlbum.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAlbum.Location = new System.Drawing.Point(12, 76);
            this.lblNomeAlbum.Name = "lblNomeAlbum";
            this.lblNomeAlbum.Size = new System.Drawing.Size(147, 27);
            this.lblNomeAlbum.TabIndex = 1;
            this.lblNomeAlbum.Text = "Nome do Vinil: ";
            // 
            // lblQntIndividual
            // 
            this.lblQntIndividual.AutoSize = true;
            this.lblQntIndividual.BackColor = System.Drawing.Color.Transparent;
            this.lblQntIndividual.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntIndividual.Location = new System.Drawing.Point(616, 76);
            this.lblQntIndividual.Name = "lblQntIndividual";
            this.lblQntIndividual.Size = new System.Drawing.Size(120, 27);
            this.lblQntIndividual.TabIndex = 2;
            this.lblQntIndividual.Text = "Quantidade:";
            // 
            // txtQntIndividual
            // 
            this.txtQntIndividual.Location = new System.Drawing.Point(734, 81);
            this.txtQntIndividual.Name = "txtQntIndividual";
            this.txtQntIndividual.Size = new System.Drawing.Size(40, 20);
            this.txtQntIndividual.TabIndex = 3;
            // 
            // btnAddVinil
            // 
            this.btnAddVinil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddVinil.Location = new System.Drawing.Point(780, 81);
            this.btnAddVinil.Name = "btnAddVinil";
            this.btnAddVinil.Size = new System.Drawing.Size(94, 23);
            this.btnAddVinil.TabIndex = 4;
            this.btnAddVinil.Text = "Adicionar";
            this.btnAddVinil.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 458);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFinalizar.Location = new System.Drawing.Point(577, 603);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(151, 23);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar Compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancel.Location = new System.Drawing.Point(734, 603);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar Compra";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbVinil
            // 
            this.cmbVinil.FormattingEnabled = true;
            this.cmbVinil.Location = new System.Drawing.Point(153, 81);
            this.cmbVinil.Name = "cmbVinil";
            this.cmbVinil.Size = new System.Drawing.Size(457, 21);
            this.cmbVinil.TabIndex = 8;
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(886, 658);
            this.Controls.Add(this.cmbVinil);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddVinil);
            this.Controls.Add(this.txtQntIndividual);
            this.Controls.Add(this.lblQntIndividual);
            this.Controls.Add(this.lblNomeAlbum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Painel de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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

