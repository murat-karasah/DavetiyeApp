using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeEntities
{
   public class Davetiye
    {
        public int Id { get; set; }
        [Required]
        public string KatilimciAd { get; set; }
        [Required]
        public string KatilimciSoyad { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string KatilimciTelefon { get; set; }
        [Required]
        public bool katılım { get; set; }
    }
}
