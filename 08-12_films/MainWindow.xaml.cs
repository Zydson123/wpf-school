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

namespace _08._12_pies_hau
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Film SelectedMovie { get; set; }
        public IEnumerable<String> StringCollection
        {
            get;
            set;
        }
        public ObservableCollection<Film> AllFilms { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            StringCollection = "pies psi szczeka bo to pies hau hau hau".Split(' ').ToList();
            DataContext = this;
            setupMovies();
            SelectedMovie = AllFilms[0];
        }
        private void setupMovies()
        {
            AllFilms = new ObservableCollection<Film>();
            AllFilms.Add(new Film("Batman Begins", 10, "Batman the beggining", "Action"));
            AllFilms.Add(new Film("The Dark Knight", 11, "Le joker", "Action/Thriller"));
            AllFilms.Add(new Film("The Dark Knight Rises", 9, "Le Bane", "Action/Sensation"));
            AllFilms.Add(new Film("Interstellar", 10, "Cooper has to save da world", "Sci-fi"));
        }

        private void seeMovie(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(SelectedMovie.Name, "The selected movie is:", MessageBoxButton.OK);
        }

        private void add_movie(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(MovieRating.Text, out int rating))
            {
                string Name = title.Text;
                string Genre = movieGenre.Text;
                string Desc = description.Text;
                AllFilms.Add(new Film(Name, rating, Desc, Genre));
            }

        }
    }
}
