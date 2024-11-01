using System.ComponentModel.DataAnnotations;

namespace Video_icerik.Models
{ 
        public class Icerik
        {
          public int IcerikId { get; set; }

          [Required(ErrorMessage = "YouTube Video ID bos gecilemez.")]
          [Display(Name = "YouTube Video ID")]
          public string? YouTubeVideoId { get; set; }

          [Required(ErrorMessage = "Baslik bos gecilemez.")]
          [Display(Name = "Baslik")]
          public string? Baslik { get; set; }

          [Required(ErrorMessage = "Uretim tarihi bos gecilemez.")]
          [Display(Name = "Yukleme Tarihi")]
          public DateTime UretimTarihi { get; set; }

          [Display(Name = "Egitmen Notlari")]
          public string? EgitmeninNotlari { get; set; }
 
          [Display(Name = "Kullanilan Teknolojiler")]
          public string? KullanilanTeknolojiler { get; set; } // virgülle ayrılmış veri
          public string? Kategori { get; set; }
        }
    
}
