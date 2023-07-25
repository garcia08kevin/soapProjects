using BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASE_DATOS_RESTFUL_DOTNET_JACOME_LOAIZA_GARCIA_CLIENTE
{
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7272/api/")
            };
            var valor = new RegistroDeposito()
            {
                Cuenta = textBox1.Text,
                importe = Convert.ToDecimal(textBox2.Text)

            };
            var peticion = await client.PostAsJsonAsync("Eureka/registrarDeposito", valor);
            var respuesta = await peticion.Content.ReadAsStringAsync();
            label4.Text = respuesta;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deposito_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
