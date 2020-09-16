using IDEjames.Analizador;
using System;
using System.Collections;
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
        ArrayList lista = new ArrayList();
        String[] Array=new String[] { };
        DatosPrimitivo DT;
        Comentario CMT;
        string archivo;
        Archivo archivoObjeto = new Archivo("");
        
        //Private Declare Function LockWindowUpdate Lib "user32" (ByVal hWnd As Integer) As Integer
        public Form1()
        {
            InitializeComponent();
            DatosPrimitivo DT = new DatosPrimitivo("",TextBox);
            Comentario CMT = new Comentario("", TextBox);
            this.DT = DT;
            this.CMT = CMT;
            //pintar();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //move location of numberLabel for amount 
            //of pixels caused by scrollbar
            int d = TextBox.GetPositionFromCharIndex(0).Y % (TextBox.Font.Height + 1);
            numberLabel.Location = new Point(0, d);

            updateNumberLabel();
            //hhh();
            //pintar();
            //pruebaCadena();
            PPPPPPP();
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
            ////we get index of first visible char and 
            ////number of first visible line
            //Point pos = new Point(0, 0);
            //int firstIndex = TextBox.GetCharIndexFromPosition(pos);
            //int firstLine = TextBox.GetLineFromCharIndex(firstIndex);

            ////now we get index of last visible char 
            ////and number of last visible line
            //pos.X = ClientRectangle.Width;
            //pos.Y = ClientRectangle.Height;
            //int lastIndex = TextBox.GetCharIndexFromPosition(pos);
            //int lastLine = TextBox.GetLineFromCharIndex(lastIndex);

            ////this is point position of last visible char, we'll 
            ////use its Y value for calculating numberLabel size
            //pos = TextBox.GetPositionFromCharIndex(lastIndex);

            ////finally, renumber label
            //numberLabel.Text = "";
            //for (int i = firstLine; i <= lastLine + 1; i++)
            //{
            //    numberLabel.Text += i + 1 + "\n";
            //}
            
        }
        // metodo para sincronizar el richtextBox con el label de numero de linea
        private void TextBox_VScrollChanged(object sender, EventArgs e)
        {
            ////move location of numberLabel for amount 
            ////of pixels caused by scrollbar
            //int d = TextBox.GetPositionFromCharIndex(0).Y %
            //                          (TextBox.Font.Height + 1);
            //numberLabel.Location = new Point(0, d);

            ////updateNumberLabel();
        }

        //muestra la pocion del cursos en cuarquier momento
        private void muestraPosicion(object sender, MouseEventArgs e)
        {

            // Get the line. 
            int index = TextBox.SelectionStart;
            int line = TextBox.GetLineFromCharIndex(index);
            position.Text = (line + 1) + "";
            // Get the column. 
            int firstChar = TextBox.GetFirstCharIndexFromLine(line);
            int column = index - firstChar;
            columna.Text = column + "";

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

                //DT.Inicial(TextBox);

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





        public void PPPPPPP()
        {

            //guarda la posicion del cursor antes de pintar
            int pos = TextBox.SelectionStart;
            string[] Reservadas = new string[] {";","="};

            

            try
            {
                //PONE TODO EL TEXTO EN EL COLOR POR DEFECTO(FORECOLOR)

                TextBox.SelectionStart = 0;
                TextBox.SelectionLength = TextBox.TextLength;
                TextBox.SelectionColor = TextBox.ForeColor;

                

                foreach (string CLAVE in Reservadas)
                { //COMPRUEBA CADA UNA DE LAS PALABRAS CLAVE

                    int INDEX = 0; //'INICIA LA BUSQUEDA DE LA CLAVE DESDE LA POSICION 0 DEL TEXTO

                    while (INDEX <= TextBox.Text.LastIndexOf(CLAVE.ToString())) //'RECORRE TODO EL TEXTO BUSCANDO LA PALABRA CLAVE
                    {
                     

                        TextBox.Find(CLAVE.ToString(), INDEX, TextBox.TextLength, RichTextBoxFinds.WholeWord); //'CUANDO LA ENCUENTRA LA SELECCIONA Y....
                        TextBox.SelectionColor = Color.Pink; //'... LE PONE EL COLOR INDICADO
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
            catch (Exception ex)
            {
            }
            //agrega las linea
            for (int i = 0; i < TextBox.Lines.Length; i++)
            {

                DT.Inicial(TextBox.Lines[i], TextBox);
                CMT.Inicial(TextBox.Lines[i], TextBox);
            }

        }



        private void LogError_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            lista.Add("a");
            lista.Add("b");
            lista.Add("c");
            lista.Add("d");

            MessageBox.Show("Contiena la letra c?   " + lista.Contains("g" +
                ""));
        }
    }

}