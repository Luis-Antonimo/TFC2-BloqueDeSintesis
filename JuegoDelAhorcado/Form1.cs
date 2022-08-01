using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDelAhorcado
{
    public partial class Form1 : Form
    {
        private string palabra;
        private char[] chars;
        private char[] chars_;
        private int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bW_Click(object sender, EventArgs e)
        {
            testLetras('w', chars, chars_);
        }

        private void PalabraSecreta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Iniciar_Click(object sender, EventArgs e)
        {        
            if (MessageBox.Show("¿Está seguro de iniciar el juego?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {   
                resetearValores();
                groupBox1.Text = "¡Estás Jugando!";
                MessageBox.Show("Ya puede empezar a escoger letras.\n!Ojo! A los 5 fallos pierdes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Palabras nuevaPalabra = new Palabras();
                palabra = nuevaPalabra.getPalabraSecreta();
                chars = palabra.ToCharArray();
                groupBox2.Text = "La palabra tiene " + chars.Length + " letras.";
                chars_ = new char[chars.Length];              
                for (int i = 0; i < chars_.Length; i++)
                {
                    chars_[i] = '_';
                }
            }
        }

        private void Resolver_Click(object sender, EventArgs e)
        {
            if (palabra == null)
            {
                MessageBox.Show("Aún no se ha generado palabra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult opcion = MessageBox.Show("Si resuelves la palabra perderás el juego. ¿Estás seguro?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (opcion == DialogResult.Yes)
                {
                    MessageBox.Show("La palabra era: " + palabra, "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetearValores();
                }
                else if (opcion == DialogResult.No)
                {
                }
                else if (opcion == DialogResult.Cancel)
                {
                }
            }
        }
        public void testLetras(char caracter, char[] chars, char[] chars_)
        {
            if (palabra == null)
            {
                MessageBox.Show("Aún no se ha generado palabra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Comprobador comprobar = new Comprobador();
                string chars_old = new string(chars_);
                comprobar.comprobarLetra(caracter, chars, chars_);
                //Mostramos en pantalla los cambios
                string str = new string(chars_);
                PalabraSecreta.Text = str;
                if (palabra == str)
                {
                    
                    MessageBox.Show("¡Has acertado!", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetearValores();
                }
                if (chars_old == str)
                {
                    MessageBox.Show("La letra no se encuentra en la palabra.\n¡Has perdido una vida!", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    counter++;
                    Image img = Image.FromFile(counter + ".png");
                    Ahorcado.Image = img;
                    Image imagCorazon = Image.FromFile(counter+"B.png");
                    vidas.Image = imagCorazon;
                    if (counter == 5)
                    {
                        MessageBox.Show("¡Has perdido!\nLa palabra era: " + palabra, "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetearValores();
                    }
                }
            }
        }

        public void resetearValores()
        {    
            counter = 0;
            Image imgInicio = Image.FromFile("0.png");
            Ahorcado.Image = imgInicio;
            Image imagCorazon = Image.FromFile("0B.png");
            vidas.Image = imagCorazon;  
            palabra = null;
            PalabraSecreta.Text = palabra;
            groupBox2.Text = "Palabra secreta";
            groupBox1.Text = "Menú";
            bA.Text = "A"; bB.Text = "B"; bC.Text = "C"; bD.Text = "D";
            bE.Text = "E";bF.Text = "F"; bG.Text = "G";  bH.Text = "H"; bI.Text = "I";
            bJ.Text = "J"; bL.Text = "L"; bM.Text = "M"; bN.Text = "N";  bnn.Text = "Ñ";
            bO.Text = "O";bP.Text = "P"; bQ.Text = "Q"; bR.Text = "R"; bS.Text = "S";
            bT.Text = "T"; bU.Text = "U"; bV.Text = "V"; bW.Text = "W"; bX.Text = "X";
            bY.Text = "Y"; bZ.Text = "Z";
        }


        private void bA_Click(object sender, EventArgs e)
        {
            testLetras('a', chars, chars_);
            bA.Text = null;
        }

        private void bB_Click(object sender, EventArgs e)
        {
            testLetras('b', chars, chars_);
            bB.Text = null;
        }

        private void bC_Click(object sender, EventArgs e)
        {
            testLetras('c', chars, chars_);
            bC.Text = null;
        }

        private void bD_Click(object sender, EventArgs e)
        {
            testLetras('d', chars, chars_);
            bD.Text = null;
        }

        private void bE_Click(object sender, EventArgs e)
        {
            testLetras('e', chars, chars_);
            bE.Text = null;
        }

        private void bF_Click(object sender, EventArgs e)
        {
            testLetras('f', chars, chars_);
            bF.Text = null;
        }

        private void bG_Click(object sender, EventArgs e)
        {
            testLetras('g', chars, chars_);
            bG.Text = null;
        }

        private void bH_Click(object sender, EventArgs e)
        {
            testLetras('h', chars, chars_);
            bH.Text = null;
        }

        private void bI_Click(object sender, EventArgs e)
        {
            testLetras('i', chars, chars_);
            bI.Text = null;
        }

        private void bJ_Click(object sender, EventArgs e)
        {
            testLetras('j', chars, chars_);
            bJ.Text = null;
        }

        private void bK_Click(object sender, EventArgs e)
        {
            testLetras('k', chars, chars_);
            bK.Text = null;
        }

        private void bL_Click(object sender, EventArgs e)
        {
            testLetras('l', chars, chars_);
            bL.Text = null;
        }

        private void bM_Click(object sender, EventArgs e)
        {
            testLetras('m', chars, chars_);
            bM.Text = null;
        }

        private void bN_Click(object sender, EventArgs e)
        {
            testLetras('n', chars, chars_);
            bN.Text = null;
        }

        private void bnn_Click(object sender, EventArgs e)
        {
            testLetras('ñ', chars, chars_);
            bnn.Text = null;
        }

        private void bO_Click(object sender, EventArgs e)
        {
            testLetras('o', chars, chars_);
            bO.Text = null;
        }

        private void bP_Click(object sender, EventArgs e)
        {
            testLetras('p', chars, chars_);
            bP.Text = null;
        }

        private void bQ_Click(object sender, EventArgs e)
        {
            testLetras('q', chars, chars_);
            bQ.Text = null;
        }

        private void bR_Click(object sender, EventArgs e)
        {
            testLetras('r', chars, chars_);
            bR.Text = null;
        }

        private void bS_Click(object sender, EventArgs e)
        {
            testLetras('s', chars, chars_);
            bS.Text = null;
        }

        private void bT_Click(object sender, EventArgs e)
        {
            testLetras('t', chars, chars_);
            bT.Text = null;
        }

        private void bU_Click(object sender, EventArgs e)
        {
            testLetras('u', chars, chars_);
            bU.Text = null;
        }

        private void bV_Click(object sender, EventArgs e)
        {
            testLetras('v', chars, chars_);
            bV.Text = null;
        }

        private void bX_Click(object sender, EventArgs e)
        {
            testLetras('x', chars, chars_);
            bX.Text = null;
        }

        private void bY_Click(object sender, EventArgs e)
        {
            testLetras('y', chars, chars_);
            bY.Text = null;
        }

        private void bZ_Click(object sender, EventArgs e)
        {
            testLetras('z', chars, chars_);
            bZ.Text = null;
        }

        private void Ahorcado_Click(object sender, EventArgs e)
        {

        }

        private void vidas_Click(object sender, EventArgs e)
        {

        }

        private void Ahorcado_Click_1(object sender, EventArgs e)
        {

        }
    }
}
