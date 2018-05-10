using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libTools;
using SwaggerWebProxy;
using SwaggerWebProxy.Models;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdValue_Click(object sender, EventArgs e)
        {
            SwaggerWebProxyClient proxyClient =
                new SwaggerWebProxyClient(new Uri("http://localhost/SwaggerWebApp"),
                    new AnonymousCredential());
            var result = proxyClient.Values.GetByid(1);
            MessageBox.Show(result.Value);
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            SwaggerWebProxyClient proxyClient =
                new SwaggerWebProxyClient(new Uri("http://localhost/SwaggerWebApp"),
                    new AnonymousCredential());
            proxyClient.Values.PutByidvalue(1, new ValueObj("New Value"));

            MessageBox.Show("Change Completed!");
        }

        public async void cmdAllValues_Click(object sender, EventArgs e)
        {
            SwaggerWebProxyClient proxyClient =
                new SwaggerWebProxyClient(new Uri("http://localhost/SwaggerWebApp"),
                    new AnonymousCredential());
            var result = proxyClient.Values.Get();
            var output = new StringBuilder();
            foreach (var x in result)
            {
                output.AppendLine(x.Value);
            }
            MessageBox.Show(output.ToString());
        }
    }
}
