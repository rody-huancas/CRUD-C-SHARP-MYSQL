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
    public partial class Frm_Unidad_Medida : Form
    {
        public Frm_Unidad_Medida()
        {
            InitializeComponent();
        }

        #region "MIS VARIABLES"

        int nEstadoGuarda = 0;
        int nCodigo_um = 0;

        #endregion


        #region "MIS MÉTODOS"
        private void Formato_um()
        {
            Dgv_medida.Columns[0].Width = 80;
            Dgv_medida.Columns[0].HeaderText = "CÓDIGO";

            Dgv_medida.Columns[1].Width = 250;
            Dgv_medida.Columns[1].HeaderText = "UNIDAD DE MEDIDA";
        }


        private void Listado_um(string cTexto)
        {
            D_UnidadMedida Datos = new D_UnidadMedida();
            Dgv_medida.DataSource = Datos.Listado_um(cTexto);
            this.Formato_um();
        }

        private void Estado_texto(bool lEstado)
        {
            Txt_descripcion_um.ReadOnly = !lEstado;
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
            Txt_descripcion_um.Text = "";
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_medida.CurrentRow.Cells["codigo_um"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo_um = Convert.ToInt32(Dgv_medida.CurrentRow.Cells["codigo_um"].Value);
                Txt_descripcion_um.Text = Convert.ToString(Dgv_medida.CurrentRow.Cells["descripcion_um"].Value);
            }
        }



        #endregion

        private void Frm_Unidad_Medida_Load(object sender, EventArgs e)
        {
            this.Listado_um("%");
            Txt_buscar.TextChanged += Txt_buscar_TextChanged;
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1; //Nuevo registro
            this.Limpia_texto();
            this.Estado_texto(true);
            this.Estado_botones_proceso(true);
            this.Estado_botones_principales(false);
            Txt_descripcion_um.Focus();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            P_UnidadMedida oUm = new P_UnidadMedida();
            oUm.Codigo_um = nCodigo_um;
            oUm.Descripcion_um = Txt_descripcion_um.Text.Trim();


            D_UnidadMedida Datos = new D_UnidadMedida();
            Rpta = Datos.Guardar_um(nEstadoGuarda, oUm);

            if (Rpta.Equals("OK"))
            {
                this.Limpia_texto();
                this.Estado_texto(false);
                this.Estado_botones_proceso(false);
                this.Estado_botones_principales(true);
                this.Listado_um("%");
                nEstadoGuarda = 0;
                nCodigo_um = 0;

                MessageBox.Show("Los datos han sido guardados correctamente.",
                                "Confirmación", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 2; //Actualizar registro
            this.Estado_texto(true);
            this.Estado_botones_proceso(true);
            this.Estado_botones_principales(false);
            Txt_descripcion_um.Focus();
        }

        private void Dgv_medida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (nCodigo_um > 0)
            {
                string Rpta = "";
                D_UnidadMedida Datos = new D_UnidadMedida();
                Rpta = Datos.Eliminar_um(nCodigo_um);
                if (Rpta.Equals("OK"))
                {
                    this.Limpia_texto();
                    this.Listado_um("%");
                    nCodigo_um = 0;
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
            this.Listado_um("%" + Txt_buscar.Text.Trim() + "%");
        }
    }
}
