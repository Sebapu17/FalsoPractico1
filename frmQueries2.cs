using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EjemplosWin
{
    public partial class frmQueries2 : Form
    {
        public frmQueries2()
        {
            InitializeComponent();
        }

        private void btnProcesar2_Click(object sender, EventArgs e)
        {
            if (rbtDelanteros.Checked)
            {
                lstResultados.DataSource =
                    (from valor in Datos.Productos
                     where valor.Puesto == "Delantero"
                     select valor.Nombre + " " + valor.Apellido).ToList();
            }
            if (rbtPorteros.Checked)
            {
                lstResultados.DataSource =
                   (from valor in Datos.Productos
                    where valor.Puesto == "Arquero"
                    select valor.Nombre + " " + valor.Apellido).ToList();
            }
            if (rbdMC.Checked)
            {
                lstResultados.DataSource =
                   (from valor in Datos.Productos
                    where valor.Puesto == "Medio"
                    select valor.Nombre + " " + valor.Apellido).ToList();
            }
            if (rbdDfc.Checked)
            {
                lstResultados.DataSource =
                   (from valor in Datos.Productos
                    where valor.Puesto == "Defensa"
                    select valor.Nombre + " " + valor.Apellido).ToList();
            }

            if (!rbtPorteros.Checked && !rbtDelanteros.Checked && !rbdMC.Checked && !rbdDfc.Checked)
            {
                MessageBox.Show("Seleccione una opcion correcta");
            }

        }
    }

}
