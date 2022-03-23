using System.ComponentModel.DataAnnotations.Schema;

namespace API_Challenge.Models
{
    public class CountryDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }
}
