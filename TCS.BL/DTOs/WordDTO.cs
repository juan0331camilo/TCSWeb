using System.ComponentModel.DataAnnotations;

namespace TCS.BL.DTOs
{
    public class SearchWordDTO
    {
        [Required]
        public string Word { get; set; }

        [Required]
        public string Text { get; set; }
    }
}
