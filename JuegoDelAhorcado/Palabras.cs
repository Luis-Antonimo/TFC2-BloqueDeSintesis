using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDelAhorcado
{
    public class Palabras
    {
        private string palabraSecreta;
        string[] diccionario = {"casa","perro","hechizo","reptil","dormitorio","desayuno","pollo",
        "camaleon", "queso","agua", "amanecer", "pesadilla", "hamburguesa", "computadora",
        "sabado", "justicia","primavera","idiota", "calamar","pelicula","edificio","paella","crema",
        "calabaza","literatura","jamón"};
        public Palabras()
        {            
        }
        public string getPalabraSecreta()
        {
            Random rnd = new Random();
            palabraSecreta = diccionario[rnd.Next(diccionario.Length)];
            return palabraSecreta;
        }





    }

    


}
