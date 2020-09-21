using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEjames.Analizador
{
    class boolean
    {

        RichTextBox TextBox;
        String TextB;
        String cadenaValida;
        private Boolean esCadena;
        private int contador;
        private String cadena;


        public boolean(String TextB, RichTextBox TextBox)
        {
            esCadena = false;
            this.TextBox = TextBox;
            SetCadena("");
            SetCadena(TextB.ToString());
        }

        public void Inicio(String TextB, RichTextBox TextBox)
        {
            esCadena = false;
            this.TextBox = TextBox;
            SetCadena("");
            SetCadena(TextB.ToString());
            pintaReservada();
        }

        private void SetCadena(string v)
        {
        }
        public void pintaReservada()
        {
            //guarda la posicion del cursor antes de pintar
            int pos = TextBox.SelectionStart;
            string[] Reservadas = new string[] { "verdadero", "falso" };

            try
            {

                //PONE TODO EL TEXTO EN EL COLOR POR DEFECTO(FORECOLOR)

                TextBox.SelectionStart = 0;
                TextBox.SelectionLength = TextBox.TextLength;


                foreach (string CLAVE in Reservadas)
                { //COMPRUEBA CADA UNA DE LAS PALABRAS CLAVE

                    int INDEX = 0; //'INICIA LA BUSQUEDA DE LA CLAVE DESDE LA POSICION 0 DEL TEXTO

                    while (INDEX <= TextBox.Text.LastIndexOf(CLAVE))
                    {
                        //'RECORRE TODO EL TEXTO BUSCANDO LA PALABRA CLAVE

                        TextBox.Find(CLAVE, INDEX, TextBox.TextLength, RichTextBoxFinds.WholeWord); //'CUANDO LA ENCUENTRA LA SELECCIONA Y....
                        TextBox.SelectionColor = Color.Orange; //'... LE PONE EL COLOR INDICADO
                        INDEX = TextBox.Text.IndexOf(CLAVE, INDEX) + 1; //'AVANZA A LA SIGUIENTE UBICACION DE LA PALABRA CLAVE

                    }

                }

                // establece el valor del cursor donde se encontraba antes de pintar la palabra con color
                TextBox.SelectionStart = pos;
                TextBox.SelectionLength = 0;

            }
            catch (Exception ex)
            {

            }

        }

    }
}
