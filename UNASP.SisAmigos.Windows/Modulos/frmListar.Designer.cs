namespace UNASP.SisAmigos.Windows.Modulos
{
    partial class frmListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListar));
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.lblNomeFiltro = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.txtFiltroNome = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gpbFiltro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.gpbFiltro.Controls.Add(this.lblNomeFiltro);
            this.gpbFiltro.Controls.Add(this.btnFiltro);
            this.gpbFiltro.Controls.Add(this.txtFiltroNome);
            this.gpbFiltro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFiltro.Location = new System.Drawing.Point(26, 33);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(596, 100);
            this.gpbFiltro.TabIndex = 1;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Painel de Filtro";
            // 
            // lblNomeFiltro
            // 
            this.lblNomeFiltro.AutoSize = true;
            this.lblNomeFiltro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFiltro.Location = new System.Drawing.Point(26, 29);
            this.lblNomeFiltro.Name = "lblNomeFiltro";
            this.lblNomeFiltro.Size = new System.Drawing.Size(45, 13);
            this.lblNomeFiltro.TabIndex = 2;
            this.lblNomeFiltro.Text = "Nome:";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltro.Image")));
            this.btnFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltro.Location = new System.Drawing.Point(472, 36);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(96, 37);
            this.btnFiltro.TabIndex = 1;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // txtFiltroNome
            // 
            this.txtFiltroNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroNome.Location = new System.Drawing.Point(29, 45);
            this.txtFiltroNome.Name = "txtFiltroNome";
            this.txtFiltroNome.Size = new System.Drawing.Size(437, 21);
            this.txtFiltroNome.TabIndex = 0;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.Location = new System.Drawing.Point(144, 495);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(126, 48);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(14, 495);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 48);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.dgvListar);
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 570);
            this.panel1.TabIndex = 6;
            // 
            // dgvListar
            // 
            this.dgvListar.AllowUserToAddRows = false;
            this.dgvListar.AllowUserToDeleteRows = false;
            this.dgvListar.AllowUserToResizeRows = false;
            this.dgvListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Location = new System.Drawing.Point(14, 139);
            this.dgvListar.MultiSelect = false;
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.RowTemplate.ReadOnly = true;
            this.dgvListar.ShowEditingIcon = false;
            this.dgvListar.Size = new System.Drawing.Size(759, 336);
            this.dgvListar.TabIndex = 5;
            this.dgvListar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListar_CellClick);
            this.dgvListar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListar_CellDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(810, 594);
            this.Controls.Add(this.gpbFiltro);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.frmListar_Load);
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.Label lblNomeFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.TextBox txtFiltroNome;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}