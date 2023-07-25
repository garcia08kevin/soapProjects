namespace CON_UNI_SOAP_DOTNET_KGARCIA_CLIENTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServiceReference1.ServiceClient serviceClient = new ServiceReference1.ServiceClient();
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

        private void centigradosFahrenheit_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient service = new ServiceReference1.ServiceClient();
            var transformar = service.centigradosAfahrenheitAsync(Convert.ToDouble(numero.Value));
            mostrarNumero.Text = transformar.Result.ToString();
        }

        private void fahrenheitCentigrados_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient service = new ServiceReference1.ServiceClient();
            var transformar = service.fahrenheitAcentigradosAsync(Convert.ToDouble(numero.Value));
            mostrarNumero.Text = transformar.Result.ToString();
        }
    }
}