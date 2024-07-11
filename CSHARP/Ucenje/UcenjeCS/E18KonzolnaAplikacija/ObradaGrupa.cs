﻿using UcenjeCS.E18KonzolnaAplikacija.Model;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    internal class ObradaGrupa
    {

        public List<Grupa> Grupe { get; set; }
        private Izbornik Izbornik;

        public ObradaGrupa()
        {
            Grupe = new List<Grupa>();

        }
        public ObradaGrupa(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s grupama");
            Console.WriteLine("1. Pregled svih grupa");
            Console.WriteLine("2. Unos nove grupe");
            Console.WriteLine("3. Promjena podataka postojeće grupe");
            Console.WriteLine("4. Brisanje grupe");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNoveGrupe();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniPodatkeGrupe();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiGrupu();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void ObrisiGrupu()
        {
            PrikaziGrupe();
            var g = Grupe[
                Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za brisanje", 1, Grupe.Count) - 1
                ];
            if (Pomocno.UcitajBool("Sigurno obrisati " + g.Naziv + "? (DA/NE)", "da"))
            {
                Grupe.Remove(g);
            }
        }

        private void PromjeniPodatkeGrupe()
        {
            PrikaziGrupe();
            var g = Grupe[
                Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za promjenu", 1, Grupe.Count) - 1
                ];
            // copy paste s linije 102 - izvući u metodu
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);
            //smjer
            Izbornik.ObradaSmjer.PrikaziSmjerove();

            g.Smjer = Izbornik.ObradaSmjer.Smjerovi[
                Pomocno.UcitajRasponBroja("Odaberi redni broj smjera", 1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];

            g.Predavac = Pomocno.UcitajString("Unesi ime i prezime predavača", 50, true);
            g.MaksimalnoPolaznika = Pomocno.UcitajRasponBroja("Unesi maksimalno polaznika", 1, 30);

            // polaznici
            g.Polaznici = UcitajPolaznike();


        }

        private void PrikaziGrupe()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Grupe u aplikaciji");
            int rb = 0, rbp;
            foreach (var g in Grupe)
            {
                Console.WriteLine(++rb + ". " + g.Naziv + " (" + g.Smjer?.Naziv + "), " + g.Polaznici?.Count + " polaznika"); // prepisati metodu toString
                rbp = 0;
                g.Polaznici.Sort();
                foreach (var p in g.Polaznici)
                {
                    Console.WriteLine("\t" + ++rbp + ". " + p.Ime + " " + p.Prezime);
                }
            }
            Console.WriteLine("****************************");
        }

        private void UnosNoveGrupe()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o grupi");

            Grupa g = new Grupa();
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);
            //smjer
            Izbornik.ObradaSmjer.PrikaziSmjerove();

            g.Smjer = Izbornik.ObradaSmjer.Smjerovi[
                Pomocno.UcitajRasponBroja("Odaberi redni broj smjera", 1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];

            g.Predavac = Pomocno.UcitajString("Unesi ime i prezime predavača", 50, true);
            g.MaksimalnoPolaznika = Pomocno.UcitajRasponBroja("Unesi maksimalno polaznika", 1, 30);

            // polaznici
            g.Polaznici = UcitajPolaznike();

            Grupe.Add(g);
        }

        private List<Polaznik> UcitajPolaznike()
        {
            List<Polaznik> lista = new List<Polaznik>();
            while (Pomocno.UcitajBool("Za unos polaznika unesi DA", "da"))
            {
                Izbornik.ObradaPolaznik.PrikaziPolaznike();
                lista.Add(
                    Izbornik.ObradaPolaznik.Polaznici[
                        Pomocno.UcitajRasponBroja("Odaberi redni broj polaznika", 1,
                        Izbornik.ObradaPolaznik.Polaznici.Count) - 1
                        ]
                    );
            }

            return lista;
        }
    }
}