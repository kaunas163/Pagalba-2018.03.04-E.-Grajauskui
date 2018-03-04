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
    public partial class KonfLangas : Form
    {
        public int Skaicius { get; set; }

        public KonfLangas()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Skaicius = Convert.ToInt32(textBox1.Text);
        }
    }
}
