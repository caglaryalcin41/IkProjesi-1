using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkProjesi_1.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }

        public string ReservedName { get; set; }

        public int AktifMi { get; set; }

        public DateTime? CreatedOn { get; set; } = DateTime.Now;

        public int? CreatedBy { get; set; }

        public DateTime? EditedOn { get; set; }

        public int? EditedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? ActiveOn { get; set; }

        public int? ActivetedBy { get; set; }

        public string Reserved1 { get; set; }
        public string Reserved2 { get; set; } 
    }
}