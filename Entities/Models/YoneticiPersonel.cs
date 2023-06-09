using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class YoneticiPersonel : Tablo
    {
        public int YoneticiId { get; set; }
        public Yonetici Yonetici { get; set; }
        public int PersonelId { get; set; }
        public Personel Personel { get; set; }
    }
}
