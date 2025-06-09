using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class Form1 : Form
    {

        Dictionary<char, int> mapaCriptografia = new Dictionary<char, int>()
            {
                {'A', 10}, {'B', 52}, {'C', 93}, {'D', 49}, {'E', 54}, {'F', 259}, {'G', 825}, {'H', 61}, {'I', 47}, {'J', 333}, {'K', 347}, {'L', 482}, {'M', 29}, {'N', 31}, {'O', 96}, {'P', 231}, {'Q', 799}, {'R', 568}, {'S', 178}, {'T', 873}, {'U', 993}, {'V', 22}, {'W', 76}, {'X', 37}, {'Y', 64}, {'Z', 17},   {' ', 973}
            };

        private const decimal chaveSecreta = 123.456m;
        private const long chaveXOR = 987654321;

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncrip_Click(object sender, EventArgs e)
        {
            string texto = txbn.Text.ToUpper();
            StringBuilder resultadoFinal = new StringBuilder();

            foreach (char c in texto)
            {
                if (mapaCriptografia.ContainsKey(c))
                {
                    int valor = mapaCriptografia[c];

                    // Aplica a chave secreta antes dos cálculos
                    decimal passo1 = (valor * 483m) + chaveSecreta;
                    decimal passo2 = passo1 * passo1;
                    decimal passo3 = passo2 + 312;
                    decimal passo4 = passo3 / 67m;
                    decimal passo5 = (decimal)Math.Sqrt((double)passo4);
                    decimal passo6 = passo5 * 32;
                    decimal passo7 = passo6 + 157;
                    decimal passo8 = passo7 / 3m;
                    decimal passo9 = passo8 * 11;
                    decimal passo10 = passo9 - 812;
                    decimal passo11 = passo10 * passo10;
                    decimal passo12 = passo11 / 97m;
                    decimal passo13 = passo12 + 589;
                    decimal passo14 = passo13 * 1.7m;

                    long resultadoCriptografado = (long)Math.Round(passo14);

                    // Aplica XOR para embaralhar ainda mais
                    resultadoCriptografado ^= chaveXOR;

                    resultadoFinal.Append(resultadoCriptografado.ToString());
                    resultadoFinal.Append(" ");  // separador
                }
                else
                {
                    resultadoFinal.Append("999999999 "); // código para caractere inválido
                }
            }

            txtcrip.Text = resultadoFinal.ToString().Trim();
        }

        private void btndcrip_Click(object sender, EventArgs e)
        {
            Dictionary<int, char> mapaDescriptografia = mapaCriptografia.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);

            string textoCriptografado = txtcrip.Text;
            StringBuilder textoOriginal = new StringBuilder();

            string[] blocos = textoCriptografado.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string bloco in blocos)
            {
                if (!long.TryParse(bloco, out long valorXOR))
                {
                    textoOriginal.Append('?');
                    continue;
                }

                // Reverte XOR
                long valorCriptoOriginal = valorXOR ^ chaveXOR;

                decimal passo14 = valorCriptoOriginal;
                decimal passo13 = passo14 / 1.7m - 589;
                decimal passo12 = passo13 * 97m;
                decimal passo11 = (decimal)Math.Sqrt((double)passo12);
                decimal passo10 = passo11 + 812;
                decimal passo9 = passo10 / 11m;
                decimal passo8 = passo9 * 3m;
                decimal passo7 = passo8 - 157;
                decimal passo6 = passo7 / 32m;
                decimal passo5 = passo6 * passo6;
                decimal passo4 = passo5 * 67m;
                decimal passo3 = passo4 - 312;
                decimal passo2 = (decimal)Math.Sqrt((double)passo3);
                decimal passo1 = (passo2 - chaveSecreta) / 483m;

                int valorInt = (int)Math.Round(passo1);

                if (!mapaDescriptografia.ContainsKey(valorInt))
                {
                    int chaveMaisProxima = mapaDescriptografia.Keys.OrderBy(k => Math.Abs(k - valorInt)).First();
                    if (Math.Abs(chaveMaisProxima - valorInt) <= 1)
                        valorInt = chaveMaisProxima;
                }

                if (mapaDescriptografia.ContainsKey(valorInt))
                    textoOriginal.Append(mapaDescriptografia[valorInt]);
                else
                    textoOriginal.Append('?');
            }

            txtdcrip.Text = textoOriginal.ToString();
        }
    }
}

    
    
    

