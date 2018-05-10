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
using svcRest; //Most methods are extension methods: due to that, we need the ‘Using svcRest’ statement.

namespace WindowsFormsWebApiClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void cmdAllValues_Click(object sender, EventArgs e)
        {
            SvcRestClient client =
                new SvcRestClient(new Uri("http://localhost/SwaggerWebApp"),
                    new AnonymousCredential());
            var result = client.Values.Get();

            foreach (var x in result)
            {
                MessageBox.Show(x);
            }
        }

        private async void cmdValue_Click(object sender, EventArgs e)
        {
            SvcRestClient client =
                new SvcRestClient(new Uri("http://localhost/SwaggerWebApp"),
                    new AnonymousCredential());
            var result = client.Values.GetByid(1);
            MessageBox.Show(result);
        }

        private async void cmdUpdate_Click(object sender, EventArgs e)
        {
            SvcRestClient client =
                new SvcRestClient(new Uri("http://localhost/SwaggerWebApp"),
                    new AnonymousCredential());
            client.Values.PutByidvalue(1, "New Value");

            MessageBox.Show("Change Completed!");
        }
    }
}
