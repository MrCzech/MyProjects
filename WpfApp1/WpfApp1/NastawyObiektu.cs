using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
   
    class NastawyObiektu
    {
        
        public string NumerAplikacji_cz1;
        public string NumerAplikacji_cz2;
        private string NumerAplikacji { get { return NumerAplikacji_cz1 + "." + NumerAplikacji_cz2; } }
        public KrzywaGrzewcza KrzywaGrzewcza { get; set; }
        public PoraRoku PoraRokuLato { get; set; }
        public PoraRoku PoraRokuZima { get; set; }
        public OgraniczeniePowrotu Ograniczenie { get; set; }


        public NastawyObiektu()
        {
            KrzywaGrzewcza = new KrzywaGrzewcza();
            PoraRokuLato = new PoraRoku();
            PoraRokuZima = new PoraRoku();
            Ograniczenie = new OgraniczeniePowrotu();
        }

        public void WriteOnScreen(List<TextBox> pola)
        {
            pola[0].Text = NumerAplikacji;
            pola[1].Text = KrzywaGrzewcza.Y1;
            pola[2].Text = KrzywaGrzewcza.Y2;
            pola[3].Text = KrzywaGrzewcza.Y3;
            pola[4].Text = KrzywaGrzewcza.Y4;
            pola[5].Text = KrzywaGrzewcza.Y5;
            pola[6].Text = KrzywaGrzewcza.Y6;
            pola[7].Text = KrzywaGrzewcza.Tmax;
            pola[8].Text = KrzywaGrzewcza.Tmin;
            pola[9].Text = PoraRokuLato.StartDzien;
            pola[10].Text = PoraRokuLato.StartMiesiac;
            pola[11].Text = PoraRokuLato.StartTempWylaczenia;
            pola[12].Text = PoraRokuLato.Filtr;
            pola[13].Text = PoraRokuZima.StartDzien;
            pola[14].Text = PoraRokuZima.StartMiesiac;
            pola[15].Text = PoraRokuZima.StartTempWylaczenia;
            pola[16].Text = PoraRokuZima.Filtr;
            pola[17].Text = Ograniczenie.TempZewWyzsza_X1;
            pola[18].Text = Ograniczenie.TempZewNizsza_X2;
            pola[19].Text = Ograniczenie.GornyLimit;
            pola[20].Text = Ograniczenie.DolnyLimit_Y1;

        }

    }
}
