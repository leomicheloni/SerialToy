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

            this.cmbPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtData.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtData.Text = text + this.txtData.Text;
            }
        }
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (this.port == null)
            {
                this.OpenPort();
            }
            else
            {
                if (this.port.IsOpen)
                {
                    this.port.Close();
                    this.btnOpenPort.Text = "Open";
                }
                else
                {
                    this.port.Open();
                    this.btnOpenPort.Text = "Close";

                }
            }
        }

        private void OpenPort()
        {
            try
            {
                var portName = this.cmbPorts.Text;
                this.port = new PortFacade(portName);
                this.port.DataReceived += port_DataReceived;
                this.port.Open();
                this.btnOpenPort.Text = "Close";
                this.cmbPorts.Enabled = false;
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void port_DataReceived(string data)
        {
            SetText(data);
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            this.port.Send(this.txtDataToSend.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.port.Close();
        }
    }
}
