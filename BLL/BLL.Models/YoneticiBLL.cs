using BLL.Interface;
using DAL.Context;
using Entities.Enums;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Models
{
    public class YoneticiBLL : ICRUD<Yonetici>
    {
        public YoneticiBLL()
        {
            dbContext = new PersonelKayitContext();
        }

        PersonelKayitContext dbContext;
        public bool Ekle(Yonetici yonetici)
        {
            dbContext.Yoneticiler.Add(yonetici);
            return dbContext.SaveChanges()>0;
        }

        public bool Guncelle(Yonetici yonetici)
        {
            dbContext.Yoneticiler.Update(yonetici);
            return dbContext.SaveChanges()>0;
        }

        public bool Sil(int id)
        {
            dbContext.Yoneticiler.Find(id);
            return dbContext.SaveChanges()>0;
        }

        public Yonetici EmaileGoreGetir(string email)
        {
            return dbContext.Yoneticiler.FirstOrDefault(a => a.Email == email);
        }

        public List<Yonetici> HepsiniGetir()
        {
            return dbContext.Yoneticiler.Where(a => a.Unvan == Unvan.yonetici).ToList();
        }

        public List<Yonetici> TumYoneticileriGetir()
        {
            return dbContext.Yoneticiler.Where(y => y.Id != 1 && y.Ad != "admin").ToList();
        }

        public string ComputeSha256Hash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                var builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public Yonetici IdyeGoreGetir(int id)
        {
            return dbContext.Yoneticiler.Find(id);
        }

        public bool EmailVarMi(string email)
        {
            bool emailVarMi = dbContext.Yoneticiler.Any(a => a.Email == email);
            return emailVarMi;
        }

        public bool TcNoVarMi(string tcNo)
        {
            bool tcNoVarMi= dbContext.Yoneticiler.Any(a => a.TCNo == tcNo);
            return tcNoVarMi;
        }


    }
}
