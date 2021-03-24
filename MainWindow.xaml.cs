using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace VirtualizationIssue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new TimeTable();
        }
    }


    public class TimeTable
    {
        public ObservableCollection<DaySchedule> DaySchedules { get; set; } = new ObservableCollection<DaySchedule>();

        public TimeTable()
        {
            for (int i = 0; i < 2000; i++)
            {
                DaySchedules.Add(new DaySchedule(i));
            }
        }
    }

    public class DaySchedule
    {
        public ObservableCollection<Appointment> Appointments { get; set; } = new ObservableCollection<Appointment>();

        public DaySchedule(int i)
        {
            Name = $"Name: {i}";
            for (int j = 0; j < 2000; j++)
            {
                Appointments.Add(new Appointment() { DateTime = DateTime.Now + TimeSpan.FromDays(j) });
            }
        }

        public string Name { get; set; }
    }

    public class Appointment
    {
        public DateTime DateTime { get; set; }
    }
}
