using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEjames.Analizador
{
    class Entero
    {

        RichTextBox TextBox;
        String TextB;
        String cadenaValida;
        private Boolean esCadena;
        private int contador;
        private String cadena;
        private char[] caracteres;
        char comilla = '"';

        public Entero(String TextB, RichTextBox TextBox)
        {
            esCadena = false;
            this.TextBox = TextBox;
            SetCadena(TextB.ToString());
            caracteres = cadena.ToCharArray();

        }
        public void Inicial(String TextB, RichTextBox TextBox)
        {
            this.TextBox = TextBox;
            this.TextB = TextB;
            SetCadena("");
            SetCadena(TextB.ToString());
            caracteres = cadena.ToCharArray();
            contador = 0;
            cadenaValida = "";
            EstadoA();
        }

        public void EstadoA()
        {
            try
            {


                if (contador < cadena.Length)
                {

                    if ( (caracteres[contador].ToString() == "1" ||
                        caracteres[contador].ToString() == "2" ||
                        caracteres[contador].ToString() == "3" ||
                        caracteres[contador].ToString() == "4" ||
                        caracteres[contador].ToString() == "5" ||
                        caracteres[contador].ToString() == "6" ||
                        caracteres[contador].ToString() == "7" ||
                        caracteres[contador].ToString() == "8" ||
                        caracteres[contador].ToString() == "9")||
                        caracteres[contador].ToString() == "0")
                    {
                        cadenaValida += caracteres[contador].ToString();
                        contador++;
                        pintaEntero(cadenaValida);
                        EstadoA();
                        
                    }
                    else
                    {
                        contador++;
                        cadenaValida = "";
                        EstadoA();
                        esCadena = false;
                    }
                }
            }
            catch
            {

            }
        }




        public void SetCadena(String cadena)
        {
            this.cadena = cadena;
        }
        public void pintaEntero(String cadena)
        {
            int pos = TextBox.SelectionStart;
            try
            {
                int INDEX = 0; //'INICIA LA BUSQUEDA DE LA CLAVE DESDE LA POSICION 0 DEL TEXTO
                while (INDEX <= TextBox.Text.LastIndexOf(cadena.ToString() )   ) //'RECORRE TODO EL TEXTO BUSCANDO LA PALABRA CLAVE
                {

                    TextBox.Find(cadena, INDEX, TextBox.TextLength, RichTextBoxFinds.WholeWord); //'CUANDO LA ENCUENTRA LA SELECCIONA Y....
                    TextBox.SelectionColor = Color.Purple; //'... LE PONE EL COLOR INDICADO
                    INDEX = TextBox.Text.IndexOf(cadena, INDEX) + 1; //'AVANZA A LA SIGUIENTE UBICACION DE LA PALABRA CLAVE
                }
                // establece el valor del cursor donde se encontraba antes de pintar la palabra con color
                TextBox.SelectionStart = pos;
                TextBox.SelectionLength = 0;
            }
            catch (Exception ex)
            { }
        }

    }
}
