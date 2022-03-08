using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DavetiyeUI.Models
{
    public class DavetiyeDto
    {
        public int Id { get; set; }
        public string KatilimciAd { get; set; }
        public string KatilimciSoyad { get; set; }
        public string email { get; set; }
        public string KatilimciTelefon { get; set; }
        [DisplayName("Katılıyorum")]
        public bool katılım { get; set; }
    }
}
