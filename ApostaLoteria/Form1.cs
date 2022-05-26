namespace ApostaLoteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int[] num = new int[6];
            bool saida = true;
            do
            {

                for (int i = 0; i < num.Length; i++)
                {
                    int dezena = new Random().Next(1, 61);
                    num[i] = dezena;

                }

                var meuHashSet = new HashSet<int>(num);
                var valoresRepetidos = num.Length - meuHashSet.Count;

                saida = valoresRepetidos > 0 ? true : false;



            } while (saida);


            txtboxResultado.Text = ($"{num[0]}, {num[1]}, {num[2]}, {num[3]}, {num[4]}, {num[5]} ").ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}