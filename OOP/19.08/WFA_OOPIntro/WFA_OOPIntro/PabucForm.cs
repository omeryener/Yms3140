using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOPIntro
{
    public partial class PabucForm : Form
    {
        public PabucForm()
        {
            InitializeComponent();
        }

        private void PabucForm_Load(object sender, EventArgs e)
        {
            Pabuc pabuc = new Pabuc();
            pabuc.Numara = 42;
            pabuc.

            MessageBox.Show(pabuc.Numara.ToString());

        }
    }
}
