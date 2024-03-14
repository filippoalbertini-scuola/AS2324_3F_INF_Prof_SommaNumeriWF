namespace AS2324_3F_INF_Prof_SommaNumeriWF
{
    public partial class Form1 : Form
    {
        double somma = 0;
        int nNumeri = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {

            somma += Convert.ToDouble(txtNumero.Text);
            nNumeri += 1;


            lblRisultato.Text = $"Il risultato � {somma}";
            lblNNumeri.Text = $"Il numero di numeri � {nNumeri}";
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double media = somma / (double)nNumeri;

            MessageBox.Show(media.ToString());
        }
    }
}
