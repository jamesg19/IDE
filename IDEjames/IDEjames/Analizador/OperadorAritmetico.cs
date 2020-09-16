using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEjames.Analizador
{
    class OperadorAritmetico
    {
        RichTextBox TextBox;
        String TextB;
        String cadenaValida;
        private Boolean esCadena;
        private int contador;
        private String cadena;
        private char[] caracteres;
        char comilla = '"';

        public OperadorAritmetico(String TextB, RichTextBox TextBox)
        {
            esCadena = false;

            SetCadena(TextB.ToString());
            caracteres = cadena.ToCharArray();

        }

        public void Inicial(String TextB, RichTextBox TextBox)
        {
            this.TextBox = TextBox;
            this.TextB = TextB;
            SetCadena(TextB.ToString());
            caracteres = cadena.ToCharArray();
            contador = 0;
            cadenaValida = "";
            EstadoA();
        }

        public void EstadoA()
        {
            if (contador < cadena.Length)
            {
                try
                {

                    if (caracteres[contador].ToString() == "+"||
                        caracteres[contador].ToString() == "-")
                    {

                        cadenaValida += caracteres[contador].ToString();
                        contador++;

                        EstadoB();

                    }
                    else if(caracteres[contador].ToString() == "*" ||
                            caracteres[contador].ToString() == "/")
                    {
                        cadenaValida += caracteres[contador].ToString();
                        contador++;
                        EstadoC();

                    }
                    else
                    {
                        esCadena = false;
                        return;
                        cadenaValida = "";
                    }
                }
                catch { }
            }

        }


        public void EstadoB()
        {
            if (contador < cadena.Length)
            {

                if (caracteres[contador].ToString() == "+" || caracteres[contador].ToString() == "-"||caracteres[contador].ToString() == " ")
                {
                    cadenaValida += caracteres[contador].ToString();
                    contador++;
                    EstadoC();
                }
                else if (caracteres[contador].ToString() == "\n"||
                        caracteres[contador].ToString() == "*" ||
                        caracteres[contador].ToString() == "/")
                {
                    esCadena = false;
                    return;
                    cadenaValida = "";
                }

            }
        }
        //estado de aceptacion 
        public void EstadoC()
        {
            if (contador < cadena.Length)
            {

                if (caracteres[contador].ToString() != "+" || 
                    caracteres[contador].ToString() != "-"||
                    caracteres[contador].ToString() != "*" ||
                    caracteres[contador].ToString() != "/" 
                    )
                {
                    cadenaValida += caracteres[contador].ToString();
                    contador++;
                    EstadoD();
                }
                if (caracteres[contador].ToString() == "\n")
                {
                    esCadena = false;
                    return;
                    cadenaValida = "";
                }
            }

        }

        public void EstadoD()
        {
            if (contador < cadena.Length)
            {

           
            }
        }

        public void SetCadena(String cadena)
        {
            this.cadena = cadena;
        }




        public void pintaCadena(String cadena)
        {
            int pos = TextBox.SelectionStart;
            try
            {
                int INDEX = 0; //'INICIA LA BUSQUEDA DE LA CLAVE DESDE LA POSICION 0 DEL TEXTO


                TextBox.Find(cadena, INDEX, TextBox.TextLength, RichTextBoxFinds.WholeWord); //'CUANDO LA ENCUENTRA LA SELECCIONA Y....
                TextBox.SelectionColor = Color.Gray; //'... LE PONE EL COLOR INDICADO
                INDEX = TextBox.Text.IndexOf(cadena, INDEX) + 1; //'AVANZA A LA SIGUIENTE UBICACION DE LA PALABRA CLAVE

                // establece el valor del cursor donde se encontraba antes de pintar la palabra con color
                TextBox.SelectionStart = pos;
                TextBox.SelectionLength = 0;

            }
            catch (Exception ex)
            { }
        }


    }
}
