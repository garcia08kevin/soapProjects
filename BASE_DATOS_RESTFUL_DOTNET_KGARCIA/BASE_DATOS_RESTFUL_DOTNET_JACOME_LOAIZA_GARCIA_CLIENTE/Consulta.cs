using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASE_DATOS_RESTFUL_DOTNET_JACOME_LOAIZA_GARCIA_CLIENTE
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7272/api/")
            };
            var peticion = await client.GetAsync($"Eureka/GetMovimientos?cuenta={textBox1.Text}");
            var respuesta = await peticion.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<JsonResult>>(respuesta);

            dataGridView1.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
