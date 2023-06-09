using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Yonetici :Kisi
    {
        public Unvan Unvan { get; set; }
        public string Sifre { get; set; }
        public bool AktifMi { get; set; }

        public ICollection<YoneticiPersonel> YoneticiPersoneller { get; set; }
    }
}
