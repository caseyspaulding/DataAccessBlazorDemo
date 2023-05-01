using System.ComponentModel.DataAnnotations;

namespace DataAccessBlazor.Models
{
    public class SearchModel
    {
        [Required]
        public string SearchTerm { get; set; }
    }
}
