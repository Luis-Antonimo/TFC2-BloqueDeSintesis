using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDelAhorcado
{
    internal class Comprobador
    {
        public char[] comprobarLetra(char letra,char[] chars, char[] chars_)
        {
            int existe = Array.IndexOf(chars, letra);
            if (existe != -1)
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == letra)
                    {
                        chars_[i] = letra;
                    }
                }
                return chars_;
            }
            return chars_;
        }
    }
}
