using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot2GJBA11w
{
    public partial class frmMenuRobot2GJ : Form
    {
        public frmMenuRobot2GJ()
        {
            InitializeComponent();
        }

        private void btoMenuModeloDeDatos_Click(object sender, EventArgs e)
        {
            frmModeloDeDatos objForm = new frmModeloDeDatos();
            objForm.ShowDialog();
        }
    }
}
