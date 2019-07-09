using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml;

namespace WpfApp1
{
    class XML_Reader
    {
        public XmlDocument XmlDoc;
        XmlNodeList AllParamsFromFile;
        public XML_Reader(string PathFile)
        {
            try
            {
                XmlDoc = new XmlDocument();
                XmlDoc.Load(PathFile);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Aplikacja zgłasza wyjątek..." + Environment.NewLine + ex.Message, "Błąd aplikacji...");
            }
            
        }

       
public void GetValueOfparameter(List<TextBox> pola)
        {
            NastawyObiektu nowyObiekt = new NastawyObiektu();
            AllParamsFromFile = XmlDoc.GetElementsByTagName("Param");
           
            foreach (XmlNode item in AllParamsFromFile)
            {
                enumNumbersOfParameters AdresyRejestrow = (enumNumbersOfParameters)int.Parse(item.Attributes.GetNamedItem("PNU").Value);
                string OdczytanaWartosc= item.Attributes.GetNamedItem("Value").Value;
                switch (AdresyRejestrow)
                {
                    case enumNumbersOfParameters.Application_cz1:
                        nowyObiekt.NumerAplikacji_cz1 = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.Application_cz2:
                        nowyObiekt.NumerAplikacji_cz2 = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.KGrz_y1:
                        nowyObiekt.KrzywaGrzewcza.Y1 = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.KGrz_y2:
                        nowyObiekt.KrzywaGrzewcza.Y2 = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.KGrz_y3:
                        nowyObiekt.KrzywaGrzewcza.Y3 = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.KGrz_y4:
                        nowyObiekt.KrzywaGrzewcza.Y4 = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.KGrz_y5:
                        nowyObiekt.KrzywaGrzewcza.Y5 = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.KGrz_y6:
                        nowyObiekt.KrzywaGrzewcza.Y6 = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.Tmax:
                        nowyObiekt.KrzywaGrzewcza.Tmax = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.Tmin:
                        nowyObiekt.KrzywaGrzewcza.Tmin = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.LatoTempWylacz:
                        nowyObiekt.PoraRokuLato.StartTempWylaczenia = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.LatoStartMiesiac:
                        nowyObiekt.PoraRokuLato.StartMiesiac = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.LatoStartDzien:
                        nowyObiekt.PoraRokuLato.StartDzien = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.LatoFiltr:
                        nowyObiekt.PoraRokuLato.Filtr = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.ZimaTempWylacz:
                        nowyObiekt.PoraRokuZima.StartTempWylaczenia = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.ZimaStartMiesiac:
                        nowyObiekt.PoraRokuZima.StartMiesiac = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.ZimaStartDzien:
                        nowyObiekt.PoraRokuZima.StartDzien = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.Filtr:
                        nowyObiekt.PoraRokuZima.Filtr = OdczytanaWartosc;

                        break;
                    case enumNumbersOfParameters.TempZewWyzsza_X1:
                        nowyObiekt.Ograniczenie.TempZewWyzsza_X1 = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.TempZewNizsza_X2:
                        nowyObiekt.Ograniczenie.TempZewNizsza_X2 = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.DolnyLimit_Y1:
                        nowyObiekt.Ograniczenie.DolnyLimit_Y1 = OdczytanaWartosc;
                        break;
                    case enumNumbersOfParameters.GornyLimit:
                        nowyObiekt.Ograniczenie.GornyLimit = OdczytanaWartosc;
                        break;
                    default:
                        break;
                }

            }
            nowyObiekt.WriteOnScreen(pola);

        }


    }
}
