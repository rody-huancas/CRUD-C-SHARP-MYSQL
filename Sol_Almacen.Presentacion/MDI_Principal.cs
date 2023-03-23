using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Almacen.Presentacion
{
    public partial class MDI_Principal : Form
    {
        private int childFormNumber = 0;
        //Instanciar forms
        Frm_articulos Frm_ar;
        Frm_Categorias Frm_ca;
        Frm_Unidad_Medida Frm_um;

        public MDI_Principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Menu_Articulos_Click(object sender, EventArgs e)
        {
            if (Frm_ar == null)
            {
                Frm_ar = new Frm_articulos();
                Frm_ar.MdiParent = this;
                Frm_ar.FormClosed += new FormClosedEventHandler(Alta_Frm_ar);
                Frm_ar.Show();
            }
            else
            {
                Frm_ar.Activate();
            }
        }

        void Alta_Frm_ar(object sender, EventArgs e)
        {
            Frm_ar = null;
        }

        private void Menu_Categorias_Click(object sender, EventArgs e)
        {
            if (Frm_ca == null)
            {
                Frm_ca = new Frm_Categorias();
                Frm_ca.MdiParent = this;
                Frm_ca.FormClosed += new FormClosedEventHandler(Alta_Frm_ca);
                Frm_ca.Show();
            }
            else
            {
                Frm_ca.Activate();
            }
        }

        void Alta_Frm_ca(object sender, EventArgs e)
        {
            Frm_ca = null;
        }

        private void Menu_Medida_Click(object sender, EventArgs e)
        {
            if (Frm_um == null)
            {
                Frm_um = new Frm_Unidad_Medida();
                Frm_um.MdiParent = this;
                Frm_um.FormClosed += new FormClosedEventHandler(Alta_Frm_um);
                Frm_um.Show();
            }
            else
            {
                Frm_um.Activate();
            }
        }

        void Alta_Frm_um(object sender, EventArgs e)
        {
            Frm_um = null;
        }

        private void Menu_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDI_Principal_Load(object sender, EventArgs e)
        {
            /*foreach (Control control in this.Controls)
            {
                MdiClient mdiClient = control as MdiClient;
                if (mdiClient != null)
                {
                    mdiClient.BackColor = Color.FromArgb(255, 255, 255); // color blanco
                    break;
                }
            }

            timerHora.Interval = 1000;
            timerHora.Enabled = true;

            Lb_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");*/
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            //Lb_Hora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void MDI_Principal_Resize(object sender, EventArgs e)
        {
            /*int x = (this.ClientSize.Width - Lb_Hora.Width) / 2;
            int y = (this.ClientSize.Height - Lb_Hora.Height - Lb_Fecha.Height) / 2;
            Lb_Hora.Location = new Point(x, y); 
            Lb_Fecha.Location = new Point(x, y + Lb_Hora.Height);*/
        }
    }
}
