using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEjames.Analizador
{
    class DatosPrimitivo
    {
        RichTextBox TextBox;
        String TextB;
        String cadenaValida;
        private Boolean esCadena;
        private int contador;
        private String cadena;
        private char[] caracteres;
        char comilla = '"';
        
        public DatosPrimitivo(String TextB,RichTextBox TextBox)
        {
            esCadena = false;

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
            try { 

            if (contador < cadena.Length)
            {
                
                if (caracteres[contador].ToString()=="c")
                {
                    contador++;
                    if (caracteres[contador].ToString() == "a")
                    {
                        contador++;
                        if (caracteres[contador].ToString() == "d")
                        {
                            contador++;
                            if (caracteres[contador].ToString() == "e")
                            {
                                contador++;
                                if (caracteres[contador].ToString() == "n")
                                {
                                    contador++;
                                    if (caracteres[contador].ToString() == "a")
                                    {
                                        contador++;
                                            if (caracteres[contador].ToString() == " ")
                                            {
                                                contador++;
                                                if (caracteres[contador].ToString() == "=")
                                                {
                                                    contador++;
                                                    if (caracteres[contador].ToString() == " " )
                                                    {
                                                        contador++;
                                                        pimitivo();

                                                    }
                                                    else { error(); }

                                                }
                                                else { error(); }

                                            }
                                            else { error(); }

                                        }
                                        else { error(); }

                                }else { error(); }

                            }else { error(); }
                        }else { error(); }
                    }else { error(); }
                }else { error(); }
                    pimitivo();
            }
            }
                catch { }
        }
        public void pimitivo()
        {
            try
            {
                //MessageBox.Show("letra: " + caracteres[contador].ToString());
                if (caracteres[contador].ToString() == comilla.ToString())
                {
                    cadenaValida += caracteres[contador].ToString();
                    contador++;

                    EstadoB();

                }
                else
                {
                    contador++;
                    EstadoA();

                }
            }
            catch
            {

            }
        }

        public void EstadoB()
        {
            if (contador < cadena.Length)
            {
                
                if (caracteres[contador].ToString() == comilla.ToString() )
                {
                    cadenaValida += caracteres[contador].ToString();
                    contador++;
                    EstadoC();
                }
                if(caracteres[contador].ToString() =="\n")
                {
                    esCadena = false;

                }
                else
                {
                   
                    cadenaValida += caracteres[contador].ToString();
                    contador++;
                    EstadoD();
                }
            }
        }
        //estado de aceptacion que finaliza con una comilla
        public void EstadoC()
        {
                
                esCadena = true;
                //MessageBox.Show("Es Cadena: "+ ComentarioValido);
                pintaCadena(cadenaValida);
                
            
        }

        public void EstadoD()
        {
            if (contador < cadena.Length)
            {

                try
                {
                    if (caracteres[contador].ToString() == comilla.ToString())
                    {
                        cadenaValida += caracteres[contador].ToString();
                        contador++;
                        EstadoC();
                    }
                    if (caracteres[contador].ToString() == "\n")
                    {
                        esCadena = false;

                    }

                    else
                    {
                        cadenaValida += caracteres[contador].ToString();
                        contador++;
                        EstadoB();
                    }
                }
                catch { 
                }
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

                while (INDEX <= TextBox.Text.LastIndexOf(cadena.ToString())) //'RECORRE TODO EL TEXTO BUSCANDO LA PALABRA CLAVE
                {
                    TextBox.Find(cadena, INDEX, TextBox.TextLength, RichTextBoxFinds.WholeWord); //'CUANDO LA ENCUENTRA LA SELECCIONA Y....
                    TextBox.SelectionColor = Color.Gray; //'... LE PONE EL COLOR INDICADO
                    INDEX = TextBox.Text.IndexOf(cadena, INDEX) + 1; //'AVANZA A LA SIGUIENTE UBICACION DE LA PALABRA CLAVE
                }
                // establece el valor del cursor donde se encontraba antes de pintar la palabra con color
                TextBox.SelectionStart = pos;
                TextBox.SelectionLength = 0;

            }
            catch (Exception ex)
            { }
        }
        public void error()
        {
            cadenaValida = "";
            esCadena = false;

        }

    }
}
