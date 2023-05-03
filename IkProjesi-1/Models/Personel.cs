using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkProjesi_1.Models
{
    [Table("Personel16")]
    public class Personel : BaseModel
    {


        [Display(Name = "İsim")]
        [ MaxLength(30, ErrorMessage = "{0} {1} karakterden uzun olamaz.")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string Ad { get; set; }
         
        public string Soyad{ get; set; }
        public int? SirketNumarasi { get; set; } // intin yanına soru işareti koyarak bu değerin null olabilir hale getirdik.
        [ForeignKey("Unvan2")]
        public int? UnvanId { get; set; }
        public DateTime? IseGirisTarihi { get; set; }
        public DateTime? CikisTarihi { get; set; }

        [NotMapped]
        public int HicOnemliDegil { get; set; }



        public virtual List<Unvan> Unvan { get; set; }
        public virtual Unvan Unvan2 { get; set; }


 
    }
    
}