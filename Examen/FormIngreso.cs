using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static Examen.FormIngreso;

namespace Examen
{
    public partial class FormIngreso : Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }

            public static ArrayList empleados = new ArrayList();

        
        public abstract class Empleado
        {
            protected Empleado() { }
            public string nombreCompleto;
            public string departamento;
            public int edad;

        }
        public class EmpleadoInformatico : Empleado
        {
            
            string lenguajesDeProgramacion;

            public EmpleadoInformatico(string nombre, string departamento, int edad, string lenguajesDeProgramacion)
            {
                this.nombreCompleto = nombre;
                this.departamento= departamento;
                this.edad = edad;
                this.lenguajesDeProgramacion = lenguajesDeProgramacion;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string lenguajesDeProgramacion = "";
            if (checkBoxHTML.Checked)
            {
                lenguajesDeProgramacion += checkBoxHTML.Text;
                lenguajesDeProgramacion += ",";
            } else if (checkBoxCSS.Checked) {
                lenguajesDeProgramacion += checkBoxCSS.Text;
                lenguajesDeProgramacion += ",";
            } else if (checkBoxC.Checked) {
                lenguajesDeProgramacion += checkBoxC.Text;
                lenguajesDeProgramacion += ",";
            }
            string departamento = comboBoxDepartamento.Text;
            int edad = Int32.Parse(maskedTextBoxEdad.Text);
            Empleado empleado = new EmpleadoInformatico(textBoxNombre.Text, departamento, edad, lenguajesDeProgramacion);
            empleados.Add(empleado);
    }
           

        private void buttonVerLista_Click_1(object sender, EventArgs e)
        {
            FormLista FormLista = new FormLista(empleados);
            FormLista.ShowDialog();
        }
    }
}
