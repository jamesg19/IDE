using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEjames.Analizador
{
    class Comentario
    {
        RichTextBox TextBox, LogError;
        String TextB;
        String ComentarioValido;
        int NLinea;
        private Boolean esCadena;
        private int contador;
        private String cadena;
        private char[] caracteres;
        char comilla = '"';

        public Comentario(String TextB, RichTextBox TextBox)
        {
            esCadena = false;
            SetCadena(TextB.ToString());
            caracteres = cadena.ToCharArray();
        }

        public void Inicial(String TextB, RichTextBox TextBox,RichTextBox LogError,int NLinea)
        {
            this.TextBox = TextBox;
            this.LogError = LogError;
            this.TextB = TextB;
            this.NLinea = NLinea;
            SetCadena(TextB.ToString());
            caracteres = cadena.ToCharArray();
            contador = 0;
            ComentarioValido = "";
            EstadoSubIn();
        }

        public void EstadoSubIn()
        {
            if (contador < cadena.Length)
            {
                try
                {

                    if (caracteres[contador].ToString() == "/")
                    {
                        ComentarioValido += caracteres[contador].ToString();
                        contador++;
                        EstadoB();
                    }
                    else
                    {
                        contador++;
                        ComentarioValido = "";
                        EstadoSubIn();
                        esCadena = false;

                    }

                }
                catch
                {
                }
            }
        }

        public void EstadoA()
        {
            if (contador < cadena.Length)
            {
                try
                {

                    if (caracteres[contador].ToString() == "*")
                    {
                        ComentarioValido += caracteres[contador].ToString();
                        contador++;
                        EstadoD();
                    }
                    if (caracteres[contador].ToString() == "\n")
                    {
                        ComentarioValido += caracteres[contador].ToString();
                        contador++;
                        EstadoA();
                    }
                    else
                    {
                        ComentarioValido += caracteres[contador].ToString();
                        contador++;           
                        EstadoA();

                        //ComentarioValido = "";
                        //esCadena = false;
                    }
                }
                catch
                {
                }
            }
        }

        public void EstadoB()
        {
            try
            {
                if (contador < cadena.Length)
                {
                    if (caracteres[contador].ToString() == "/")
                    {
                        ComentarioValido += caracteres[contador].ToString();
                        contador++;
                        EstadoC();
                    }
                    if (caracteres[contador].ToString() == "*")
                    {
                        ComentarioValido += caracteres[contador].ToString();
                        contador++;
                        EstadoA();
                        
                    }
                    else
                    {
                        contador++;
                        EstadoSubIn();
                        ComentarioValido = "";
                        finalEstado();
                        esCadena = false;
                    }
                }
            }
            catch
            {

            }
        }

        //estado de aceptacion que finaliza con una comilla
        public void EstadoC()
        {

            try
            {
                if (contador < cadena.Length)
                {

                    if (caracteres[contador].ToString() == "kl")
                    {
                        contador++;
                        EstadoSubIn();
                        ComentarioValido = "";
                        finalEstado();
                        esCadena = false;
                    }
                    else
                    {
                        ComentarioValido += caracteres[contador].ToString();
                        contador++;
                        EstadoC();
                        EstadoF();
                    }
                }
            }
            catch
            {

            }
        }
        //estado de aceptacion que finaliza con una comilla
        public void EstadoF()
        {

            esCadena = true;
            //MessageBox.Show("Es Cadena: "+ ComentarioValido);
            PintaComentario(ComentarioValido);
        }

        public void EstadoD()
        {
            if (contador < cadena.Length)
            {
                try
                {
                    if (caracteres[contador].ToString() == "/")
                    {
                        ComentarioValido += caracteres[contador].ToString();
                        contador++;
                        EstadoE();
                    }
                    else
                    {
                        contador++;
                        ComentarioValido = "";
                        finalEstado();
                        esCadena = false;
                    }
                }
                catch
                {
                }
            }
        }
        public void EstadoE()
        {
            esCadena = true;
            PintaComentario(ComentarioValido);
        }

        public void SetCadena(String cadena)
        {
            this.cadena = cadena;
        }

        public void PintaComentario(String cadena)
        {
            int pos = TextBox.SelectionStart;
            try
            {
                int INDEX = 0; //'INICIA LA BUSQUEDA DE LA CLAVE DESDE LA POSICION 0 DEL TEXTO

                while (INDEX <= TextBox.Text.LastIndexOf(cadena.ToString())) //'RECORRE TODO EL TEXTO BUSCANDO LA PALABRA CLAVE
                {
                    TextBox.Find(cadena, INDEX, TextBox.TextLength, RichTextBoxFinds.WholeWord); //'CUANDO LA ENCUENTRA LA SELECCIONA Y....
                    TextBox.SelectionColor = Color.Red; //'... LE PONE EL COLOR INDICADO
                    INDEX = TextBox.Text.IndexOf(cadena, INDEX) + 1; //'AVANZA A LA SIGUIENTE UBICACION DE LA PALABRA CLAVE
                }
                // establece el valor del cursor donde se encontraba antes de pintar la palabra con color
                TextBox.SelectionStart = pos;
                TextBox.SelectionLength = 0;
                
            }
            catch (Exception ex)
            { }
        }
        public void finalEstado()
        {
            LogError.Text += "Error de token [" + NLinea + "] \n";
        }
    }
}