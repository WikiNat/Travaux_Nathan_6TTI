using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CeUAA14_WPF_janv26_Marcq
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Button[,] btnCases = new Button[0, 0];
        int[] positionPionJoueur = new int[] { 0, 0 };
        int totalJoueur1 = 0;
        string ancienneValeurJoueur1 = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        public void PrepareDamier(int taille)
        {
            Billy.Children.Clear();
            Billy.ColumnDefinitions.Clear();
            Billy.RowDefinitions.Clear();
            //c'est la partie définir
            ColumnDefinition[] columns = new ColumnDefinition[taille];
            RowDefinition[] rows = new RowDefinition[taille];
            btnCases = new Button[taille, taille];
            int[,] plateau = GenererplateauNumerique(taille);


            for (int i = 0; i < taille; i++)
            {
                Billy.ColumnDefinitions.Add(new ColumnDefinition());
                Billy.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < taille; i++)
            {
                for (int j = 0; j < taille; j++)

                {
                    Button btn = new Button();
                    btn.Content = plateau[i, j].ToString();

                    if ((i + j) % 2 == 0)
                    {
                        btn.Background = Brushes.Aqua;
                    }
                    else
                    {
                        btn.Background = Brushes.Red;
                    }
                    if (plateau[i, j] == 1)
                    {
                        positionPionJoueur[0] = i;
                        btn.Content = "X";
                        btn.Foreground = Brushes.Gold;

                    }

                    btnCases[i, j] = btn;
                    Grid.SetColumn(btn, j);
                    Grid.SetRow(btn, i);
                    Billy.Children.Add(btn);
                }
            }
        }
        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtTaille.Text, out int taille))
            {
                if (taille < 3 || taille > 10)
                {
                    MessageBox.Show("Tu sais pas lire? entre 3 et 10 pour la taille.");
                }
                else
                {
                    PrepareDamier(taille);
                }
            }
        }

        public void BtnSymboles_Click(object sender, RoutedEventArgs e)
        {
            string symbole = txtSymbole.Text.Trim().ToLower();
            Image ing = new Image(); // On peut déclarer ici pour l'utiliser ensuite

            if (symbole == "p")
            {
                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri("Image/p.png", UriKind.Relative);
                img.EndInit();
                ing.Source = img;
                ing.Stretch = Stretch.None;
            }
            else if (symbole == "h")
            {
                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri("Image/h.png", UriKind.Relative);
                img.EndInit();
                ing.Source = img;
                ing.Stretch = Stretch.None;
            }
            else
            {
                MessageBox.Show("Symbole invalide !");
                return;
            }
            btnCases[positionPionJoueur[0], positionPionJoueur[1]].Content = ing;
        }

        public void BtnAvancer_Click(object sender, RoutedEventArgs e)
        {
            TourJoueur("X", 1, ref totalJoueur1, ref positionPionJoueur, ref ancienneValeurJoueur1);
        }

        public void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            totalJoueur1 = 0;
            ancienneValeurJoueur1 = "";
            positionPionJoueur[0] = 0;
            positionPionJoueur[1] = 0;
            btnAvancer.IsEnabled = true;
            Billy.Children.Clear();
            Billy.ColumnDefinitions.Clear();
            Billy.RowDefinitions.Clear();
            txtDe.Text = "Dé : ";
        }

        static int[,] GenererplateauNumerique(int taille)
        {
            int[,] plateau = new int[taille, taille];
            int valeur = 1;

            // On part de la ligne du bas de la matrice et on remonte vers le haut
            for (int ligne = taille - 1; ligne >= 0; ligne--)
            {
                bool gaucheVersDroite = ((taille - 1 - ligne) % 2 == 0);    // permet de déterminer dans quel sens on compte. On aura une expression vraie quant on compte de gauche à droite

                if (gaucheVersDroite)
                {
                    //On rempli la ligne de gauche à droite en incrémentant le comptage
                    for (int colonne = 0; colonne < taille; colonne++)
                    {
                        plateau[ligne, colonne] = valeur++;
                    }
                }
                else
                {
                    //On rempli la ligne de droite à gauche en incrémentant le comptage
                    for (int colonne = taille - 1; colonne >= 0; colonne--)
                    {
                        plateau[ligne, colonne] = valeur++;
                    }
                }
            }

            return plateau;
        }
        public void TourJoueur(string symboleJoueur, int numeroJoueur, ref int totalJoueur, ref int[] positionPionJoueur, ref string ancienneValeur)
        {
            Random alea = new Random();         // nombre aléatoire
            int taille = btnCases.GetLength(0); // nombre de lignes dans le plateau
            int maxCases = taille * taille;     // nombre de cases maximum

            //dé sorti
            int de = alea.Next(1, 7);

            //modification de l'interface pour l'affichage du numéro du joueur et du dé
            txtQuiJoue.Text = "Joueur " + numeroJoueur;
            txtDe.Text = "Dé : " + de;

            //calcul total déjà parcouru par le joueur
            totalJoueur += de;

            //Si on dépasse le nombre total de cases, on fixe à la dernière possible
            if (totalJoueur > maxCases)
            {
                totalJoueur = maxCases;
            }

            //Retirer le symbole du joueur à l'ancienne position et faire apparaître le numéro qu'il cachait
            btnCases[positionPionJoueur[0], positionPionJoueur[1]].Content = ancienneValeur;
            btnCases[positionPionJoueur[0], positionPionJoueur[1]].Foreground = Brushes.Black;

            //recherche de la nouvelle position du joueur
            int index = totalJoueur - 1;

            int ligneDepuisBas = index / taille;
            int colonneDansLigne = index % taille;

            positionPionJoueur[0] = taille - 1 - ligneDepuisBas;

            bool gaucheVersDroite = ligneDepuisBas % 2 == 0;

            positionPionJoueur[1] = gaucheVersDroite
                ? colonneDansLigne
                : taille - 1 - colonneDansLigne;

            //Fin de partie
            if (totalJoueur == maxCases)
            {
                txtQuiJoue.Text = "Fin !";
                btnAvancer.IsEnabled = false;
            }

            //mémorisation du numéro de la case sur laquelle on va placer le symbole du joueur
            //+ affichage de ce symbole
            ancienneValeur = btnCases[positionPionJoueur[0], positionPionJoueur[1]].Content.ToString();
            btnCases[positionPionJoueur[0], positionPionJoueur[1]].Content = symboleJoueur;
            btnCases[positionPionJoueur[0], positionPionJoueur[1]].Foreground = Brushes.Gold;
        }

    }
}