using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCSharp.Models
{
    public class Personel
    {
        public int Id { get; set; }
        [DisplayName("Adınız")]
        public string ad { get; set; }
        [DisplayName("Soyadınız")]
        public string soyad { get; set; }

       
        [DisplayName("T.C. Kimlik No")]
        [Required]
        public double TCKN { get; set; }
        
        [DisplayName("Doğum Tarihiniz")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime dogumtarihi { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)]
        [DisplayName("e-Mail Adresiniz")]
        public string eposta { get; set; }
    }
}