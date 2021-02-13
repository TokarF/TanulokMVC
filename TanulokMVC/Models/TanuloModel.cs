using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TanulokMVC.Models
{
    public class TanuloModel
    {
        public List<OsztalyzatModel> osztalyzatok;

        [DisplayName("Tanuló ID")]
        public int TanuloId { get; set; }

        [DisplayName("Osztály ID")]
        public int OsztalyId { get; set; }

        [DisplayName("Vezetéknév")]
        [Required(ErrorMessage = "A vezetéknevet kötelező megadni!")]
        public string VezetekNev { get; set; }
        
        [DisplayName("Keresztnév")]
        [Required(ErrorMessage = "A keresztnevet kötelező megadni!")]
        public string KeresztNev { get; set; }
        
        [DisplayName("Osztályzatok")]
        public List<OsztalyzatModel> Osztalyzatok { get; set; }

        public TanuloModel()
        {

        }

        public TanuloModel(int tanuloId, int osztalyId, string vezetekNev, string keresztNev)
        {
            TanuloId = tanuloId;
            OsztalyId = osztalyId;
            VezetekNev = vezetekNev;
            KeresztNev = keresztNev;
            osztalyzatok = new List<OsztalyzatModel>();
        }

    }
}
