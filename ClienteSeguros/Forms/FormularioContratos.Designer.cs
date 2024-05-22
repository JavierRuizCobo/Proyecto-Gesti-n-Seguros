namespace ClienteSeguros.Forms
{
    partial class FormularioContratos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtgMostrarClientes = new System.Windows.Forms.DataGridView();
            this.dtgMostrarSeguros = new System.Windows.Forms.DataGridView();
            this.btnAñadirContrato = new System.Windows.Forms.Button();
            this.btnEliminarContrato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgMostrarContratos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarSeguros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Azure;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtgMostrarClientes
            // 
            this.dtgMostrarClientes.AllowUserToAddRows = false;
            this.dtgMostrarClientes.AllowUserToDeleteRows = false;
            this.dtgMostrarClientes.AllowUserToResizeColumns = false;
            this.dtgMostrarClientes.AllowUserToResizeRows = false;
            this.dtgMostrarClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgMostrarClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.dtgMostrarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMostrarClientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMostrarClientes.Location = new System.Drawing.Point(12, 64);
            this.dtgMostrarClientes.Name = "dtgMostrarClientes";
            this.dtgMostrarClientes.ReadOnly = true;
            this.dtgMostrarClientes.RowHeadersVisible = false;
            this.dtgMostrarClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgMostrarClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMostrarClientes.RowTemplate.Height = 24;
            this.dtgMostrarClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMostrarClientes.Size = new System.Drawing.Size(420, 176);
            this.dtgMostrarClientes.TabIndex = 17;
            // 
            // dtgMostrarSeguros
            // 
            this.dtgMostrarSeguros.AllowUserToAddRows = false;
            this.dtgMostrarSeguros.AllowUserToDeleteRows = false;
            this.dtgMostrarSeguros.AllowUserToResizeColumns = false;
            this.dtgMostrarSeguros.AllowUserToResizeRows = false;
            this.dtgMostrarSeguros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgMostrarSeguros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.dtgMostrarSeguros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMostrarSeguros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgMostrarSeguros.Location = new System.Drawing.Point(12, 267);
            this.dtgMostrarSeguros.Name = "dtgMostrarSeguros";
            this.dtgMostrarSeguros.ReadOnly = true;
            this.dtgMostrarSeguros.RowHeadersVisible = false;
            this.dtgMostrarSeguros.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgMostrarSeguros.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgMostrarSeguros.RowTemplate.Height = 24;
            this.dtgMostrarSeguros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMostrarSeguros.Size = new System.Drawing.Size(420, 176);
            this.dtgMostrarSeguros.TabIndex = 18;
            // 
            // btnAñadirContrato
            // 
            this.btnAñadirContrato.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAñadirContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirContrato.Location = new System.Drawing.Point(438, 181);
            this.btnAñadirContrato.Name = "btnAñadirContrato";
            this.btnAñadirContrato.Size = new System.Drawing.Size(98, 59);
            this.btnAñadirContrato.TabIndex = 19;
            this.btnAñadirContrato.Text = "AÑADIR CONTRATO";
            this.btnAñadirContrato.UseVisualStyleBackColor = false;
            this.btnAñadirContrato.Click += new System.EventHandler(this.btnAñadirContrato_Click);
            // 
            // btnEliminarContrato
            // 
            this.btnEliminarContrato.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEliminarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarContrato.Location = new System.Drawing.Point(438, 267);
            this.btnEliminarContrato.Name = "btnEliminarContrato";
            this.btnEliminarContrato.Size = new System.Drawing.Size(98, 59);
            this.btnEliminarContrato.TabIndex = 20;
            this.btnEliminarContrato.Text = "ELIMINAR CONTRATO";
            this.btnEliminarContrato.UseVisualStyleBackColor = false;
            this.btnEliminarContrato.Click += new System.EventHandler(this.btnEliminarContrato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(184, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(184, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "SEGUROS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(714, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "CONTRATOS";
            // 
            // dtgMostrarContratos
            // 
            this.dtgMostrarContratos.AllowUserToAddRows = false;
            this.dtgMostrarContratos.AllowUserToDeleteRows = false;
            this.dtgMostrarContratos.AllowUserToResizeColumns = false;
            this.dtgMostrarContratos.AllowUserToResizeRows = false;
            this.dtgMostrarContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgMostrarContratos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.dtgMostrarContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMostrarContratos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgMostrarContratos.Location = new System.Drawing.Point(542, 64);
            this.dtgMostrarContratos.Name = "dtgMostrarContratos";
            this.dtgMostrarContratos.ReadOnly = true;
            this.dtgMostrarContratos.RowHeadersVisible = false;
            this.dtgMostrarContratos.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgMostrarContratos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgMostrarContratos.RowTemplate.Height = 24;
            this.dtgMostrarContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMostrarContratos.Size = new System.Drawing.Size(420, 379);
            this.dtgMostrarContratos.TabIndex = 24;
            // 
            // FormularioContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(995, 467);
            this.Controls.Add(this.dtgMostrarContratos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarContrato);
            this.Controls.Add(this.btnAñadirContrato);
            this.Controls.Add(this.dtgMostrarSeguros);
            this.Controls.Add(this.dtgMostrarClientes);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormularioContratos";
            this.Text = "FormularioContratosSeguros";
            this.Load += new System.EventHandler(this.FormularioContratosSeguros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarSeguros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dtgMostrarClientes;
        private System.Windows.Forms.DataGridView dtgMostrarSeguros;
        private System.Windows.Forms.Button btnAñadirContrato;
        private System.Windows.Forms.Button btnEliminarContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgMostrarContratos;
    }
}