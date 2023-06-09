using BLL.Interface;
using DAL.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Models
{
    public class PersonelBLL : ICRUD<Personel>
    {
        public PersonelBLL()
        {
            dbContext = new PersonelKayitContext();
        }

        PersonelKayitContext dbContext;

        public bool Ekle(Personel personel)
        {
            dbContext.Personeller.Add(personel);
            return dbContext.SaveChanges() > 0;
        }

        public bool Guncelle(Personel personel)
        {
            dbContext.Personeller.Update(personel);
            return dbContext.SaveChanges() > 0;
        }

        public bool Sil(int id)
        {
            Personel personel = dbContext.Personeller.Find(id);
            dbContext.Personeller.Remove(personel);
            return dbContext.SaveChanges() > 0;
        }

        public Personel IdyeGoreGetir(int id)
        {
            return dbContext.Personeller.Find(id);
        }

        public List<Personel> TumPersonelleriGetir()
        {
            return dbContext.Personeller.ToList();
        }

        public bool EmailVarMi(string email)
        {
            bool emailVarMi = dbContext.Personeller.Any(a => a.Email == email);
            return emailVarMi;
        }

        public bool TcNoVarMi(string tcNo)
        {
            bool tcNoVarMi = dbContext.Personeller.Any(a => a.TCNo == tcNo);
            return tcNoVarMi;
        }

        public List<Personel> ArananPersonel(string arananKelime)
        {
            return dbContext.Personeller.Where(p => p.Ad.Contains(arananKelime)).ToList();
        }
    }
}
