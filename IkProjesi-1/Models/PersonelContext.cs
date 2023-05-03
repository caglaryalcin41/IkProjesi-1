using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IkProjesi_1.Models
{
    public class PersonelContext : DbContext
    {
        // Construction = Class ismi ile aynı olmak zorundadır. bu bir metotdur. class kullanılırken ilk çalışan metotdur. yazılması şart değildir yazılmasa bile arka planda oluşuturulur.
        public PersonelContext() : base("name=Baglanti41")  
        {
            
        } 
       public DbSet<Personel> Personel41 { get; set; } 
        public DbSet<Unvan> Unvan { get; set; }
    }
}