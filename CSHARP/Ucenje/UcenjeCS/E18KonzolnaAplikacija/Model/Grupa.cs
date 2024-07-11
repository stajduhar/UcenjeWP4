﻿namespace UcenjeCS.E18KonzolnaAplikacija.Model
{
    internal class Grupa : Entitet
    {
        public string? Naziv { get; set; }
        public Smjer? Smjer { get; set; }
        public string? Predavac { get; set; }
        public int? MaksimalnoPolaznika { get; set; }
        public List<Polaznik>? Polaznici { get; set; }

    }
}