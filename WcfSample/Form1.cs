using System;
using System.Windows.Forms;
using WcfSample.ServiceReference1;

namespace WcfSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create a service client.
            var service = new Service1Client();

            //test the connection and is succedes show a message.
            if (service.Testdb() == 1) 
                MessageBox.Show("Hello there");
        }
    }
}
