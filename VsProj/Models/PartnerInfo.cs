using System.ComponentModel.DataAnnotations;

namespace VsProj.Models
{
    public class PartnerInfo
    {
        [Key]
        public int PARTNERID { get; set; }
        public string PARTNERNEV { get; set; }
        public int IRANYITOSZAM { get; set; }
        public string VAROS { get; set; }
        public string UTCA { get; set; }
        public DateTime ROGZIDO { get; set; }
    }
}
