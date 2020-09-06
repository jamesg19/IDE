using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEjames
{
    class Archive
    {
        String Archivo;
        
        public Archive(String archivo)
        {
            this.Archivo = archivo;

        }


        public void OpenArchive(RichTextBox TextBox)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //agrego un filtro texto.txt
            openFile.Filter = ".gt|*.gt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Archivo = openFile.FileName;
                using (StreamReader sr = new StreamReader(Archivo))
                {
                    //lea el archivo completo
                     TextBox.Text = sr.ReadToEnd();

                }
            }
        }
        public void SaveArchive(RichTextBox TextBox)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = ".gt|*.gt";

            //si la variable no esta vacia
            if (Archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(Archivo))
                {
                    sw.Write(TextBox.Text);

                }
            }
            else
            {

                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    Archivo = SaveFile.FileName;
                    using (StreamWriter sw = new StreamWriter(SaveFile.FileName))
                    {
                         sw.Write(TextBox.Text);
                        

                    }
                    

                }
                
            }

        } 

        public void NewFile(RichTextBox TextBox)
        {
            TextBox.Clear();
            Archivo = null;
            SaveArchive(TextBox);
        }



    }
}
