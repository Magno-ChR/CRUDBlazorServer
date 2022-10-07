using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CRUDBlazorServer.Data
{
    [Table("currency",Schema ="crud")]
    public class CurrencyClass
    {
        [Key]
        public int id { get; set; }
        public string? nombre { get; set; }
        public decimal precio { get; set; }
    }
}
