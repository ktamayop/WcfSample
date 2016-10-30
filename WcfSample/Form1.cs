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
            var service = new Service1Client();
            if (service.Testdb() == 1)  //Testdb is the function in service which is only returning 1
            {
                MessageBox.Show("Hello there");
            }
        }
    }
}
