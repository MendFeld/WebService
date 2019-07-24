using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MyWebService.CalcServiceSoapClient client = new MyWebService.CalcServiceSoapClient();
            txtResult.Text = client.Add(Convert.ToDecimal(txtA.Text),Convert.ToDecimal(txtB.Text)).ToString();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            MyWebService.CalcServiceSoapClient client = new MyWebService.CalcServiceSoapClient();
            txtResult.Text = client.Sub(Convert.ToDecimal(txtA.Text), Convert.ToDecimal(txtB.Text)).ToString();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            MyWebService.CalcServiceSoapClient client = new MyWebService.CalcServiceSoapClient();
            txtResult.Text = client.Mul(Convert.ToDecimal(txtA.Text), Convert.ToDecimal(txtB.Text)).ToString();
        }

        private void BtnDev_Click(object sender, EventArgs e)
        {
            MyWebService.CalcServiceSoapClient client = new MyWebService.CalcServiceSoapClient();
            txtResult.Text = client.Div(Convert.ToDecimal(txtA.Text), Convert.ToDecimal(txtB.Text)).ToString();
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            MyWebService.CalcServiceSoapClient client = new MyWebService.CalcServiceSoapClient();
            MessageBox.Show(client.Message(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
