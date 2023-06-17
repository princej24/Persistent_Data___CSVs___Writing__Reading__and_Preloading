using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using CsvHelper;


namespace Persistent_Data___CSVs___Writing__Reading__and_Preloading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string filePath = "students.CSV";
        List<Student> loadstudents = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();

           //Preload();

         

          

            MessageBox.Show(loadstudents.Count.ToString());

        }
        public void LoadCSV(List<Student> list)
        {

            using (StreamReader sr = new StreamReader(filePath))
            using (CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture))
            {

                loadstudents = csv.GetRecords<Student>().ToList();
            }

        }
        public void Preload()

        {

            List<Student> students = new List<Student>
            {
             new Student ("wiil", "cram" , 40 , 40 ),
             new Student ("jeff", "muturi" , 70 , 42 )

            };
            SaveCSVfile(filePath, students);
        }

        public void SaveCSVfile<T>(string filePath, List<T> list)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
           // string filePath = "students.csv";

            using (var stream = File.Open(filePath, FileMode.OpenOrCreate))
            using (var writer = new StreamWriter(stream))
            using (var csvWriter = new CsvWriter(writer, ci))
            {
                // .WriteRecords(list);
                csvWriter.WriteRecords(list);
                writer.Flush();
            }
        }

    }
}
