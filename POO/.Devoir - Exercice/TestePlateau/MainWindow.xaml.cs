using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TestePlateau
{
    public partial class MainWindow : Window
    {
        TextBlock[,] txtBlock = new TextBlock[13, 13];
        TextBlock[] txtBCarte;
        TextBlock[] txtBPseudo = new TextBlock[4];
        TextBlock txtDe = new TextBlock();

        public MainWindow()
        {
            InitializeComponent();
            prepareInterface();
        }

        public void prepareInterface()
        {
            int indicateurC = 0;
            int indicateurL = 0;
            int indicateurLC = 2;
            int indicateurLJ = 0;

            string pseudo1 = "test1";
            string pseudo2 = "test2";
            string pseudo3 = "test3";   
            string pseudo4 = "test4";

            int tailleCase = 60;

            grdPlateau.Children.Clear();
            grdPlateau.RowDefinitions.Clear();
            grdPlateau.ColumnDefinitions.Clear();
            grdPlateau.Background = Brushes.FloralWhite;

            // ====== GRILLE PRINCIPALE (20x20 CASES CARRÉES) ======
            for (int i = 0; i < 100; i++)
            {
                grdPlateau.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(tailleCase)
                });

                grdPlateau.RowDefinitions.Add(new RowDefinition
                {
                    Height = new GridLength(tailleCase)
                });
            }

            // ====== BOUTON DÉ ======
            Button de = new Button
            {
                Content = "Lancer le Dé",
                FontSize = 25,
                FontWeight = FontWeights.Bold,
                Width = tailleCase * 3,
                Height = tailleCase * 2,
                BorderBrush = Brushes.Black
            };

            grdPlateau.Children.Add(de);
            Grid.SetColumn(de, 16);
            Grid.SetRow(de, 16);
            Grid.SetColumnSpan(de, 4);
            Grid.SetRowSpan(de, 2);

            // ====== TEXTE DÉ ======
            txtDe.FontSize = 20;
            txtDe.FontWeight = FontWeights.Bold;
            txtDe.Background = Brushes.Red;
            txtDe.TextAlignment = TextAlignment.Center;

            grdPlateau.Children.Add(txtDe);
            Grid.SetColumn(txtDe, 16);
            Grid.SetRow(txtDe, 14);
            Grid.SetColumnSpan(txtDe, 4);

            // ====== CÔTÉ JOUEURS ======
            string[] pseudos = { pseudo1, pseudo2, pseudo3, pseudo4 };

            for (int i = 0; i < txtBPseudo.Length; i++)
            {
                txtBPseudo[i] = new TextBlock
                {
                    Text = pseudos[i],
                    FontSize = 20,
                    FontWeight = FontWeights.Bold,
                    VerticalAlignment = VerticalAlignment.Center
                };

                grdPlateau.Children.Add(txtBPseudo[i]);
                Grid.SetColumn(txtBPseudo[i], 0);
                Grid.SetRow(txtBPseudo[i], indicateurLJ);
                Grid.SetColumnSpan(txtBPseudo[i], 10);
                indicateurLJ++;
            }

            // ====== CÔTÉ CARTES ======
            string[] cartes = { "MATH", "FRANCAIS", "GEO", "HISTOIRE", "ANGLAIS", "SCIENCE" };
            Brush[] couleurs = { Brushes.OrangeRed, Brushes.RoyalBlue, Brushes.Yellow, Brushes.Orange, Brushes.MediumPurple, Brushes.SpringGreen };
            TextBlock[] txtBCarte = new TextBlock[cartes.Length];

            int n = Math.Min(txtBCarte.Length, Math.Min(cartes.Length, couleurs.Length));
            for (int i = 0; i < n; i++)
            {
                txtBCarte[i] = new TextBlock
                {
                    Text = cartes[i],
                    Background = couleurs[i],
                    FontSize = 28,
                    FontWeight = FontWeights.Bold,
                    TextAlignment = TextAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };

                grdPlateau.Children.Add(txtBCarte[i]);
                Grid.SetColumn(txtBCarte[i], 16);
                Grid.SetRow(txtBCarte[i], indicateurLC);
                Grid.SetColumnSpan(txtBCarte[i], 4);
                Grid.SetRowSpan(txtBCarte[i], 2);
                indicateurLC += 2;
            }

            // ====== PLATEAU DE JEU 13x13 (CASES CARRÉES) ======
            indicateurC = 0;
            indicateurL = 0;

            for (int col = 0; col < 13; col++)
            {
                for (int row = 0; row < 13; row++)
                {
                    if (indicateurC == 0 || indicateurL == 0 ||
                        indicateurC == 6 || indicateurL == 6 ||
                        indicateurC == 12 || indicateurL == 12)
                    {
                        Border borderCell = new Border
                        {
                            Width = tailleCase,
                            Height = tailleCase,
                            BorderBrush = Brushes.Black,
                            BorderThickness = new Thickness(2)
                        };

                        txtBlock[col, row] = new TextBlock
                        {
                            FontSize = 18,
                            FontWeight = FontWeights.Bold,
                            TextAlignment = TextAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center,
                            HorizontalAlignment = HorizontalAlignment.Center
                        };

                        borderCell.Child = txtBlock[col, row];

                        Grid.SetColumn(borderCell, indicateurC + 3);
                        Grid.SetRow(borderCell, indicateurL + 3);

                        grdPlateau.Children.Add(borderCell);
                    }
                    indicateurC++;
                }
                indicateurC = 0;
                indicateurL++;
            }
        }
    }
}