using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace CON_UNI_SOAP_DOTNET_KGARCIA_CLIENTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void centigradosFahrenheit_Click(object sender, EventArgs e)
        {
            mostrarNumero.Text = string.Empty;
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7213/api/")
            };

            var peticion = await client.GetAsync($"TranformUnidades/centigradosAfahrenheit?centigrados={Convert.ToDouble(numero.Value)}");
            var respuesta = await peticion.Content.ReadAsStringAsync();
            mostrarNumero.Text = respuesta;
        }

        private async void fahrenheitCentigrados_Click(object sender, EventArgs e)
        {
            mostrarNumero.Text = string.Empty;
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7213/api/")
            };

            var peticion = await client.GetAsync($"TranformUnidades/fahrenheitAcentigrados?fahrenheit={Convert.ToDouble(numero.Value)}");
            var respuesta = await peticion.Content.ReadAsStringAsync();
            mostrarNumero.Text = respuesta;
        }
    }
}