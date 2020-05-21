using MVCCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCSharp.Veri
{
    public class PersonelVeriler
    {
        public static List<Personel> listPersoneller = new List<Personel>()
        {
            new Personel
            {
                Id = 1,
                ad = "Oğuz",
                soyad = "ÖZGÜL",
                TCKN = 14133003982,
                dogumtarihi = new DateTime(1984, 01, 06)


            },
            new Personel
            {
                Id = 2,
                ad = "Ayşe",
                soyad = "ÖZGÜL",
                TCKN = 45667952712,
                dogumtarihi = new DateTime(1990, 02, 06)


            }
        };
        
    }
}