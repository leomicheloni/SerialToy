using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialToy
{
    public partial class Form1 : Form
    {
        PortFacade port;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            var portName = this.txtPortName.Text;
            this.port = new PortFacade(portName);
            this.port.Open();
        }
    }
}
