using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialToy
{
    public delegate void DataReceivedEventHandler(string data);
    public class PortFacade
    {
        System.IO.Ports.SerialPort port;
        public event DataReceivedEventHandler DataReceived;

        public bool IsOpen {
            get {
                return this.port.IsOpen;
            }
        
        }

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

        void port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            this.DataReceived.Invoke(this.port.ReadLine() + Environment.NewLine);
        }

        internal void Close()
        {
            this.port.Close();
        }


    }
}
