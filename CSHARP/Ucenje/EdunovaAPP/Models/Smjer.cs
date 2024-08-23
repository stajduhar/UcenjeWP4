﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EdunovaAPP.Models
{
    public class Smjer: Entitet
    {
        public string? Naziv { get; set; }
        public int? Trajanje { get; set; }
        public decimal? Cijena { get; set; }
        public DateTime? IzvodiSeOd { get; set; }
        
        [Column("verificiran")] // Ovo ne morate u svojim završnim radovima raditi
        public bool? Vaucher { get; set; }

    }
}
