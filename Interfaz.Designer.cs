
namespace Practica_4
{
    partial class Interfaz
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
            this.pnTrimestre = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAprobada = new System.Windows.Forms.RadioButton();
            this.rbReprobadas = new System.Windows.Forms.RadioButton();
            this.txtTrimestre = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.btnTrimestre = new System.Windows.Forms.Button();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.txtFacilitador = new System.Windows.Forms.TextBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.cbbTrimestre = new System.Windows.Forms.ComboBox();
            this.btnAsignatura = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.pnTrimestre.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTrimestre
            // 
            this.pnTrimestre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTrimestre.Controls.Add(this.btnTrimestre);
            this.pnTrimestre.Controls.Add(this.txtPeriodo);
            this.pnTrimestre.Controls.Add(this.label2);
            this.pnTrimestre.Controls.Add(this.txtTrimestre);
            this.pnTrimestre.Location = new System.Drawing.Point(12, 12);
            this.pnTrimestre.Name = "pnTrimestre";
            this.pnTrimestre.Size = new System.Drawing.Size(265, 100);
            this.pnTrimestre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Amaranth", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(53, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Asignatura";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAsignatura);
            this.panel2.Controls.Add(this.cbbTrimestre);
            this.panel2.Controls.Add(this.txtCalificacion);
            this.panel2.Controls.Add(this.txtFacilitador);
            this.panel2.Controls.Add(this.txtAsignatura);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 202);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Amaranth", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(53, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nuevo Trimestre";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbReprobadas);
            this.panel3.Controls.Add(this.rbAprobada);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 76);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Amaranth", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(53, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Búsqueda Filtrada";
            // 
            // rbAprobada
            // 
            this.rbAprobada.AutoSize = true;
            this.rbAprobada.Font = new System.Drawing.Font("Amaranth", 12F);
            this.rbAprobada.Location = new System.Drawing.Point(3, 47);
            this.rbAprobada.Name = "rbAprobada";
            this.rbAprobada.Size = new System.Drawing.Size(104, 24);
            this.rbAprobada.TabIndex = 3;
            this.rbAprobada.TabStop = true;
            this.rbAprobada.Text = "Aprobadas";
            this.rbAprobada.UseVisualStyleBackColor = true;
            this.rbAprobada.CheckedChanged += new System.EventHandler(this.rbAprobada_CheckedChanged);
            // 
            // rbReprobadas
            // 
            this.rbReprobadas.AutoSize = true;
            this.rbReprobadas.Font = new System.Drawing.Font("Amaranth", 12F);
            this.rbReprobadas.Location = new System.Drawing.Point(151, 47);
            this.rbReprobadas.Name = "rbReprobadas";
            this.rbReprobadas.Size = new System.Drawing.Size(111, 24);
            this.rbReprobadas.TabIndex = 4;
            this.rbReprobadas.TabStop = true;
            this.rbReprobadas.Text = "Reprobadas";
            this.rbReprobadas.UseVisualStyleBackColor = true;
            this.rbReprobadas.CheckedChanged += new System.EventHandler(this.rbAprobada_CheckedChanged);
            // 
            // txtTrimestre
            // 
            this.txtTrimestre.Font = new System.Drawing.Font("Amaranth", 13F);
            this.txtTrimestre.Location = new System.Drawing.Point(4, 30);
            this.txtTrimestre.Name = "txtTrimestre";
            this.txtTrimestre.Size = new System.Drawing.Size(221, 29);
            this.txtTrimestre.TabIndex = 1;
            this.txtTrimestre.Tag = "Trimestre";
            this.txtTrimestre.Text = "Trimestre";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Font = new System.Drawing.Font("Amaranth", 13F);
            this.txtPeriodo.Location = new System.Drawing.Point(4, 65);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(115, 29);
            this.txtPeriodo.TabIndex = 2;
            this.txtPeriodo.Tag = "Período";
            this.txtPeriodo.Text = "Período";
            // 
            // btnTrimestre
            // 
            this.btnTrimestre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrimestre.FlatAppearance.BorderSize = 0;
            this.btnTrimestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrimestre.Font = new System.Drawing.Font("Amaranth", 14F, System.Drawing.FontStyle.Bold);
            this.btnTrimestre.Location = new System.Drawing.Point(134, 62);
            this.btnTrimestre.Name = "btnTrimestre";
            this.btnTrimestre.Size = new System.Drawing.Size(91, 32);
            this.btnTrimestre.TabIndex = 3;
            this.btnTrimestre.Text = "Guardar";
            this.btnTrimestre.UseVisualStyleBackColor = true;
            this.btnTrimestre.Click += new System.EventHandler(this.btnTrimestre_Click);
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.Font = new System.Drawing.Font("Amaranth", 13F);
            this.txtAsignatura.Location = new System.Drawing.Point(5, 41);
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.Size = new System.Drawing.Size(257, 29);
            this.txtAsignatura.TabIndex = 2;
            this.txtAsignatura.Tag = "Nombre de la asignatura";
            this.txtAsignatura.Text = "Nombre de la asignatura";
            // 
            // txtFacilitador
            // 
            this.txtFacilitador.Font = new System.Drawing.Font("Amaranth", 13F);
            this.txtFacilitador.Location = new System.Drawing.Point(5, 80);
            this.txtFacilitador.Name = "txtFacilitador";
            this.txtFacilitador.Size = new System.Drawing.Size(257, 29);
            this.txtFacilitador.TabIndex = 3;
            this.txtFacilitador.Tag = "Nombre del facilitador";
            this.txtFacilitador.Text = "Nombre del facilitador";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Font = new System.Drawing.Font("Amaranth", 13F);
            this.txtCalificacion.Location = new System.Drawing.Point(5, 118);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(84, 29);
            this.txtCalificacion.TabIndex = 4;
            this.txtCalificacion.Tag = "Nota";
            this.txtCalificacion.Text = "Nota";
            // 
            // cbbTrimestre
            // 
            this.cbbTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrimestre.Font = new System.Drawing.Font("Amaranth", 12F);
            this.cbbTrimestre.FormattingEnabled = true;
            this.cbbTrimestre.Location = new System.Drawing.Point(96, 119);
            this.cbbTrimestre.Name = "cbbTrimestre";
            this.cbbTrimestre.Size = new System.Drawing.Size(166, 28);
            this.cbbTrimestre.TabIndex = 5;
            // 
            // btnAsignatura
            // 
            this.btnAsignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignatura.FlatAppearance.BorderSize = 0;
            this.btnAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignatura.Font = new System.Drawing.Font("Amaranth", 14F, System.Drawing.FontStyle.Bold);
            this.btnAsignatura.Location = new System.Drawing.Point(171, 162);
            this.btnAsignatura.Name = "btnAsignatura";
            this.btnAsignatura.Size = new System.Drawing.Size(91, 32);
            this.btnAsignatura.TabIndex = 4;
            this.btnAsignatura.Text = "Guardar";
            this.btnAsignatura.UseVisualStyleBackColor = true;
            this.btnAsignatura.Click += new System.EventHandler(this.btnAsignatura_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDatos);
            this.panel1.Location = new System.Drawing.Point(283, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 417);
            this.panel1.TabIndex = 2;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Amaranth", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Amaranth", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Amaranth", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.Size = new System.Drawing.Size(606, 417);
            this.dgvDatos.TabIndex = 0;
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnTrimestre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Interfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz";
            this.pnTrimestre.ResumeLayout(false);
            this.pnTrimestre.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTrimestre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrimestre;
        private System.Windows.Forms.RadioButton rbReprobadas;
        private System.Windows.Forms.RadioButton rbAprobada;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Button btnTrimestre;
        private System.Windows.Forms.Button btnAsignatura;
        private System.Windows.Forms.ComboBox cbbTrimestre;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.TextBox txtFacilitador;
        private System.Windows.Forms.TextBox txtAsignatura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}