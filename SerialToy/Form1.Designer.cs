namespace SerialToy
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.txtDataToSend = new System.Windows.Forms.TextBox();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(200, 37);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPort.TabIndex = 2;
            this.btnOpenPort.Text = "Open port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(566, 35);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 23);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "Send";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // txtDataToSend
            // 
            this.txtDataToSend.Location = new System.Drawing.Point(393, 39);
            this.txtDataToSend.Name = "txtDataToSend";
            this.txtDataToSend.Size = new System.Drawing.Size(167, 20);
            this.txtDataToSend.TabIndex = 4;
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(69, 36);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(121, 21);
            this.cmbPorts.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.AcceptsReturn = true;
            this.txtData.Location = new System.Drawing.Point(32, 76);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(609, 331);
            this.txtData.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 431);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cmbPorts);
            this.Controls.Add(this.txtDataToSend);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Serial Toy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox txtDataToSend;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.TextBox txtData;
    }
}

