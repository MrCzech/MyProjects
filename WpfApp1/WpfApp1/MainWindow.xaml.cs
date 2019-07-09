using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string NameOfTheInitialFile = @"G:\PRA\Wizualizacje\StruxureWare";
        List<TextBox> PolaWyswietlajaceWartosci;
        public MainWindow()
        {
            InitializeComponent();
            PolaWyswietlajaceWartosci = new List<TextBox>{ NrAplikacji_Label,
                KGrz_Y1_Label,KGrz_Y2_Label,KGrz_Y3_Label,KGrz_Y4_Label,KGrz_Y5_Label,KGrz_Y6_Label,KGrz_Tmax_Label2,KGrz_Tmin_Label2,
            LatoStartDzien_Label,LatoStartMiesiac_Label,LatoTempWylaczenia_Label,LatoFiltr_Label,
            ZimaStartDzien_Label,ZimaStartMiesiac_Label,ZimaTempWylaczenia_Label,ZimaFiltr_Label,
            OT_TempWyzszaZew_Label,OT_TempNizszaZew_Label,OT_GornyLimit_Label,OT_DolnyLimit_Label};

        }

        private void LoadECL_DataClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".ecl";
            openFileDialog.Filter = "Plik ECLTool (.ecl)|*.ecl";
            openFileDialog.InitialDirectory = NameOfTheInitialFile;
            openFileDialog.ShowDialog();
            string pathToSelectedFile = openFileDialog.FileName;
            pathToFile_TextBox.Text = pathToSelectedFile;

            XML_Reader ECLConfigurationFile = new XML_Reader(pathToSelectedFile);
            ECLConfigurationFile.GetValueOfparameter(PolaWyswietlajaceWartosci);



        }
    }
}
