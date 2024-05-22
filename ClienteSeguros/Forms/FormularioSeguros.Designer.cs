namespace ClienteSeguros.Forms
{
    partial class FormularioSeguros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAñadirSeguro = new System.Windows.Forms.Button();
            this.dtgMostrarSeguros = new System.Windows.Forms.DataGridView();
            this.btnActualizarSeguro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.btnEditarSeguro = new System.Windows.Forms.Button();
            this.btnEliminarSeguro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarSeguros)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(709, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "NOMBRE";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(713, 91);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(232, 27);
            this.textBoxNombre.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Azure;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAñadirSeguro
            // 
            this.btnAñadirSeguro.BackColor = System.Drawing.Color.Tomato;
            this.btnAñadirSeguro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirSeguro.Location = new System.Drawing.Point(713, 298);
            this.btnAñadirSeguro.Name = "btnAñadirSeguro";
            this.btnAñadirSeguro.Size = new System.Drawing.Size(232, 47);
            this.btnAñadirSeguro.TabIndex = 15;
            this.btnAñadirSeguro.Text = "GUARDAR";
            this.btnAñadirSeguro.UseVisualStyleBackColor = false;
            this.btnAñadirSeguro.Click += new System.EventHandler(this.btnAñadirSeguro_Click);
            // 
            // dtgMostrarSeguros
            // 
            this.dtgMostrarSeguros.AllowUserToAddRows = false;
            this.dtgMostrarSeguros.AllowUserToDeleteRows = false;
            this.dtgMostrarSeguros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMostrarSeguros.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dtgMostrarSeguros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMostrarSeguros.Location = new System.Drawing.Point(28, 68);
            this.dtgMostrarSeguros.Name = "dtgMostrarSeguros";
            this.dtgMostrarSeguros.ReadOnly = true;
            this.dtgMostrarSeguros.RowHeadersVisible = false;
            this.dtgMostrarSeguros.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgMostrarSeguros.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMostrarSeguros.RowTemplate.Height = 24;
            this.dtgMostrarSeguros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMostrarSeguros.Size = new System.Drawing.Size(629, 330);
            this.dtgMostrarSeguros.TabIndex = 13;
            // 
            // btnActualizarSeguro
            // 
            this.btnActualizarSeguro.BackColor = System.Drawing.Color.Tomato;
            this.btnActualizarSeguro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarSeguro.Location = new System.Drawing.Point(713, 351);
            this.btnActualizarSeguro.Name = "btnActualizarSeguro";
            this.btnActualizarSeguro.Size = new System.Drawing.Size(232, 47);
            this.btnActualizarSeguro.TabIndex = 25;
            this.btnActualizarSeguro.Text = "ACTUALIZAR";
            this.btnActualizarSeguro.UseVisualStyleBackColor = false;
            this.btnActualizarSeguro.Click += new System.EventHandler(this.btnActualizarSeguro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxDescripcion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxPrecio);
            this.panel1.Controls.Add(this.btnEditarSeguro);
            this.panel1.Controls.Add(this.btnEliminarSeguro);
            this.panel1.Controls.Add(this.btnActualizarSeguro);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAñadirSeguro);
            this.panel1.Controls.Add(this.dtgMostrarSeguros);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 467);
            this.panel1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(249, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 38);
            this.label4.TabIndex = 30;
            this.label4.Text = "SEGUROS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(709, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "DESCRIPCIÓN";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(713, 197);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(232, 95);
            this.textBoxDescripcion.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(709, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "PRECIO";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(713, 144);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(232, 27);
            this.textBoxPrecio.TabIndex = 26;
            // 
            // btnEditarSeguro
            // 
            this.btnEditarSeguro.BackColor = System.Drawing.Color.Tomato;
            this.btnEditarSeguro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarSeguro.Location = new System.Drawing.Point(427, 404);
            this.btnEditarSeguro.Name = "btnEditarSeguro";
            this.btnEditarSeguro.Size = new System.Drawing.Size(112, 51);
            this.btnEditarSeguro.TabIndex = 19;
            this.btnEditarSeguro.Text = "EDITAR";
            this.btnEditarSeguro.UseVisualStyleBackColor = false;
            this.btnEditarSeguro.Click += new System.EventHandler(this.btnEditarSeguro_Click);
            // 
            // btnEliminarSeguro
            // 
            this.btnEliminarSeguro.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminarSeguro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSeguro.Location = new System.Drawing.Point(545, 404);
            this.btnEliminarSeguro.Name = "btnEliminarSeguro";
            this.btnEliminarSeguro.Size = new System.Drawing.Size(112, 51);
            this.btnEliminarSeguro.TabIndex = 16;
            this.btnEliminarSeguro.Text = "ELIMINAR";
            this.btnEliminarSeguro.UseVisualStyleBackColor = false;
            this.btnEliminarSeguro.Click += new System.EventHandler(this.btnEliminarSeguro_Click);
            // 
            // FormularioSeguros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 467);
            this.Controls.Add(this.panel1);
            this.Name = "FormularioSeguros";
            this.Text = "FormularioSeguros";
            this.Load += new System.EventHandler(this.FormularioSeguros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarSeguros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAñadirSeguro;
        private System.Windows.Forms.DataGridView dtgMostrarSeguros;
        private System.Windows.Forms.Button btnActualizarSeguro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditarSeguro;
        private System.Windows.Forms.Button btnEliminarSeguro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label4;
    }
}