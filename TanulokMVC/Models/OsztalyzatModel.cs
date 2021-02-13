using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TanulokMVC.Models
{
    public enum Tantargyak
    {
        [Display(Name = "Irodalom")]
        irodalom,
        [Display(Name = "Nyelvtan")]
        nyelvtan,    
        [Display(Name = "Matematika")]
        matematika,
        [Display(Name = "Történelem")]
        tortenelem,
        [Display(Name = "Angol")]
        angol,
        [Display(Name = "Informatika")]
        informatika,

    }

    public enum OsztalyzatTipus
    {
        [Display(Name = "Szóbeli Felelet")]
        szobeli,
        [Display(Name = "Röpdolgozat")]
        ropdolgozat,
        [Display(Name = "Témazáró")]
        temazaro,
        [Display(Name = "Házi Feladat")]
        hazifeladat,
        [Display(Name = "Szorgalmi feladat")]
        szorgalmi
    }

    public class OsztalyzatModel
    {

        [DisplayName("Osztályzat ID")]
        public int OsztalyzatId { get; set; }

        [DisplayName("Tanuló ID")]
        public int TanuloId { get; set; }
        [DisplayName("Tantárgy")]
        public Tantargyak Tantargy { get; set; }
        
        [DisplayName("Osztályzat Típus")]
        public OsztalyzatTipus OsztalyzatTipus { get; set; }
        
        [DisplayName("Osztályzat")]
        [Required(ErrorMessage = "Az osztályzatot kötelező megadni!")]
        [Range(1, 5, ErrorMessage = "Az osztályzat csak egy 1 és 5 közötti érték lehet!")]
        public byte Osztalyzat { get; set; }
        
        [DisplayName("Megnevezés")]
        [Required(ErrorMessage = "Az osztályzat megnevezetését kötelező megadni!")]
        public string Megnevezes { get; set; }
        
        [DisplayName("Megjegyzés")]
        [Required(ErrorMessage = "Az osztályzathoz kötelező megjegyzést megadni!")]
        public string Megjegyzes { get; set; }
        
        [DisplayName("Súlyozott")]
        public bool Sulyozott { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DisplayName("Dátum")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Az osztályzat dátumát kötelező megadni!")]
        public DateTime Datum { get; set; }

        public OsztalyzatModel()
        {

        }

        public OsztalyzatModel(int osztalyzatId, int tanuloId, Tantargyak tantargy, OsztalyzatTipus osztalyzatTipus, byte osztalyzat, string megnevezes, string megjegyzes, bool sulyozott, DateTime datum)
        {
            OsztalyzatId = osztalyzatId;
            TanuloId = tanuloId;
            Tantargy = tantargy;
            OsztalyzatTipus = osztalyzatTipus;
            Osztalyzat = osztalyzat;
            Megnevezes = megnevezes;
            Megjegyzes = megjegyzes;
            Sulyozott = sulyozott;
            Datum = datum;
        }


    }
}
