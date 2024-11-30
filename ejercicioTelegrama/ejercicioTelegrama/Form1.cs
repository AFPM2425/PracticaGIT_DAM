namespace ejercicioTelegrama
{
    /*Se ha desarrollado un módulo que permite calcular el precio de un telegrama en base a los siguientes requisitos: 
•	Los telegramas pueden ser ordinarios o urgentes. 
•	El coste de un telegrama ordinario son 2,5 euros, hasta un máximo de 10 palabras. 
A	partir de ahí, cada palabra adicional tiene un coste de 0,50€. 
•	El coste de un telegrama urgente son 5 euros, hasta un máximo de 10 palabras. 
A	partir de ahí, cada palabra adicional tiene un coste de 0,75€. 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;

            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;

            //Leo el telegrama  
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente? 
            if (rbtnOrdinario.Checked)
            {
                tipoTelegrama = 'o';
            }
            else if (rbtnUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            //Obtengo el número de palabras que forma el telegrama  
            numPalabras = textoTelegrama.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;



            //Si el telegrama es ordinario 
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + ((numPalabras - 10) * 0.5);
                }
            }
            else
            //Si el telegrama es urgente 
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 5;
                    }
                    else
                    {
                        coste = 5 + (0.75 * (numPalabras - 10)); ;
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }

    }
}

