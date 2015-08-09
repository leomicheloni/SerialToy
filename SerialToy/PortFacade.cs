using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialToy
{
    public delegate void DataReceivedEventHandler(System.IO.Ports.SerialDataReceivedEventArgs e);
    public class PortFacade
    {
        System.IO.Ports.SerialPort port;
        public event DataReceivedEventHandler DataReceived;

        public PortFacade(string portName)
        {
            this.port = new System.IO.Ports.SerialPort(portName);
            this.port.DataReceived += port_DataReceived;
        }

        public void Open()
        {
            this.port.Open();            
        }

        public void Send(string data)
        {
            this.port.Write(data);
        }

        public string OnData()
        {
            return this.port.ReadLine();   
        }

        void port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.DataReceived.Invoke(e);
        }
    }
}
