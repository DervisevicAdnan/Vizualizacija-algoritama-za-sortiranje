using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vizualizacija_algoritama_za_sortiranje
{
    public partial class FormUvodna : Form
    {
        public FormUvodna()
        {
            InitializeComponent();
        }

        private void FormUvodna_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVizualizacijaAlgoritama f = new FormVizualizacijaAlgoritama();
            f.Show();
            Hide();
        }
    }
}
