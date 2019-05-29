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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        EjercicioEntities ej = new EjercicioEntities();

        private void Mostrar()
        {
            dgvDatos.DataSource = ej.Recetas.ToList();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Recetas re = new Recetas();
            re.nombre = txtNombre.Text;
            re.descripcion = txtDes.Text;
            re.origen = txtOrigen.Text;
            ej.Recetas.Add(re);
            ej.SaveChanges();
            MessageBox.Show("Receta agregada correctamente");
            Mostrar();
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            int BorrarId = Convert.ToInt32(txtId.Text);
            using (EjercicioEntities ObjBorrar = new EjercicioEntities())
            {
                Recetas Borrar = (from q in ObjBorrar.Recetas
                                  where q.id == BorrarId
                                  select q).First();
                ObjBorrar.Recetas.Remove(Borrar);
                ObjBorrar.SaveChanges();
                MessageBox.Show("Receta eliminada correctamente");
                Mostrar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Recetas re = new Recetas();
            int filtro = Convert.ToInt32(txtId.Text);
            var update = ej.Recetas.Where(x => x.id == filtro).FirstOrDefault();
            update.nombre = txtNombre.Text;
            update.descripcion = txtDes.Text;
            update.origen = txtOrigen.Text;
            ej.SaveChanges();
            MessageBox.Show("Receta actualizada correctamente");
            Mostrar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "0";
            txtNombre.Text = "";
            txtDes.Text = "";
            txtOrigen.Text = "";
            dgvDatos.DataSource = null;
        }
    }
}
