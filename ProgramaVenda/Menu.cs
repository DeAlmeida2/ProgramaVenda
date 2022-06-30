using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaVenda
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void abrirFormHija(object formhija)
        {
            if (this.panel_Menu.Controls.Count > 0)
                this.panel_Menu.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_Menu.Controls.Add(fh);
            this.panel_Menu.Tag = fh;
            fh.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormHija(new CadProduto());
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel_MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Vendas_Click(object sender, EventArgs e)
        {
            {
                abrirFormHija(new ItemVendaCliente());
            }
        }

        private void button_Clientes_Click(object sender, EventArgs e)
        {
            abrirFormHija(new CadCliente());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
