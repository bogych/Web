namespace BlyatRotEbalWeb.Models
{
    public class Perefiria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "name field is required")]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "name field is required")]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string ModelCode { get; set; }
        [Required(ErrorMessage = "name field is required")]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Sostav { get; set; }
        [Required(ErrorMessage = "name field is required")]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Mesto { get; set; }
        public string Sost { get; set; }
    }
}
