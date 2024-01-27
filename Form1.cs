using System;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string jsonconf = Application.StartupPath.ToString() + "\\updater.conf";
            if (File.Exists(jsonconf))
            {
                string confjson = File.ReadAllText(jsonconf);
                var datajson = new JavaScriptSerializer().Deserialize<dynamic>(confjson);
                textBox1.Text = datajson["start_ip"];
                textBox2.Text = datajson["stop_ip"];
                checkBox1.Checked = datajson["update_on_match"];
                checkBox2.Checked = datajson["update_folder"];
                label1.Text = datajson["streams"].ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
