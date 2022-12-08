using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8Dezembro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            tela.AppendText("\r\n" + "Pressionei a tecla: " + e.KeyCode);
            tela.AppendText("\r\n" + "\t" + "Código da tecla: " + ((int)e.KeyCode));
        }

      
    }
}
