using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Entities.Abstract
{
    public class Kisi :Tablo
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Cinsiyet Cinsiyet  { get; set; }
        public string TCNo { get; set; }
        public string Email { get; set; }
    }
}
