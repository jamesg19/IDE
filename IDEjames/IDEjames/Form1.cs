using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms; 


namespace IDEjames
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")] static extern Int32 LockWindowUpdate();

        string archivo;
        String variableprueba;
        Archivo archivoObjeto = new Archivo("");
        //Private Declare Function LockWindowUpdate Lib "user32" (ByVal hWnd As Integer) As Integer
        public Form1()
        {
            InitializeComponent();

            //pintar();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //move location of numberLabel for amount 
            //of pixels caused by scrollbar
            int d = TextBox.GetPositionFromCharIndex(0).Y % (TextBox.Font.Height + 1);
            numberLabel.Location = new Point(0, d);

            updateNumberLabel();
            hhh();
            //pintar();
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

        private void guardarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            archivoObjeto.GuardarComo(TextBox);
        }
        //metodo para eliminar el archivo 
        private void eliminarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoObjeto.elimilarArchivo(TextBox);
        }

        //Salir
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Seguro que quieres Salir \n",
                    "Salir: ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //Environment.Exit(0);
                this.Dispose();
            }
            else if (result == DialogResult.No)
            {
                return;
            }



            
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
        // metodo para sincronizar el richtextBox con el label de numero de linea
        private void TextBox_VScrollChanged(object sender, EventArgs e)
        {
            //move location of numberLabel for amount 
            //of pixels caused by scrollbar
            int d = TextBox.GetPositionFromCharIndex(0).Y %
                                      (TextBox.Font.Height + 1);
            numberLabel.Location = new Point(0, d);

            //updateNumberLabel(0);
        }



        //metodo para pintar
        public void hhh() {
            //guarda la posicion del cursor antes de pintar
            int pos = TextBox.SelectionStart;
            string[] Reservadas = new string[] { "entero", "decimal", "cadena", "booleano", "caracter" };
            try
            {


                //PONE TODO EL TEXTO EN EL COLOR POR DEFECTO(FORECOLOR)
                
                TextBox.SelectionStart = 0;
                TextBox.SelectionLength = TextBox.TextLength;
                TextBox.SelectionColor = TextBox.ForeColor;
                

                foreach (string CLAVE in Reservadas) 
                { //COMPRUEBA CADA UNA DE LAS PALABRAS CLAVE

                    int INDEX = 0; //'INICIA LA BUSQUEDA DE LA CLAVE DESDE LA POSICION 0 DEL TEXTO

                while(INDEX <= TextBox.Text.LastIndexOf(CLAVE))
                        {
                        //'RECORRE TODO EL TEXTO BUSCANDO LA PALABRA CLAVE
                        
                        TextBox.Find(CLAVE, INDEX, TextBox.TextLength, RichTextBoxFinds.WholeWord); //'CUANDO LA ENCUENTRA LA SELECCIONA Y....
                        TextBox.SelectionColor = Color.Purple; //'... LE PONE EL COLOR INDICADO
                        INDEX = TextBox.Text.IndexOf(CLAVE, INDEX) + 1; //'AVANZA A LA SIGUIENTE UBICACION DE LA PALABRA CLAVE

                    }
                    

                }

                //CUANDO HA TERMINADO DE BUSCAR TODAS LAS PALABRAS VUELVE A LA SITUACION NORMAL (AL FINAL DEL TEXTO)
                TextBox.SelectionStart = TextBox.TextLength;
                TextBox.SelectionColor = TextBox.ForeColor;

                // establece el valor del cursor donde se encontraba antes de pintar la palabra con color
                TextBox.SelectionStart = pos;
                TextBox.SelectionLength = 0;


               

            } 
                catch(Exception ex)
                {
        
                    }

        }




        //muestra la pocion del cursos en cuarquier momento
        private void muestraPosicion(object sender, MouseEventArgs e)
        {
            //TextBox.selection star es el metodo para obtener la posicion del cursor y le sumo
            //+1 por los index que empiezan en 0
            int Line = TextBox.SelectionStart;
            int valor =1;
            int Numerolinea = (Line+valor);
            //obtengo en numero de fila
            position.Text = TextBox.GetLineFromCharIndex(Numerolinea)+"";
            
        }




        private void james(object sender, EventArgs e)
        {
            MessageBox.Show("Moviendo");

        }


    }

}
////AQUIIIIIIIIIIIIIII


//string[] Primitivo = new string[]
//{ "entero", "decimal", "cadena", "booleano", "caracter" };
//public void pintar()
//{



//    this.TextBox.TextChanged += (ob, ev) =>
//    {
//        //, StringSplitOptions.RemoveEmptyEntries
//        var palabras = this.TextBox.Text.Split(new char[] { ' ' });
//        var resultado = from PalabraReservada in Primitivo
//                        from PalabraIngresada in palabras
//                        where PalabraIngresada == PalabraReservada
//                        select PalabraReservada;

//        String palabra = TextBox.Text;

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



//        this.TextBox.SelectionColor = Color.Black;
//        this.TextBox.SelectionStart = this.TextBox.Text.Length;

//    };
//}