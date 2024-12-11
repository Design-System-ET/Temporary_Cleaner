using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Security.Permissions;
using System.Diagnostics;
using System.Text;

namespace Temporary_Cleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string winTEMP = "C:\\Windows\\Temp\\";
            DirectoryInfo directory = new DirectoryInfo(winTEMP);

            bool exito = true;

            try
            {
                foreach (FileInfo file in directory.GetFiles())
                {
                    file.Delete();
                };

                foreach (DirectoryInfo dir in directory.GetDirectories())
                {
                    dir.Delete();
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show("Temporary Cleaner no pudo eliminar algunos recursos por que otro programa abrio la carpeta o uno de sus archivos", ex.Message);
                exito = false;
            }

            if (exito)
            {
                // Mostrar mensaje si la eliminación de todos los archivos fue exitosa
                MessageBox.Show("Se eliminaron todos los archivos con éxito.");
            }
            else
            {
                // Mostrar mensaje si hubo errores en la eliminación de al menos un archivo
                MessageBox.Show("La eliminación de archivos no se completó correctamente.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string appDataTEMP = @"AppData\Local\Temp\";
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string fullPath = System.IO.Path.Combine(basePath, appDataTEMP);
            DirectoryInfo appdatatemp = new DirectoryInfo(fullPath);

            //limpieza de archivos la hago por este exe externo por que en esta carpeta no funciona
            //la doble eliminacion (carpetas y archivos)
            string rutaAlExe = @"appdataFile.exe";
            Process proceso = new Process();
            proceso.StartInfo.FileName = rutaAlExe;

            bool exito = true;

            try
            {
                foreach (DirectoryInfo dir in appdatatemp.GetDirectories())
                {
                    dir.Delete(true);
                    proceso.Start();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Temporary Cleaner no pudo eliminar algunos recursos por que otro programa abrio la carpeta o uno de sus archivos", ex.Message);
                exito = false;
            };


            if (exito)
            {
                // Mostrar mensaje si la eliminación de todos los archivos fue exitosa
                MessageBox.Show("Se eliminaron todos los archivos con éxito.");
            }
            else
            {
                // Mostrar mensaje si hubo errores en la eliminación de al menos un archivo
                MessageBox.Show("La eliminación de archivos no se completó correctamente.");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string winTEMP = "C:\\Windows\\Prefetch";
            DirectoryInfo directory = new DirectoryInfo(winTEMP);

            bool exito = true;

            try
            {
                foreach (FileInfo file in directory.GetFiles())
                {
                    file.Delete();
                };

                foreach (DirectoryInfo dir in directory.GetDirectories())
                {
                    dir.Delete();
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show("Temporary Cleaner no pudo eliminar algunos recursos por que otro programa abrio la carpeta o uno de sus archivos", ex.Message);
                exito = false;
            }

            if (exito)
            {
                // Mostrar mensaje si la eliminación de todos los archivos fue exitosa
                MessageBox.Show("Se eliminaron todos los archivos con éxito.");
            }
            else
            {
                // Mostrar mensaje si hubo errores en la eliminación de al menos un archivo
                MessageBox.Show("La eliminación de archivos no se completó correctamente.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string appDataTEMP = @"AppData\Local\Microsoft\Windows\INetCache";
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string fullPath = System.IO.Path.Combine(basePath, appDataTEMP);
            DirectoryInfo inetCache = new DirectoryInfo(fullPath);

            bool exito = true;

            try
            {
                foreach (FileInfo file in inetCache.GetFiles())
                {
                    file.Delete();
                };

                foreach (DirectoryInfo dir in inetCache.GetDirectories())
                {
                    dir.Delete(true);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Temporary Cleaner no pudo eliminar algunos recursos por que otro programa abrio la carpeta o uno de sus archivos", ex.Message);
                exito = false;
            }

            if (exito)
            {
                // Mostrar mensaje si la eliminación de todos los archivos fue exitosa
                MessageBox.Show("Se eliminaron todos los archivos con éxito.");
            }
            else
            {
                // Mostrar mensaje si hubo errores en la eliminación de al menos un archivo
                MessageBox.Show("La eliminación de archivos no se completó correctamente.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string winTEMP = "C:\\Windows\\SoftwareDistribution\\Download";
            DirectoryInfo directory = new DirectoryInfo(winTEMP);

            bool exito = true;

            try
            {
                foreach (FileInfo file in directory.GetFiles())
                {
                    file.Delete();
                };

                foreach (DirectoryInfo dir in directory.GetDirectories())
                {
                    dir.Delete();
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show("Temporary Cleaner no pudo eliminar algunos recursos por que otro programa abrio la carpeta o uno de sus archivos", ex.Message);
                exito = false;
            }

            if (exito)
            {
                // Mostrar mensaje si la eliminación de todos los archivos fue exitosa
                MessageBox.Show("Se eliminaron todos los archivos con éxito.");
            }
            else
            {
                // Mostrar mensaje si hubo errores en la eliminación de al menos un archivo
                MessageBox.Show("La eliminación de archivos no se completó correctamente.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string winTEMP = "C:\\Windows\\Logs";
            DirectoryInfo directory = new DirectoryInfo(winTEMP);

            bool exito = true;

            try
            {
                foreach (FileInfo file in directory.GetFiles())
                {
                    file.Delete();
                };

                foreach (DirectoryInfo dir in directory.GetDirectories())
                {
                    dir.Delete();
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show("Temporary Cleaner no pudo eliminar algunos recursos por que otro programa abrio la carpeta o uno de sus archivos", ex.Message);
                exito = false;
            }

            if (exito)
            {
                // Mostrar mensaje si la eliminación de todos los archivos fue exitosa
                MessageBox.Show("Se eliminaron todos los archivos con éxito.");
            }
            else
            {
                // Mostrar mensaje si hubo errores en la eliminación de al menos un archivo
                MessageBox.Show("La eliminación de archivos no se completó correctamente.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string appDataTEMP = @"AppData\Local\Microsoft\Windows\History";
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string fullPath = System.IO.Path.Combine(basePath, appDataTEMP);
            DirectoryInfo inetCache = new DirectoryInfo(fullPath);

            bool exito = true;

            try
            {
                foreach (FileInfo file in inetCache.GetFiles())
                {
                    file.Delete();
                };

                foreach (DirectoryInfo dir in inetCache.GetDirectories())
                {
                    dir.Delete();
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show("Temporary Cleaner no pudo eliminar algunos recursos por que otro programa abrio la carpeta o uno de sus archivos", ex.Message);
                exito = false;
            }

            if (exito)
            {
                // Mostrar mensaje si la eliminación de todos los archivos fue exitosa
                MessageBox.Show("Se eliminaron todos los archivos con éxito.");
            }
            else
            {
                // Mostrar mensaje si hubo errores en la eliminación de al menos un archivo
                MessageBox.Show("La eliminación de archivos no se completó correctamente.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string appDataTEMP = @"AppData\Roaming\Microsoft\Windows\Recent";
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string fullPath = System.IO.Path.Combine(basePath, appDataTEMP);
            DirectoryInfo inetCache = new DirectoryInfo(fullPath);

            bool exito = true;

            try
            {
                foreach (FileInfo file in inetCache.GetFiles())
                {
                    file.Delete();
                };

                foreach (DirectoryInfo dir in inetCache.GetDirectories())
                {
                    dir.Delete();
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show("Temporary Cleaner no pudo eliminar algunos recursos por que otro programa abrio la carpeta o uno de sus archivos", ex.Message);
                exito = false;
            }

            if (exito)
            {
                // Mostrar mensaje si la eliminación de todos los archivos fue exitosa
                MessageBox.Show("Se eliminaron todos los archivos con éxito.");
            }
            else
            {
                // Mostrar mensaje si hubo errores en la eliminación de al menos un archivo
                MessageBox.Show("La eliminación de archivos no se completó correctamente.");
            }
        }






        ///limpiiza completa automatica

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Mostrar mensaje al usuario
            DialogResult resultado = MessageBox.Show("Este programa eliminará todos los archivos temporales y basura de Windows. ¿Desea continuar?", "Limpiador de Archivos Temporales", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Validar respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Obtener la ruta de la carpeta de archivos temporales del usuario
                string rutaTemp = Path.GetTempPath();

                // Obtener la ruta de la carpeta de archivos temporales del sistema
                string rutaWindows = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                string rutaSystem32 = Path.Combine(rutaWindows, "System32");

                // Obtener la ruta de la carpeta de archivos temporales del usuario
                //string rutaTempUsuario = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft", "Windows");

                // Obtener la ruta de la carpeta de archivos temporales del sistema
                string rutaTempSistema = Path.Combine(rutaWindows, "Temp");

                // Obtener la ruta de la carpeta de archivos basura del navegador
                string rutaBasuraNavegador = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft", "Windows", "INetCache");

                // Obtener la ruta de la carpeta de historial del navegador
                string rutaHistorialNavegador = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft", "Windows", "History");

                // Obtener la ruta de la carpeta de registros de Windows
                string rutaRegistrosWindows = Path.Combine(rutaWindows, "Logs");

                // Obtener la ruta de la carpeta de descargas de actualizaciones de Windows
                string rutaDescargasWindows = Path.Combine(rutaWindows, "SoftwareDistribution", "Download");

                // Obtener la ruta de la carpeta de archivos basura del sistema
                string rutaPrefetch = Path.Combine(rutaWindows, "Prefetch");
                string rutaRecent = Environment.GetFolderPath(Environment.SpecialFolder.Recent);

                // Crear un arreglo con las rutas de las carpetas a limpiar
                string[] rutas = new string[] { rutaTemp, rutaTempSistema, rutaPrefetch, rutaRecent, rutaBasuraNavegador, rutaHistorialNavegador, rutaRegistrosWindows, rutaDescargasWindows };

                // Mostrar mensaje al usuario con las rutas a limpiar
                MessageBox.Show("Las siguientes ubicaciones se limpiarán:\n" + String.Join("\n", rutas), "Limpiador de Archivos Temporales", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Iniciar proceso de limpieza
                LimpiarArchivosTemporales();
            }
            else
            {
                // Terminar programa
                MessageBox.Show("Gracias por usar el programa. Adiós.", "Limpiador de Archivos Temporales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void LimpiarArchivosTemporales()
        {
            // Obtener la ruta de la carpeta de archivos temporales del usuario
            string rutaTemp = Path.GetTempPath();

            // Obtener la ruta de la carpeta de archivos temporales del sistema
            string rutaWindows = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            string rutaSystem32 = Path.Combine(rutaWindows, "System32");

            // Obtener la ruta de la carpeta de archivos temporales del usuario
            //string rutaTempUsuario = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft", "Windows");

            // Obtener la ruta de la carpeta de archivos temporales del sistema
            string rutaTempSistema = Path.Combine(rutaWindows, "Temp");

            // Obtener la ruta de la carpeta de archivos basura del navegador
            string rutaBasuraNavegador = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft", "Windows", "INetCache");

            // Obtener la ruta de la carpeta de historial del navegador
            string rutaHistorialNavegador = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft", "Windows", "History");

            // Obtener la ruta de la carpeta de registros de Windows
            string rutaRegistrosWindows = Path.Combine(rutaWindows, "Logs");

            // Obtener la ruta de la carpeta de descargas de actualizaciones de Windows
            string rutaDescargasWindows = Path.Combine(rutaWindows, "SoftwareDistribution", "Download");

            // Obtener la ruta de la carpeta de archivos basura del sistema
            string rutaPrefetch = Path.Combine(rutaWindows, "Prefetch");
            string rutaRecent = Environment.GetFolderPath(Environment.SpecialFolder.Recent);

            // Crear un contador para llevar el registro de los archivos eliminados
            int contador = 0;

            // Crear un constructor de cadenas para almacenar los mensajes
            StringBuilder mensajes = new StringBuilder();

            // Crear un arreglo con las rutas de las carpetas a limpiar
            string[] rutas = new string[] { rutaTemp, rutaTempSistema, rutaPrefetch, rutaRecent, rutaBasuraNavegador, rutaHistorialNavegador, rutaRegistrosWindows, rutaDescargasWindows };

            // Recorrer el arreglo de rutas
            foreach (string ruta in rutas)
            {
                // Obtener los archivos de la carpeta actual
                string[] archivos = Directory.GetFiles(ruta);

                // Recorrer los archivos de la carpeta actual
                foreach (string archivo in archivos)
                {
                    try
                    {
                        // Eliminar el archivo actual
                        File.Delete(archivo);

                        // Incrementar el contador
                        contador++;

                        // Agregar mensaje al constructor de cadenas
                        mensajes.AppendLine("Archivo eliminado: " + archivo);
                    }
                    catch (Exception e)
                    {
                        // Agregar mensaje al constructor de cadenas
                        mensajes.AppendLine("Error al eliminar el archivo: " + archivo);
                        mensajes.AppendLine("Motivo: " + e.Message);
                    }
                }
            }

            // Crear una carpeta temporal vacía
            string carpetaTemporal = Path.Combine(rutaTemp, "temporal");
            Directory.CreateDirectory(carpetaTemporal);

            // Recorrer el arreglo de rutas
            foreach (string ruta in rutas)
            {
                try
                {
                    // Mover los archivos de la carpeta actual a la carpeta temporal y eliminar las carpetas vacías
                    //Process.Start("robocopy", ruta + " " + carpetaTemporal + " /s /move /purge");

                    // Crear un objeto ProcessStartInfo con los argumentos del comando robocopy
                    ProcessStartInfo psi = new ProcessStartInfo("robocopy", ruta + " " + carpetaTemporal + " /s /move /purge");
                    // Establecer la propiedad CreateNoWindow a true para ocultar la consola
                    psi.CreateNoWindow = true;
                    // Iniciar el proceso con el objeto ProcessStartInfo
                    Process.Start(psi);
                }
                catch (Exception e)
                {
                    // Agregar mensaje al constructor de cadenas
                    mensajes.AppendLine("Error al mover los archivos o eliminar las carpetas: " + ruta);
                    mensajes.AppendLine("Motivo: " + e.Message);
                }
            }

            // Eliminar la carpeta temporal
            Directory.Delete(carpetaTemporal, true);
            // Mostrar mensaje al usuario
            MessageBox.Show("Proceso de limpieza terminado.\nSe han eliminado " + contador + " archivos.\n" + mensajes.ToString(), "Limpiador de Archivos Temporales", MessageBoxButtons.OK, MessageBoxIcon.Information);

       

            //Crear las carpetas eliminadas por que el proceso de robocopy me elimina estas direcciones
            // Definir las rutas de las carpetas a crear
            string[] paths = new string[]
            {
                @"C:\Windows\Prefetch",
                @"C:\Windows\Logs",
                @"C:\Windows\SoftwareDistribution\Download"
            };

            // Recorrer cada ruta del arreglo
            foreach (string path in paths)
            {
                try
                {
                    // Crear la carpeta si no existe
                    Directory.CreateDirectory(path);
                    // Mostrar un mensaje de éxito
                    MessageBox.Show("La carpeta " + path + " se ha creado correctamente.");
                }
                catch (Exception e)
                {
                    // Manejar la excepción y mostrar un mensaje de error
                    MessageBox.Show("No se pudo crear la carpeta " + path + ".\n" + e.Message);
                }
            }

        }
    }
}
