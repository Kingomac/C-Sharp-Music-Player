using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_Music
{
    class Language
    {
       /* public static string[,] GetTexts(string language)
        {
            if(language == "spa")
            {
                return new string[,] { { "¡Escucha tus canciones favoritas!", "Reproducir un archivo", "Reproducir una carpeta", "Aleatorio",
                        "Más sobre esta canción", "Ajustes", "Reproducir", "Detener", "Pausar", "Siguiente", "Anterior" }, { "General","Opciones - Reinicia para aplicar los cambios","Predeterminado","Desvanecer x segundos","Actualizar cada x milisegundos","Idioma","","","","",""} };
            }
            else if(language == "eng")
            {
                return new string[,] { { "Let's listen your favourite songs!", "Play single file", "Play a directory", "Random songs",
                        "More about this song", "Settings", "Play!", "Stop", "Pause", "Next", "Previous" }, { "General","Options - Restart to see changes","Default values","Fade In/Out length","Update time","Language","","","","",""} };
            }
            else { throw new NotImplementedException(); }
        }*/
        public static async Task<string[]> GetTexts(string lang)
        {
            try
            {
                int l = File.ReadAllLines($"./lang/{lang}.lang").Length;
                string[] q = new string[l];
                StreamReader w = new StreamReader($"./lang/{lang}.lang");
                for(int i = 0; i < l; i++)
                {
                    q[i] = await w.ReadLineAsync();
                }
                w.Close();
                w.Dispose();
                return q;
            }
            catch { throw new FileNotFoundException("Language file is missing"); }
        }
        public static async Task<string[]> GetSettingsTexts(string lang)
        {
            try
            {
                int l = File.ReadAllLines($"./lang/{lang}conf.lang").Length;
                string[] q = new string[l];
                StreamReader w = new StreamReader($"./lang/{lang}conf.lang");
                for (int i = 0; i < l; i++)
                {
                    q[i] = await w.ReadLineAsync();
                }
                w.Close();
                return q;
            }
            catch { throw new FileNotFoundException("Language file is missing"); }
        }
        public static async Task<string> ReadConfFile()
        {
            StreamReader w = new StreamReader("config.ini");
            await w.ReadLineAsync();
            await w.ReadLineAsync();
            string s =  await w.ReadLineAsync();
            w.Close();
            return s;
        }
    }
}
