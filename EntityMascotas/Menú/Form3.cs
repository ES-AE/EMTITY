using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menú
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        EjercicioEntities ej = new EjercicioEntities();
        private void Mostrar()
        {
            dgvDatos.DataSource = ej.Animales.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Animales An = new Animales();
            An.especie = txtEspecie.Text;
            An.raza = txtRaza.Text;
            An.precio = Convert.ToDecimal(txtPrecio.Text);
            ej.Animales.Add(An);
            ej.SaveChanges();
            MessageBox.Show("Animal agregado correctamente");
            Mostrar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int BorrarId = Convert.ToInt32(txtId.Text);
            using (EjercicioEntities ObjBorrar = new EjercicioEntities())
            {
                Animales Borrar = (from q in ObjBorrar.Animales
                                  where q.id == BorrarId
                                  select q).First();
                ObjBorrar.Animales.Remove(Borrar);
                ObjBorrar.SaveChanges();
                MessageBox.Show("Animal eliminado correctamente");
                Mostrar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Animales re = new Animales();
            int filtro = Convert.ToInt32(txtId.Text);
            var update = ej.Animales.Where(x => x.id == filtro).FirstOrDefault();
            update.especie = txtEspecie.Text;
            update.raza = txtRaza.Text;
            update.precio = Convert.ToDecimal(txtPrecio.Text);
            ej.SaveChanges();
            MessageBox.Show("Animal actualizado correctamente");
            Mostrar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "0";
            txtEspecie.Text = "";
            txtRaza.Text = "";
            txtPrecio.Text = "0.00";
            dgvDatos.DataSource = null;
        }
    }
}
