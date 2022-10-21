using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace csharp_firebase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IFirebaseConfig fn = new FirebaseConfig()
        {
            AuthSecret = "f0pd9vvcSFH7DKXiEL2vUlMEQVcahNJmQ81jmaE5",
            BasePath = "https://cfiregithub-default-rtdb.firebaseio.com/",
        };
        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fn);

            }
            catch (Exception)
            {
                MessageBox.Show("Error Connecting to Server");
            }
        }

        private void bt_ınsert_Click(object sender, EventArgs e)
        {
            fireclass fr = new fireclass()
            {
                name = tx_name.Text,
                password = tx_pass.Text
            };

            var setdata = client.Set("Firesharp/" + tx_name.Text, fr);
            MessageBox.Show("Data İnstertd");
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            var result = client.Get("Firesharp/" + tx_name.Text);
            fireclass fr = result.ResultAs<fireclass>();
            tx_name.Text = fr.name;
            tx_pass.Text = fr.password;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            fireclass fr = new fireclass()
            {
                name = tx_name.Text,
                password = tx_pass.Text
            };


            var updata = client.Update("Firesharp/" + tx_name.Text, fr);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            var deldataa = client.Delete("Firesharp/" + tx_name.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list_all.Items.Clear();
            FirebaseResponse all = client.Get(@"Firesharp");
            Dictionary<string, fireclass> veri = JsonConvert.DeserializeObject<Dictionary<string, fireclass>>(all.Body.ToString());
            foreach (var item in veri)
            {
                //dataGridView1.Rows.Add(item.Value.nickname, item.Value.message);
                list_all.Items.Add(item.Value.name + ": " + item.Value.password);
            }
        }
    }
}
