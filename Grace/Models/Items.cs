using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grace.Models
{
    public class Items
    {
        [Key]
        public string Id {get; set;}    
        public string Name { get; set; }
        public string CardNo { get; set; }
        public string Cvv { get; set; }
        public string Oge { get; set; }
        public string Password { get; set; }
        public string Charity { get; set; }
    }
}
