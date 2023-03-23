using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Almacen.Presentacion
{
    public partial class Frm_Categorias : Form
    {
        public Frm_Categorias()
        {
            InitializeComponent();
        }


        #region "MIS VARIABLES"

        int nEstadoGuarda = 0;
        int nCodigo_ca = 0;

        #endregion

        #region "MIS MÉTODOS"
        private void Formato_ar()
        {
            Dgv_categorias.Columns[0].Width = 80;
            Dgv_categorias.Columns[0].HeaderText = "CÓDIGO";

            Dgv_categorias.Columns[1].Width = 250;
            Dgv_categorias.Columns[1].HeaderText = "CATEGORÍA";
        }


        private void Listado_ca(string cTexto)
        {
            D_Categorias Datos = new D_Categorias();
            Dgv_categorias.DataSource = Datos.Listado_ca(cTexto);
            this.Formato_ar();
        }

        private void Estado_texto(bool lEstado)
        {
            Txt_descripcion_ca.ReadOnly = !lEstado;
        }

        private void Estado_botones_proceso(bool lEstado)
        {
            Btn_guardar.Visible = lEstado;
            Btn_cancelar.Visible = lEstado;

            //Otros detalles
            Txt_buscar.ReadOnly = lEstado;
        }

        private void Estado_botones_principales(bool lEstado)
        {
            Btn_nuevo.Enabled = lEstado;
            Btn_actualizar.Enabled = lEstado;
            Btn_eliminar.Enabled = lEstado;
            Btn_salir.Enabled = lEstado;
        }

        private void Limpia_texto()
        {
            Txt_descripcion_ca.Text = "";
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_categorias.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo_ca = Convert.ToInt32(Dgv_categorias.CurrentRow.Cells["codigo_ca"].Value);
                Txt_descripcion_ca.Text = Convert.ToString(Dgv_categorias.CurrentRow.Cells["descripcion_ca"].Value);
            }
        }

        #endregion

        private void Frm_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
            Txt_buscar.TextChanged += Txt_buscar_TextChanged;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            P_Categorias oCa = new P_Categorias();
            oCa.Codigo_ca = nCodigo_ca;
            oCa.Descripcion_ca = Txt_descripcion_ca.Text.Trim();
            

            D_Categorias Datos = new D_Categorias();
            Rpta = Datos.Guardar_ca(nEstadoGuarda, oCa);

            if (Rpta.Equals("OK"))
            {
                this.Limpia_texto();
                this.Estado_texto(false);
                this.Estado_botones_proceso(false);
                this.Estado_botones_principales(true);
                this.Listado_ca("%");
                nEstadoGuarda = 0;
                nCodigo_ca = 0;

                MessageBox.Show("Los datos han sido guardados correctamente.",
                                "Confirmación", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1; //Nuevo registro
            this.Limpia_texto();
            this.Estado_texto(true);
            this.Estado_botones_proceso(true);
            this.Estado_botones_principales(false);
            Txt_descripcion_ca.Focus();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 2; //Actualizar registro
            this.Estado_texto(true);
            this.Estado_botones_proceso(true);
            this.Estado_botones_principales(false);
            Txt_descripcion_ca.Focus();
        }

        private void Dgv_categorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (nCodigo_ca > 0)
            {
                string Rpta = "";
                D_Categorias Datos = new D_Categorias();
                Rpta = Datos.Eliminar_ar(nCodigo_ca);
                if (Rpta.Equals("OK"))
                {
                    this.Limpia_texto();
                    this.Listado_ca("%");
                    nCodigo_ca = 0;
                    MessageBox.Show("Registro eliminado correctamente",
                                    "Confirmación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se tiene seleccionado ningún registro.",
                                    "Aviso del sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            this.Listado_ca("%" + Txt_buscar.Text.Trim() + "%");
        }
    }
}
