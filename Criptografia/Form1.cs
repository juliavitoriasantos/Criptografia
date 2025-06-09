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

                    double passo1 = valor * 483;
                    double passo2 = passo1 / 67.0;
                    double passo3 = passo2 + 98;
                    double passo4 = passo3 * 32;
                    double passo5 = passo4 - 7;
                    double passo6 = passo5 * 9;
                    double passo7 = passo6 / 43.0;
                    double passo8 = passo7 * 97;
                    double passo9 = passo8 / 54.0;
                    double passo10 = passo9 + 876;
                    double passo11 = passo10 * 9;
                    double passo12 = passo11 / 2.0;
                   
                  

                    int resultadoCriptografado = (int)Math.Round(passo12);

                    // Força 6 dígitos, por exemplo: 000521
                    resultadoFinal.Append(resultadoCriptografado.ToString("D6"));
                }
                else
                {
                    resultadoFinal.Append("??????");
                }
            }

            txtcrip.Text = resultadoFinal.ToString();
        }

        private void btndcrip_Click(object sender, EventArgs e)
        {
            Dictionary<int, char> mapaDescriptografia = mapaCriptografia.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);

            string textoCriptografado = txtcrip.Text;
            StringBuilder textoOriginal = new StringBuilder();

            for (int i = 0; i <= textoCriptografado.Length - 6; i += 6)
            {
                string bloco = textoCriptografado.Substring(i, 6);

                if (int.TryParse(bloco, out int resultado))
                {
                    
                    double passo11 = resultado * 2.0;
                    double passo10 = passo11 / 9.0;
                    double passo9 = passo10 - 876;
                    double passo8 = passo9 * 54.0;
                    double passo7 = passo8 / 97.0;
                    double passo6 = passo7 * 43.0;
                    double passo5 = passo6 / 9.0;
                    double passo4 = passo5 + 7;
                    double passo3 = passo4 / 32.0;
                    double passo2 = passo3 - 98;
                    double passo1 = passo2 * 67.0;
                    double valorOriginal = passo1 / 483.0;

                    int valorInt = (int)Math.Round(valorOriginal);

                    if (mapaDescriptografia.ContainsKey(valorInt))
                    {
                        textoOriginal.Append(mapaDescriptografia[valorInt]);
                    }
                    else
                    {
                        textoOriginal.Append('?');
                    }
                }
                else
                {
                    textoOriginal.Append('?');
                }
            }

            txtdcrip.Text = textoOriginal.ToString();
        }
    }
    }
    

