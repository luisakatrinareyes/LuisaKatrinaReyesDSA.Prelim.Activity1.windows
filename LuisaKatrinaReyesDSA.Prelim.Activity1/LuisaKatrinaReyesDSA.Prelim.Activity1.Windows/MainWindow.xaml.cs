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

namespace LuisaKatrinaReyesDSA.Prelim.Activity1.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> Exams;
        List<string> Removed;

        public MainWindow()
        {
            InitializeComponent();
            Exams = new List<string>()
            {
               "Joy",
               "Xyrille",
               "Kath"
            };

            Removed = new List<string>()
            {
               
            };
        }

        
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Exams.Add(txtNewExam.Text);
            lstExams.Items.Clear();
            lstRemoved.Items.Remove(txtNewExam.Text);


            foreach (string exam in Exams)
                {
                lstExams.Items.Add(exam);
                }

        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            Exams.Remove(txtNewExam.Text);
            lstExams.Items.Remove(txtNewExam.Text);
            lstRemoved.Items.Add(txtNewExam.Text);
            Removed.Add(txtNewExam.Text);
            lstRemoved.Items.Clear();

            foreach (string remove in Removed)
            {
                lstRemoved.Items.Add(remove);
            }
        }

        private void BtnMoveAll_Click(object sender, RoutedEventArgs e)
        {
            lstExams.Items.Clear();
            foreach (string item in Removed)
            {
                Exams.Add(item);
            }
            foreach(string exam in Exams)
            {
                lstExams.Items.Add(exam);
            }
            Removed.Clear();
            lstRemoved.Items.Clear();
            
        }

        private void Btnclear_Click(object sender, RoutedEventArgs e)
        {
            lstRemoved.Items.Clear();
            Removed.Clear();
        }
    }
}
