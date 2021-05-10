using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Interfaz : Form
    {
        //Instancia de la clase Datos y 
        //Declaración de las variables
        Datos datos = new Datos();
        string asignatura, facilitador;
        int calificacion, idtrimestre;
        char literal;
        public Interfaz()
        {
            InitializeComponent();
            putHint();
            cargarCBB();
            llenarGrid();
        }
        
        //Coloca el texto de ayuda en cada TextBox
        private void putHint()
        {
            foreach(Panel pn in this.Controls)
            {
                foreach(var ctrl in pn.Controls)
                {
                    if(ctrl is TextBox)
                    {
                        TextBox txt = (TextBox)ctrl;
                        txt.Enter += Txt_Enter;
                        txt.Leave += Txt_Leave;
                    }
                }
            }
        }
        //Al salir del textbox, si está vacío
        //Vuelve a Colocar el texto de ayuda
        private void Txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = txt.Tag.ToString();
            }
        }

         //Al entrar al textbox, si está vacío
        //Quita el texto de ayuda
        private void Txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text==txt.Tag.ToString())
            {
                txt.Clear();
            }
        }
        
        //Recorre y limpia cada textBox
        private void Limpiar()
        {
            foreach (Panel pn in this.Controls)
            {
                foreach (var ctrl in pn.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        TextBox txt = (TextBox)ctrl;
                        txt.Clear();
                        txt.Focus();
                    }
                }
            }
        }
        //Llama al método insertTrimestre de la clase Datos
        //Para registrar un nuevo trimestre
        private void btnTrimestre_Click(object sender, EventArgs e)
        {
            string trimestre = txtTrimestre.Text;
            string periodo = txtPeriodo.Text;
            datos.insertTrimestre(trimestre, periodo);
            Limpiar();
            MessageBox.Show("Período Registrado");
            cargarCBB();
        }
        private void cargarCBB()
        {
            cbbTrimestre.DataSource = datos.Trimestres();
            cbbTrimestre.DisplayMember = "Trimestre";
            cbbTrimestre.ValueMember = "idTrimestre";
        }
        //Llena el Combobox con los trimestres
        private void llenarGrid()
        {
            dgvDatos.DataSource = datos.Asignaturas();
        }

        //Verifica el Radiobutton Marcado para llenar el DGB
        private void rbAprobada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAprobada.Checked)
            {
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = datos.Aprobadas();
            }
            else
            {
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = datos.Reprobadas();
            }
        }
    
        //Asigna valores a la variables declaradas arriba
        private void asignarValores()
        {
            asignatura = txtAsignatura.Text;
            facilitador = txtFacilitador.Text;
            calificacion = int.Parse(txtCalificacion.Text);
            idtrimestre = int.Parse(cbbTrimestre.SelectedValue.ToString());
            literal = 'F';
            if (calificacion >= 90)
            {
                literal = 'A';
            } else if (calificacion>=80)
            {
                literal = 'B';
            }
            else if (calificacion >= 75)
            {
                literal = 'C';
            }
            else if (calificacion >= 70)
            {
                literal = 'D';
            }
        }
        //Llama al método insertAsignatura de la clase Datos
        //Para registrar una nueva asignatura
        private void btnAsignatura_Click(object sender, EventArgs e)
        {
            asignarValores();
            datos.insertAsignatura(asignatura, facilitador, calificacion, literal, idtrimestre);
            MessageBox.Show("Asignatura registrada");
            llenarGrid();
            Limpiar();

        }
    }
}
