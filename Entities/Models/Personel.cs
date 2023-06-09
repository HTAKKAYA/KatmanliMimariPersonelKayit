using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Personel:Kisi
    {
        public DateTime DogumTarihi { get; set; }
        public string Departman { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        public ICollection<YoneticiPersonel> YoneticiPersoneller { get; set; }
    }
}
