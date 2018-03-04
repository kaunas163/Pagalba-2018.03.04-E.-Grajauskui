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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var skaicius = 50;
            var forma = new RezultataiForm(skaicius, 20, 8);
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var forma = new KonfLangas())
            {
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    // kintamaji is konf lango galima pasiimti
                    // kaip: forma.Skaicius
                }
            }
        }
    }
}
