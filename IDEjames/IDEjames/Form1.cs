using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IDEjames
{
    public partial class Form1 : Form
    {
        string archivo;
        Archive archivoObjeto = new Archive("");

        public Form1()
        {
            InitializeComponent();

            
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
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // llama al metodo abrir de la clase archivo 
            archivoObjeto.OpenArchive(TextBox);
        }

        //boton para guardar un archivo
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // llama al metodo guardar de la clase archivo 
            archivoObjeto.SaveArchive(TextBox);
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // llama al metodo NewFIle de la clase archivo 
            archivoObjeto.NewFile(TextBox);



        }



        //metodo 
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

        private void numberLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        //Salie
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            this.Dispose();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //TextBox_VScrollChanged(sender, e);
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
