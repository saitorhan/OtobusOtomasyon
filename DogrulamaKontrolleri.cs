using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace otobus_otomasyon_linq
{
    public class DogrulamaKontrolleri
    {
        public static bool SadeceHarfMi(string cumle)
        {
            foreach (char item in cumle)
            {
                if (!(Char.IsLetter(item) || Char.IsWhiteSpace(item)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
