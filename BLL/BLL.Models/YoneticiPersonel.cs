using BLL.Interface;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Models
{
    internal class YoneticiPersonel : ICRUD<YoneticiPersonel>
    {

        public YoneticiPersonel()
        {
            dbContext = new PersonelKayitContext();
        }

        PersonelKayitContext dbContext;
        public bool Ekle(YoneticiPersonel yoneticiPersonel)
        {
            throw new NotImplementedException();
        }

        public bool Guncelle(YoneticiPersonel yoneticiPersonel)
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
