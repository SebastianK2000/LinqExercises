using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinqEntities db = new LinqEntities();
            // zapytanie wyświetla tabelę pracownik
            dataGridView1.DataSource = db.Pracownik.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LinqEntities db = new LinqEntities();
            // zapytanie wyświetla tylko imie i nazwisko
            dataGridView1.DataSource = 
                (
                from pracownik in db.Pracownik
                select new
                {
                    pracownik.Imie,
                    pracownik.Nazwisko,
                }
                ).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LinqEntities db = new LinqEntities();
            // zapytanie wyświetla pracowników którzy zarabiają więcej niż 7000
            dataGridView1.DataSource =
                (
                from pracownik in db.Pracownik
                where pracownik.Placa>=8000
                select new
                {
                    pracownik.Imie,
                    pracownik.Nazwisko,
                    pracownik.Placa,
                }
                ).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LinqEntities db = new LinqEntities();
            // wartości do zapytania z textboxów
            decimal a = decimal.Parse(textBox1.Text); // zamieniamy na decimal text z textbox1
            decimal b = decimal.Parse(textBox2.Text); // zamieniamy na decimal text z textbox2

            dataGridView1.DataSource =
                (
                from pracownik in db.Pracownik
                where pracownik.Placa >= a && pracownik.Placa <= b
                select new
                {
                    pracownik.Imie,
                    pracownik.Nazwisko,
                    pracownik.Placa,
                }
                ).ToList();
        }

        private void button40_Click(object sender, EventArgs e)

        {

            //ten obiekt daje dostep do bazy

            LinqEntities db = new LinqEntities();

            //pobieramy wszystkie kolumny pracownika

            dataGridView1.DataSource = db.Pracownik.ToList();

        }

        /*

        private void button2_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            //tylko wybrane kolumny

            dataGridView1.DataSource =

                (

                    from pracownik in db.Pracownik

                    select new

                    {

                        pracownik.Imie,

                        pracownik.Nazwisko,

                        pracownik.Stanowisko

                    }

                ).ToList();

        }



        private void button4_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            //tylko wybrane kolumny II wersja

            dataGridView1.DataSource =

                db.Pracownik.Select(pracownik =>

                new { pracownik.Imie, pracownik.Nazwisko, pracownik.Stanowisko }).ToList();



        }



        private void button3_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            //tylko wybrane rekordy

            dataGridView1.DataSource =

                (

                    from pracownik in db.Pracownik

                    where pracownik.Placa >= 7000

                    select new

                    {

                        pracownik.Imie,

                        pracownik.Nazwisko,

                        pracownik.Placa

                    }

                ).ToList();

        }
        */


        private void button6_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            //tylko wybrane rekordy

            dataGridView1.DataSource =

                (

                    from pracownik in db.Pracownik

                    where pracownik.Placa >= 7000 && pracownik.Placa <= 10000

                    select new

                    {

                        pracownik.Imie,

                        pracownik.Nazwisko,

                        pracownik.Placa

                    }

                ).ToList();

        }



        private void button5_Click(object sender, EventArgs e)

        {

            decimal a = Convert.ToDecimal(textBox1.Text); //do mina wsatwiamy teskt z textBox1 zamieniony na double

            decimal b = Convert.ToDecimal(textBox2.Text);



            LinqEntities db = new LinqEntities();

            //tylko wybrane rekordy

            dataGridView1.DataSource =

                (

                    from pracownik in db.Pracownik

                    where pracownik.Placa >= a && pracownik.Placa <= b

                    select new

                    {

                        pracownik.Imie,

                        pracownik.Nazwisko,

                        pracownik.Placa

                    }

                ).ToList();

        }



        private void button8_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            //tylko wybrane rekordy

            dataGridView1.DataSource = db.Pracownik

                .Where(p => p.Placa >= 7000 && p.Placa <= 10000).ToList();

        }



        private void button7_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            dataGridView1.DataSource = db.Pracownik

                .Where(p => p.Placa >= 7000 && p.Placa <= 10000).Select(pracownik =>

                new { pracownik.Imie, pracownik.Nazwisko, pracownik.Placa }).ToList();





        }



        private void button16_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            //sortujemy po płacy netto, orderby - sortowanie

            dataGridView1.DataSource =

                (

                    from pracownik in db.Pracownik

                    where pracownik.Placa >= 3000

                    orderby pracownik.Placa

                    select new

                    {

                        pracownik.Imie,

                        pracownik.Nazwisko,

                        pracownik.Placa

                    }

                ).ToList();

        }



        private void button15_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            //sortujemy po płacy netto malejąco

            dataGridView1.DataSource =

                (

                    from pracownik in db.Pracownik

                    where pracownik.Placa >= 3000

                    orderby pracownik.Placa descending

                    select new

                    {

                        pracownik.Imie,

                        pracownik.Nazwisko,

                        pracownik.Placa

                    }

                ).ToList();

        }



        private void button14_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            //sortujemy po płacy netto a w ramach tej samej placy po nazwisku

            dataGridView1.DataSource =

                (

                    from pracownik in db.Pracownik

                    orderby pracownik.Placa, pracownik.Nazwisko

                    select new

                    {

                        pracownik.Imie,

                        pracownik.Nazwisko,

                        pracownik.Placa

                    }

                ).ToList();

        }



        private void button13_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            dataGridView1.DataSource = db.Pracownik

                .Where(p => p.Placa >= 5000 && p.Placa <= 30000)

                .OrderBy(p => p.Placa)

                .Select(pracownik =>

                new { pracownik.Imie, pracownik.Nazwisko, pracownik.Placa }).ToList();

        }



        private void button12_Click(object sender, EventArgs e)

        {

            //wyswietlimy kazde satnowisko tylko raz

            LinqEntities db = new LinqEntities();

            dataGridView1.DataSource =

                (

                    from pracownik in db.Pracownik

                    group pracownik by pracownik.Stanowisko

                ).ToList();

        }



        private void button11_Click(object sender, EventArgs e)

        {



            LinqEntities db = new LinqEntities();

            //wyswietlimy kazde satnowisko tylko raz tylko pry pomocy distinct

            dataGridView1.DataSource =

                (

                    from pracownik in db.Pracownik

                    select new

                    {

                        pracownik.Stanowisko

                    }

                ).Distinct().ToList();

        }



        private void button10_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            //dodajemy nową kolumnę obliczaną 

            dataGridView1.DataSource =

                (

                    from pracownik in db.Pracownik

                    select new

                    {

                        pracownik.Imie,

                        pracownik.Nazwisko,

                        pracownik.Placa,

                        Podatek = pracownik.Placa * 20 / 100

                    }

                ).ToList();

        }



        private void button9_Click(object sender, EventArgs e)

        {

            //zapytanie wyświetli sumę wszsytkich pensji pracowników

            LinqEntities db = new LinqEntities();

            label1.Text = "Suma wyplat: " +

                (

                    from pracownik in db.Pracownik

                    select pracownik.Placa

                ).Sum().ToString();

        }



        private void button24_Click(object sender, EventArgs e)

        {

            //zapytanie wyświetli minimalna place

            LinqEntities db = new LinqEntities();

            label1.Text = "Min wyplata: " +

                (

                    from pracownik in db.Pracownik

                    select pracownik.Placa

                ).Min().ToString();

        }



        private void button23_Click(object sender, EventArgs e)

        {

            //zapytanie wyświetli max place

            LinqEntities db = new LinqEntities();

            label1.Text = "Min wyplata: " +

                (

                    from pracownik in db.Pracownik

                    select pracownik.Placa

                ).Max().ToString();

        }



        private void button22_Click(object sender, EventArgs e)

        {

            //zapytanie wyświetli sumę wszsytkich pensji pracowników

            LinqEntities db = new LinqEntities();

            label1.Text = "Suma wyplat: " +

                (

                    from pracownik in db.Pracownik

                    select new

                    {

                        pracownik.Imie,

                        pracownik.Nazwisko,

                        pracownik.Placa

                    }

                ).Sum(p => p.Placa).ToString();

        }



        private void button21_Click(object sender, EventArgs e)

        {

            //zapytanie wyświetli srednią place

            LinqEntities db = new LinqEntities();

            label1.Text = "Srednia placa: " +

                (

                    from pracownik in db.Pracownik

                    select pracownik.Placa



                ).Average().ToString();

        }



        private void button20_Click(object sender, EventArgs e)

        {

            //zapytanie sprawdzi...

            LinqEntities db = new LinqEntities();

            var zapytanie1 =

                 (

                    from pracownik in db.Pracownik

                    select pracownik.Placa



                ).Any(p => p >= 20000);

            if (zapytanie1 == true)

                label1.Text = "Jest płaca >=20000";

            else

                label1.Text = "Brak placy >=20000";



        }



        private void button19_Click(object sender, EventArgs e)

        {

            //zapytanie sprawdzimy czy wszystkie place są wieksze od 7000

            LinqEntities db = new LinqEntities();

            var zapytanie1 =

                 (

                    from pracownik in db.Pracownik

                    select pracownik.Placa

                ).All(p => p >= 7000); //all - czy wszystkie 

            if (zapytanie1 == true)

                label1.Text = "Wszystkie place >=7000";

            else

                label1.Text = "Jest placa <7000";

        }



        private void button18_Click(object sender, EventArgs e)

        {

            //pobieramy tylko 2 pierwsze rekordy

            LinqEntities db = new LinqEntities();

            //dodajemy nową kolumnę obliczaną 

            dataGridView1.DataSource =

                (

                    from pracownik in db.Pracownik

                    orderby pracownik.Nazwisko //sortowanie wzgledem nazwiska

                    select new

                    {

                        pracownik.Imie,

                        pracownik.Nazwisko,

                        pracownik.Placa,

                    }

                ).Take(2).ToList();

        }



        private void button17_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            label1.Text = db.Pracownik.Average(p => p.Placa).ToString();

        }



        private void button32_Click(object sender, EventArgs e)

        {

            //pobieramy pierwszego pracownika

            LinqEntities db = new LinqEntities();

            var pierwszy = db.Pracownik.First();

            label1.Text = "Pierwszy pracownik: " + pierwszy.Imie + " " + pierwszy.Nazwisko;

        }



        //private void button31_Click(object sender, EventArgs e)

        //{

        //    //pobieramy praownika o id ==1

        //    LinqEntities db = new LinqEntities();

        //    var pierwszy = db.Pracownik.First(p => p.IdPracownika == 1);

        //    label1.Text = "Pracownik o id==1: " + pierwszy.Imie + " " + pierwszy.Nazwisko;

        //}



        //private void button30_Click(object sender, EventArgs e)

        //{

            //co zrobić jak takiego pracownika brak

            //warto zawsze FirstOrDefault

            //ta funkcja zwraca pracownika jak jest, a zwaraca null jak go brak

        //    LinqEntities db = new LinqEntities();

        //    var pracownik = db.Pracownik.FirstOrDefault(p => p.IdPracownika == 100);

        //    if (pracownik == null)

        //        label1.Text = "Brak pracownika o Id==100";

        //    else

        //        label1.Text = "Pracownik o id==100: " + pracownik.Imie + " " + pracownik.Nazwisko;

        //}



        private void button29_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            var pracownik = db.Pracownik.FirstOrDefault(p => p.Placa >= 20000);

            if (pracownik == null)

                label1.Text = "Brak pracownika o placy >=20000";

            else

                label1.Text = "Pracownik o placy >= 20 000: "

                    + pracownik.Imie + " " + pracownik.Nazwisko;



        }



        private void button28_Click(object sender, EventArgs e)

        {

            LinqEntities db = new LinqEntities();

            var pracownik =

                (

                    from p in db.Pracownik

                    where p.Placa >= 1000

                    orderby p.Placa

                    select p

                ).FirstOrDefault();

            if (pracownik == null)

                label1.Text = "Brak pracownika o placy >=20000";

            else

                label1.Text = "Pracownik o placy >= 20 000: "

                    + pracownik.Imie + " " + pracownik.Nazwisko;

        }



        //private void button27_Click(object sender, EventArgs e)

        //{

        //    //pobieramy tylko jeden rekord

        //    LinqEntities db = new LinqEntities();

        //    var pracownik = db.Pracownik.Single(p => p.IdPracownika == 1);

        //    label1.Text = "Pracownik o id==1: "

        //            + pracownik.Imie + " " + pracownik.Nazwisko;

        //}



        private void button26_Click(object sender, EventArgs e)

        {

            //zapytania zag....

            LinqEntities db = new LinqEntities();



            var zapytanie1 =

                (

                   from pracownik in db.Pracownik

                   select pracownik

                );



            var zapytanie2 =

                (

                    from pracownik in zapytanie1

                    where pracownik.Placa >= 7000

                    select pracownik

                );



            var zapytanie3 =

                (

                    from pracownik in zapytanie2

                    orderby pracownik.Placa

                    select pracownik

                );



            var zapytanie4 =

               (

                   from pracownik in zapytanie3

                   select new

                   {

                       pracownik.Imie,

                       pracownik.Nazwisko,

                       pracownik.Placa

                   }

               );



            dataGridView1.DataSource = zapytanie4.ToList();

        }



        private void button25_Click(object sender, EventArgs e)

        {

            //Procedura dodawania rekordu/obiektu do kolekcji 

            LinqEntities db = new LinqEntities();

            //1. Tworzymy pusty obiekt

            Pracownik nowy = new Pracownik();

            //2. Wypełniamy go danymi

            nowy.Imie = "Imie1";

            nowy.Nazwisko = "Nazwisko1";

            nowy.Stanowisko = "Stanowisko1";

            nowy.Placa = 1;

            //3. dodajemy go do lokalnej kolekcji 

            db.Pracownik.Add(nowy);

            //4. Wysłać zmiany do bazy danych - zapisać pracownika

            db.SaveChanges();



        }



        private void button39_Click(object sender, EventArgs e)

        {

            //Procedura modyfikowania rekordu - obiektu

            LinqEntities db = new LinqEntities();

            //1. Szukamy rekordu/obiektu

            //var pracownik = db.Pracownik.FirstOrDefault(p => p.IdPracownika == 6);

            //find dostaje id

            var pracownik = db.Pracownik.Find(7);

            //2. Modyfikujemy wybrane dane rekordu

            pracownik.Nazwisko = "Nowe nazwisko";

            pracownik.Placa = 50000;

            //3. Zapisujemy zmiany do bazy danych

            db.SaveChanges();

        }



        private void button38_Click(object sender, EventArgs e)

        {

            //Procedura kasowania rekordu 

            LinqEntities db = new LinqEntities();

            //1. Szukamy rkordu/obiektu do wykasowania

            var pracownik = db.Pracownik.Find(7);

            //2. Kasujemy obiket

            db.Pracownik.Remove(pracownik);

            //3. Zapisujemy zmiany w bazie

            db.SaveChanges();



        }



        //private void button37_Click(object sender, EventArgs e)

        //{

        //    //wysiwetlamy wszystkie płaty, ale tam jest klucz obcy idPracownika

        //    LinqEntities db = new LinqEntities();

        //    dataGridView1.DataSource =

        //        (

        //            from wyplata in db.Wyplata

        //            select new

        //            {

        //                wyplata.IdWyplaty,

        //                wyplata.IdPracownika,

        //                wyplata.Kwota,

        //                wyplata.DataWyplaty

        //            }

        //        ).ToList();

            //ale wyswietlanie klucza obcego IdPracownka jest mało funkcjonalne 

       // }



        //private void button36_Click(object sender, EventArgs e)

        //{

        //    LinqEntities db = new LinqEntities();

        //    dataGridView1.DataSource =

        //        (

        //            from wyplata in db.Wyplata

        //            select new

        //            {

        //                wyplata.IdWyplaty,

        //                Imie = wyplata.IdPracownikaNavigation.Imie,

        //                Nazwisko = wyplata.IdPracownikaNavigation.Nazwisko,

        //                wyplata.Kwota,

        //                wyplata.DataWyplaty

        //            }

        //        ).ToList();
        //}
        }
}
