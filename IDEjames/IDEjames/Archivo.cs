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
        String ruta;
        String archivo;
        
        public Archivo(String archivo)
        {
            this.archivo = archivo;

        }

        public void AbrirArchivo(RichTextBox TextBox)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //agrego un filtro texto.txt
            
            //openFile.Filter = ".gt|*.gt" +"|All Files|*.*";
            openFile.Filter = ".gt|*.gt" +"|All Files|*.*";



            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.ruta = openFile.FileName;
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
            try
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = ".gt|*.gt";

                //si la variable no esta vacia
                if (archivo != null)
                {
                   
                    using (StreamWriter sw = new StreamWriter(archivo))
                    {
                        sw.Write(TextBox.Text);
                        this.ruta = archivo;
                    }
                }
                else
                {
                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        this.ruta = guardar.FileName;
                        archivo = guardar.FileName;
                        this.ruta = guardar.FileName;
                        using (StreamWriter sw = new StreamWriter(guardar.FileName))
                        {
                            sw.Write(TextBox.Text);
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Error al guardar el archivo");
            }

        } 
        //metodo para crear un nuevo archivo
        public void NuevoArchivo(RichTextBox TextBox)
        {           
                TextBox.Clear();
                archivo = null;
                GuardaArchivo(TextBox);
        }
        //metodo para guardar como
        public void GuardarComo(RichTextBox TextBox)
        {

            try
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = ".gt|*.gt";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    archivo = guardar.FileName;
                    this.ruta = guardar.FileName;
                    using (StreamWriter sw = new StreamWriter(guardar.FileName))
                    {
                        sw.Write(TextBox.Text);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al guardar el archivo");
            }

        }
        //metodo para guardar error en archivo .gtE
        public void GuardarError(RichTextBox TextBox2)
        {

            try
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = ".gtE|*.gtE";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    archivo = guardar.FileName;
                    this.ruta = guardar.FileName;
                    using (StreamWriter sw = new StreamWriter(guardar.FileName))
                    {
                        sw.Write(TextBox2.Text);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al guardar el archivo");
            }

        }





        //metodo para eliminar un archivo abierto en el IDE
        public void elimilarArchivo(RichTextBox TextBox)
        {
            try
            {


                DialogResult result = MessageBox.Show("Seguro que quieres eliminar este archivo: \n"+ruta, 
                    "Eliminar :", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    File.Delete(ruta);
                    TextBox.Clear();
                    MessageBox.Show(" Se ha eliminado el arhivo: ");
                }
                else if (result == DialogResult.No)
                {
                    return;
                }

                
            }
            catch
            {
                MessageBox.Show("No se pudo eliminar el archivo debes crear uno");
            }
            
        }



    }
}
