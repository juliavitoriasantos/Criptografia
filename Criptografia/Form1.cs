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
                {'A', 10}, {'B', 52}, {'C', 93}, {'D', 49}, {'E', 54}, {'F', 259}, {'G', 825}, {'H', 61}, {'I', 47}, {'J', 333}, {'L', 482}, {'M', 29}, {'N', 31}, {'O', 96}, {'P', 231}, {'Q', 799}, {'R', 568}, {'S', 178}, {'T', 873}, {'U', 993}, {'V', 22}, {'W', 76}, {'X', 37}, {'Y', 64}, {'Z', 17}
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
            string texto = txbn.Text.ToUpper(); // converte para maiúsculas
            List<string> resultados = new List<string>();

            foreach (char c in texto)
            {
                if (mapaCriptografia.ContainsKey(c))
                {
                    int valor = mapaCriptografia[c];

                    // Aplica a fórmula:
                    // ((valor * 7) + 9) / 3 * 8

                    double passo1 = valor * 7;
                    double passo2 = passo1 + 9;
                    double passo3 = passo2 / 3.0;
                    double passo4 = passo3 * 8;

                    // Arredondar Resultado
                    int resultadoFinal = (int)Math.Round(passo4);

                    resultados.Add(resultadoFinal.ToString());
                }
                else
                {
                    resultados.Add("??"); // para caracteres que não existem no dicionário
                }
            }

            // Junta resultados separados por hífen
            txtcrip.Text = string.Join("-", resultados);
        }

        private void btndcrip_Click(object sender, EventArgs e)
        {
            // Criar dicionário inverso valor → letra para facilitar busca
            Dictionary<int, char> mapaDescriptografia = new Dictionary<int, char>();
            foreach (var par in mapaCriptografia)
            {
                mapaDescriptografia[par.Value] = par.Key;
            }

            string textoCriptografado = txtcrip.Text;
            string[] valores = textoCriptografado.Split('-');

            StringBuilder textoOriginal = new StringBuilder();

            foreach (string valStr in valores)
            {
                if (int.TryParse(valStr, out int resultado))
                {
                    // Aplica fórmula inversa para achar o valor original
                    double valorOriginal = (3.0 * (resultado / 8.0) - 9) / 7.0;

                    // Arredonda para o inteiro mais próximo (pois o valor original era inteiro)
                    int valorInt = (int)Math.Round(valorOriginal);

                    if (mapaDescriptografia.ContainsKey(valorInt))
                    {
                        textoOriginal.Append(mapaDescriptografia[valorInt]);
                    }
                    else
                    {
                        textoOriginal.Append('?'); // valor não encontrado no mapa
                    }
                }
                else
                {
                    textoOriginal.Append('?'); // valor inválido
                }
            }

            txtdcrip.Text = textoOriginal.ToString();
        }
    }
    
}
