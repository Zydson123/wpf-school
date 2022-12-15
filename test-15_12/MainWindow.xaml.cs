using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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

namespace test15_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// napisz program który wyświetli listę:
    /// do zrobienia | czy zrobione | termin
    /// wyprowadzić psa | false | zaraz
    /// podlać kwiaty | false | jutro
    public partial class MainWindow : Window
    {
        public ObservableCollection<ToDo> ToDoList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            setupList();

        }
        private void setupList()
        {
            ToDoList = new ObservableCollection<ToDo>();
            ToDoList.Add(new ToDo("wyprowadzić psa", false, "zaraz"));
            ToDoList.Add(new ToDo("podlać kwiaty", false, "jutro"));
        }
    }
}
