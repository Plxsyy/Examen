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

namespace Examen
{
    public partial class FormLista : Form
    {
       

        public FormLista(ArrayList empleados)
        {
            InitializeComponent();
            for (int i = 0; i < empleados.Count; i++)
            {
                string empleado = empleados[i].ToString;
                listView1.Items.Add(empleado);
            }

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string empleado =listView1.SelectedItems.ToString();
            FormDetalles FormDetalles = new FormDetalles(empleado);
            FormDetalles.ShowDialog();
        }
    }
}
