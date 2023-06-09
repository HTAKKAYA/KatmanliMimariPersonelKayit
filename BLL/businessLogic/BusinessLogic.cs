using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.businessLogic
{
    public class BusinessLogic
    {
        public BusinessLogic()
        {
            Yoneticiler = new Yonetici();
            Personeller = new Personel();
            YoneticiPersoneller = new YoneticiPersonel();
        }
        public Yonetici Yoneticiler { get; set; }
        public Personel Personeller { get; set; }
        public YoneticiPersonel YoneticiPersoneller { get; set; }
    }
}
