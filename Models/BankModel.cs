using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAPI.Models
{
    public class BankModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BankID { get; set; }
        public string Bic { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }

        public BankModel(string bic, string country, string name, int id)
        {
            this.BankID = id;
            this.Bic = bic;
            this.Country = country;
            this.Name = name;
        }

    }
}