using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Music
{
    class Language
    {
        public static string[,] GetTexts(string language)
        {
            if(language == "spa")
            {
                return new string[,] { { "¡Escucha tus canciones favoritas!", "Reproducir un archivo", "Reproducir una carpeta", "Aleatorio",
                        "Más sobre esta canción", "Ajustes", "Reproducir", "Detener", "Pausar", "Siguiente", "Anterior" }, { "General","Opciones - Reinicia para aplicar los cambios","Predeterminado","Desvanecer x segundos","Actualizar cada x milisegundos","","","","","",""} };
            }
            else if(language == "eng")
            {
                return new string[,] { { "Let's listen your favourite songs!", "Play single file", "Play a directory", "Random songs",
                        "More about this song", "Settings", "Play!", "Stop", "Pause", "Next", "Previous" }, { "General","Options - Restart to see changes","Default values","Fade In/Out length","Update time","","","","","",""} };
            }
            else { throw new NotImplementedException(); }
        }
    }
}
