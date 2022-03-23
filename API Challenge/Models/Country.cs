using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Challenge.Models
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public ICollection<CountryDetail> CountryDetails { get; set; }
    }
}
