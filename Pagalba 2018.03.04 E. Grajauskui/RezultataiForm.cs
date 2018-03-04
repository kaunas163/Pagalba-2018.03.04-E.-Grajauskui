using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagalba_2018._03._04_E.Grajauskui
{
    public partial class RezultataiForm : Form
    {
        public RezultataiForm()
        {
            InitializeComponent();
        }

        public RezultataiForm(int pirmas, int antras, int trecias)
        {
            InitializeComponent();
            textBox1.Text = pirmas.ToString();
            textBox2.Text = antras.ToString();
        }
    }
}
