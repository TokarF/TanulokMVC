using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TanulokMVC.Models
{
    public class OsztalyModel
    {
        public List<TanuloModel> diakok;

        [DisplayName("Osztály ID")]
        public int OsztalyId { get; set; }
        
        [Required(ErrorMessage = "Az osztály nevét kötelező megadni!")]
        [DisplayName("Osztály")]
        public string OsztalyNev { get; set; }

        [Required(ErrorMessage = "Az osztályfőnök nevét kötelező megadni!")]
        [DisplayName("Osztályfőnök")]
        public string OsztalyFonok { get; set; }

        [Required]
        [Range(100, 400, ErrorMessage = "A tanterem számának egy 100 és 400 közötti értéknek kell lennie!")]
        [DisplayName("Tanterem")]
        public string Tanterem { get; set; }

        [DisplayName("Diákok")]
        public List<TanuloModel> Diakok { get; set; }

        public OsztalyModel()
        {

        }

        public OsztalyModel(int osztalyId, string osztalyNev, string osztalyFonok, string tanterem)
        {

            OsztalyId = osztalyId;
            OsztalyNev = osztalyNev;
            OsztalyFonok = osztalyFonok;
            Tanterem = tanterem;
            diakok = new List<TanuloModel>();
        }

    }



}
