using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100uam.Elements
{
    public class Wydzialy : Otoczenie
    {
        public List<Personel> PracownicyPersonelu = new List<Personel>();
        public List<Wykladwca> PracownicyWykladowcy = new List<Wykladwca>();

        int utrzymanie;
        string description;

        public Wydzialy(string name, string description, int cost, int utrzymanie) : base(name, description, cost, utrzymanie)
        {
            this.utrzymanie = utrzymanie;
            this.description = description;
        }


        public void UsunWydzial()
        {
               
        }


        public  int GetUtrzymanieD
        {
            get
            {

                int utrzymanied = 0;
                foreach (Personel personel in PracownicyPersonelu)
                {
                    utrzymanied = utrzymanied + personel.Utrzymanie;
                }
                foreach (Wykladwca wykl in PracownicyWykladowcy)
                {
                    utrzymanied = utrzymanied + wykl.Utrzymanie;
                }
                utrzymanied = utrzymanied + utrzymanie;
                return utrzymanied;
            }
            
        }

        public void AddPersonel()
        {
            PracownicyPersonelu.Add(new Personel());
        }

        public void AddWykladowca()
        {
            PracownicyWykladowcy.Add(new Wykladwca());
        }

        public void DeleteWykladowca()
        {
            PracownicyWykladowcy.Remove(PracownicyWykladowcy[PracownicyWykladowcy.Count - 1]);
        }

        public void DeletePersonel()
        {
            PracownicyPersonelu.Remove(PracownicyPersonelu[PracownicyPersonelu.Count-1]);
                
        }

        public int GetZadowolenie
        {
            get
            {
                int liczba = 0;
                if (LiczbaWykladowcow <= 10)
                {
                    liczba = LiczbaWykladowcow * 4 + LiczbaPersonelu * 10;
                    if (liczba > 100)
                        return 100;
                    else
                        return liczba;

                }
                else
                {
                    liczba = 40 + LiczbaPersonelu * 10 - ((LiczbaWykladowcow - 10) * 2);
                    if (liczba > 100)
                        return 100;
                    else
                        return liczba;
                }
            }
        }

        public int GetPrestiz
        {
            get
            {
                int liczba = LiczbaWykladowcow * 4;
                if (liczba > 100)
                    return 100;
                else if (LiczbaWykladowcow <= 0)
                    return 0;
                else
                    return liczba;
            }
        }

        public int LiczbaStudentow
        {
            get
            {
                if (LiczbaWykladowcow == 0)
                    return 0;
                else
                    return 10 * GetZadowolenie + 12 * GetPrestiz;
            }
        }

        public int LiczbaWykladowcow
        {
            get
            {
                    return PracownicyWykladowcy.Count;             
            }
        }

        public int LiczbaPersonelu
        {
            get
            {
                return PracownicyPersonelu.Count;
            }
        }
        new public string GetDescription
        {
            get
            {
                Parser parser = new Parser();
                return description + "Cena: "+ parser.ParseNumber(GetCost.ToString()) + " zł\nLiczba studentów: " + LiczbaStudentow + "\nPrestiż: "+ GetPrestiz + "\n Zadowolenie: " + GetZadowolenie;
            }
        }
        public int GetWyplata
        {
            get
            {
                return GetPrestiz*200 + LiczbaStudentow*5 *200;
            }
        }
        
        public void Zburz()
        {
            PracownicyPersonelu.Clear();
            PracownicyWykladowcy.Clear();
        }
    }
}
