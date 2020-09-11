using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEjames
{
    class Archivo
    {
         String archivo;
        
        public Archivo(String archivo)
        {
            this.archivo = archivo;

        }


        public void AbrirArchivo(RichTextBox TextBox)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //agrego un filtro texto.txt
            openFile.Filter = ".gt|*.gt";
            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFile.FileName);
                archivo = openFile.FileName;
                using (StreamReader sr = new StreamReader(archivo))
                {
                    //lee el archivo completo
                     TextBox.Text = sr.ReadToEnd();


                }
            }
        }
        //metodo para guardar archivos con extension .gt
        public void GuardaArchivo(RichTextBox TextBox)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = ".gt|*.gt";

            //si la variable no esta vacia
            if (archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(TextBox.Text);

                }
            }
            else
            {

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    archivo = guardar.FileName;
                    using (StreamWriter sw = new StreamWriter(guardar.FileName))
                    {
                         sw.Write(TextBox.Text);
                    }
                }      
            }

        } 
        //metodo para crear un nuevo archivo
        public void NuevoArchivo(RichTextBox TextBox)
        {
            TextBox.Clear();
            archivo = null;
            GuardaArchivo(TextBox); ; ; ; ; ; ; ; ; ; ;
        }



    }
}

//public void eliminarProyecto(String PATH)
//{
//    try
//    {
//        if (File.Exists(path))
//        {
//            File.Delete(path);
//        }
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show("No se ha podido elimar el proyecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//    }
//}