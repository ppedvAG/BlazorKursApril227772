using System.ComponentModel.DataAnnotations;

namespace BlazorKursApril227772.Pages.Modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Da muss was rein")]
        [StringLength(10,ErrorMessage ="max 10")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        public DateTime GebDat { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        [Range(120,190, ErrorMessage ="zwischen 120 und 190")]
        public int Gross { get; set; }
    }
}
