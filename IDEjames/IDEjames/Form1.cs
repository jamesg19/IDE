using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IDEjames
{
    public partial class Form1 : Form
    {
        string archivo;
        String variableprueba;
        Archivo archivoObjeto = new Archivo("");

        public Form1()
        {
            InitializeComponent();

            pintar();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //move location of numberLabel for amount 
            //of pixels caused by scrollbar
            int d = TextBox.GetPositionFromCharIndex(0).Y % (TextBox.Font.Height + 1);
            numberLabel.Location = new Point(0, d);

            updateNumberLabel();
            
        }


        //boton para abrir un nuevo archivo
        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // llama al metodo abrir de la clase archivo 
            archivoObjeto.AbrirArchivo(TextBox);
        }

        //boton para guardar un archivo
        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // llama al metodo guardar de la clase archivo 
            archivoObjeto.GuardaArchivo(TextBox);
        }
        //metodo para crear nuevo archivo
        private void NuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // llama al metodo Nuevo Archivo de la clase archivo 
            // y crea un nuevo archivo
            archivoObjeto.NuevoArchivo(TextBox);
        }




        //metodo para actualizar el numero de linea
        private void updateNumberLabel()
        {
            //we get index of first visible char and 
            //number of first visible line
            Point pos = new Point(0, 0);
            int firstIndex = TextBox.GetCharIndexFromPosition(pos);
            int firstLine = TextBox.GetLineFromCharIndex(firstIndex);

            //now we get index of last visible char 
            //and number of last visible line
            pos.X = ClientRectangle.Width;
            pos.Y = ClientRectangle.Height;
            int lastIndex = TextBox.GetCharIndexFromPosition(pos);
            int lastLine = TextBox.GetLineFromCharIndex(lastIndex);

            //this is point position of last visible char, we'll 
            //use its Y value for calculating numberLabel size
            pos = TextBox.GetPositionFromCharIndex(lastIndex);

            //finally, renumber label
            numberLabel.Text = "";
            for (int i = firstLine; i <= lastLine + 1; i++)
            {
                numberLabel.Text += i + 1 + "\n";
            }

        }

        private void TextBox_VScrollChanged(object sender, EventArgs e)
        {
            //move location of numberLabel for amount 
            //of pixels caused by scrollbar
            int d = TextBox.GetPositionFromCharIndex(0).Y %
                                      (TextBox.Font.Height + 1);
            numberLabel.Location = new Point(0, d);

            updateNumberLabel();
        }

        //Salir
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            this.Dispose();
        }


        string[] Reservadas = new string[] { "entero", "decimal","cadena","booleano","caracter"};
        public void pintar()
        {
            //this.TextBox.TextChanged += (ob, ev) =>
            //{

            //    var palabras = this.TextBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    var resultado = from b in Reservadas
            //                    from c in palabras
            //                    where c == b
            //                    select b;

            //    String palabra = TextBox.Text;

            //        int inicio = 0;
            //        foreach (var item in resultado)
            //        {



            //            try
            //            {


            //                inicio = this.TextBox.Text.IndexOf(item, inicio);
            //                this.TextBox.Select(inicio, item.Length);
            //                this.TextBox.SelectionColor = Color.Red;
            //                this.TextBox.SelectionStart = this.TextBox.Text.Length;
            //                inicio++;
            //            }
            //            catch (Exception ex)
            //            {

            //            }

            //        }
                


            //    this.TextBox.SelectionColor = Color.Black;
            //    this.TextBox.SelectionStart = this.TextBox.Text.Length;

            //};
        }









    }

}
