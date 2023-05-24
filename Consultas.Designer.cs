namespace empadronamiento
{
    partial class Consultas
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvmostrar = new System.Windows.Forms.DataGridView();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.btnConsultaName = new System.Windows.Forms.Button();
            this.btnCui = new System.Windows.Forms.Button();
            this.btnApellido = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(336, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(113, 36);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Registro";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvmostrar
            // 
            this.dgvmostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmostrar.Location = new System.Drawing.Point(12, 167);
            this.dgvmostrar.Name = "dgvmostrar";
            this.dgvmostrar.Size = new System.Drawing.Size(776, 239);
            this.dgvmostrar.TabIndex = 2;
            // 
            // btnCodigo
            // 
            this.btnCodigo.Location = new System.Drawing.Point(38, 105);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(113, 36);
            this.btnCodigo.TabIndex = 3;
            this.btnCodigo.Text = "Consulta por codigo";
            this.btnCodigo.UseVisualStyleBackColor = true;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(336, 64);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(113, 20);
            this.txtconsulta.TabIndex = 4;
            // 
            // btnConsultaName
            // 
            this.btnConsultaName.Location = new System.Drawing.Point(465, 105);
            this.btnConsultaName.Name = "btnConsultaName";
            this.btnConsultaName.Size = new System.Drawing.Size(113, 36);
            this.btnConsultaName.TabIndex = 5;
            this.btnConsultaName.Text = "Consulta por Nombre";
            this.btnConsultaName.UseVisualStyleBackColor = true;
            this.btnConsultaName.Click += new System.EventHandler(this.btnConsultaName_Click);
            // 
            // btnCui
            // 
            this.btnCui.Location = new System.Drawing.Point(198, 105);
            this.btnCui.Name = "btnCui";
            this.btnCui.Size = new System.Drawing.Size(113, 36);
            this.btnCui.TabIndex = 7;
            this.btnCui.Text = "Consulta por CUI";
            this.btnCui.UseVisualStyleBackColor = true;
            this.btnCui.Click += new System.EventHandler(this.btnCui_Click);
            // 
            // btnApellido
            // 
            this.btnApellido.Location = new System.Drawing.Point(633, 105);
            this.btnApellido.Name = "btnApellido";
            this.btnApellido.Size = new System.Drawing.Size(113, 36);
            this.btnApellido.TabIndex = 8;
            this.btnApellido.Text = "Consulta por Apellido";
            this.btnApellido.UseVisualStyleBackColor = true;
            this.btnApellido.Click += new System.EventHandler(this.btnApellido_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(38, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(113, 36);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnApellido);
            this.Controls.Add(this.btnCui);
            this.Controls.Add(this.btnConsultaName);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.btnCodigo);
            this.Controls.Add(this.dgvmostrar);
            this.Controls.Add(this.btnMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgvmostrar;
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Button btnConsultaName;
        private System.Windows.Forms.Button btnCui;
        private System.Windows.Forms.Button btnApellido;
        private System.Windows.Forms.Button btnRegresar;
    }
}