﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEjames.Analizador
{
    class OperadorLogic
    {
        RichTextBox TextBox;
        String TextB;
        String cadenaValida;
        private Boolean esCadena;
        private int contador;
        private String cadena;
        private char[] caracteres;
        

        public OperadorLogic(String TextB, RichTextBox TextBox)
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
            cadenaValida = null;
            EstadoA();
        }
        public void EstadoA()
        {
            try
            {

            //MessageBox.Show("letra: " + caracteres[contador].ToString());
            if (caracteres[contador].ToString() == "|")
            {
            cadenaValida += caracteres[contador].ToString();
            contador++;

            EstadoB();

            }

            if (caracteres[contador].ToString() == "&")
            {
            cadenaValida += caracteres[contador].ToString();
            contador++;

             EstadoC();

            }
                if (caracteres[contador].ToString() == "!")
                {
                    cadenaValida += caracteres[contador].ToString();
                    EstadoD();
                }
                else
                {
                    contador++;
                    cadenaValida = "";
                    EstadoA();
                    esCadena = false;
                    return;
                }
            }
            catch { }
        }

        public void EstadoB()
        {
            try
            {
                if (contador < cadena.Length)
                {
                    if (caracteres[contador].ToString() == "|")
                    {
                        cadenaValida += caracteres[contador].ToString();
                        EstadoE();
                    }
                    else
                    {
                        contador++;
                        cadenaValida = "";
                        EstadoA();
                        esCadena = false;
                        return;
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
                    if (caracteres[contador].ToString() == "&")
                    {
                        cadenaValida += caracteres[contador].ToString();
                        contador++;
                        EstadoE();
                    }
                    else
                    {
                        contador++;
                        cadenaValida = "";
                        EstadoA();
                        esCadena = false;
                        return;
                    }
                }
            }
            catch
            {

            }
        }

        public void EstadoD()
        {
            try
            {
                esCadena = true;
                //MessageBox.Show("Es Cadena: "+ ComentarioValido);
                PintaOperadorL(cadenaValida);

            }
            catch
            {

            }

        }
        public void EstadoE()
        {
            try
            {
                esCadena = true;
                PintaOperadorL(cadenaValida);
            }
            catch
            {

            }
        }

        public void SetCadena(String cadena)
        {
            this.cadena = cadena;
        }

        public void PintaOperadorL(String cadena)
        {
            int pos = TextBox.SelectionStart;
            try
            {
                int INDEX = 0; //'INICIA LA BUSQUEDA DE LA CLAVE DESDE LA POSICION 0 DEL TEXTO

                while (INDEX <= TextBox.Text.LastIndexOf(cadena.ToString())) //'RECORRE TODO EL TEXTO BUSCANDO LA PALABRA CLAVE
                {

                    TextBox.Find(cadena.ToString(), INDEX, TextBox.TextLength, RichTextBoxFinds.WholeWord); //'CUANDO LA ENCUENTRA LA SELECCIONA Y....
                    TextBox.SelectionColor = Color.Blue; //'... LE PONE EL COLOR INDICADO
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
