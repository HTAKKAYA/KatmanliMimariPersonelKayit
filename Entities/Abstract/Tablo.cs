using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class Tablo
    {
        public Tablo()
        {
            CreationDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
