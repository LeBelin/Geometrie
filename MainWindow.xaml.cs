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

namespace Geometrie
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double coteCarre;      
        private double largeurRectangle; 
        private double longueurRectangle; 
        private double rayonCercle;     
        private double semiGrandAxe;    
        private double semiPetitAxe;     

        private double perimetreAttendu; 
        private double surfaceAttendue;   
        private string formeSelectionnee; // garde en mémoire la forme sélectionnée avant
        private const int MAX_ESSAIS = 3;

        private int nombreErreurs = 0; 

        public MainWindow()
        {
            InitializeComponent();
            btnValider.IsEnabled = false;
        }

        // --- Carré ---
        private void btnCarre_Click(object sender, RoutedEventArgs e)
        {
            formeSelectionnee = "Carre";
            GenererNouveauCarre();
            DessinerCarre();
            btnValider.IsEnabled = true;

            btnCarre.IsEnabled = false;
            btnRectangle.IsEnabled = true;
            btnTriangle.IsEnabled = true;
            btnCercle.IsEnabled = true;
            btnEllipse.IsEnabled = true;
        }

        private void GenererNouveauCarre()
        {
            Random rand = new Random();
            coteCarre = rand.Next(1, 11);
            perimetreAttendu = Math.Round(4 * coteCarre); // Arrondir le périmètre
            surfaceAttendue = Math.Round(coteCarre * coteCarre); // Arrondir la surface
            txtInfoForme.Text = $"Carré : Côté = {coteCarre}";
        }


        private void DessinerCarre()
        {
            canvasDessin.Children.Clear();
            Rectangle carre = new Rectangle
            {
                Width = coteCarre * 10,
                Height = coteCarre * 10,
                Stroke = Brushes.DeepSkyBlue,
                StrokeThickness = 3,
                Fill = Brushes.White
            };

            Canvas.SetLeft(carre, (canvasDessin.Width - carre.Width) / 2);
            Canvas.SetTop(carre, (canvasDessin.Height - carre.Height) / 2);
            canvasDessin.Children.Add(carre);
        }

        // --- Rectangle ---
        private void btnRectangle_Click(object sender, RoutedEventArgs e)
        {
            formeSelectionnee = "Rectangle";
            GenererNouveauRectangle();
            DessinerRectangle();
            btnValider.IsEnabled = true;

            btnCarre.IsEnabled = true;
            btnRectangle.IsEnabled = false;
            btnTriangle.IsEnabled = true;
            btnCercle.IsEnabled = true;
            btnEllipse.IsEnabled = true;
        }

        private void GenererNouveauRectangle()
        {
            Random rand = new Random();
            largeurRectangle = rand.Next(1, 11);
            longueurRectangle = rand.Next(1, 11);
            perimetreAttendu = Math.Round(2 * (largeurRectangle + longueurRectangle)); // Arrondir le périmètre
            surfaceAttendue = Math.Round(largeurRectangle * longueurRectangle); // Arrondir la surface
            txtInfoForme.Text = $"Rectangle : Largeur = {largeurRectangle}, Longueur = {longueurRectangle}";
        }

        private void DessinerRectangle()
        {
            canvasDessin.Children.Clear();
            Rectangle rectangle = new Rectangle
            {
                Width = largeurRectangle * 10, // Taille réduite
                Height = longueurRectangle * 10, // Taille réduite
                Stroke = Brushes.GreenYellow,
                StrokeThickness = 3,
                Fill = Brushes.White
            };

            Canvas.SetLeft(rectangle, (canvasDessin.Width - rectangle.Width) / 2);
            Canvas.SetTop(rectangle, (canvasDessin.Height - rectangle.Height) / 2);
            canvasDessin.Children.Add(rectangle);
        }

        //  --- Cercle ---
        private void btnCercle_Click(object sender, RoutedEventArgs e)
        {
            formeSelectionnee = "Cercle";
            GenererNouveauCercle();
            DessinerCercle();
            btnValider.IsEnabled = true;

            btnCarre.IsEnabled = true;
            btnRectangle.IsEnabled = true;
            btnTriangle.IsEnabled = true;
            btnCercle.IsEnabled = false;
            btnEllipse.IsEnabled = true;
        }

        private void GenererNouveauCercle()
        {
            Random rand = new Random();
            rayonCercle = rand.Next(1, 11);
            perimetreAttendu = Math.Round(2 * Math.PI * rayonCercle); // Arrondir le périmètre
            surfaceAttendue = Math.Round(Math.PI * rayonCercle * rayonCercle); // Arrondir la surface
            txtInfoForme.Text = $"Cercle : Rayon = {rayonCercle}";
        }

        // dessine un cercle 
        private void DessinerCercle()
        {
            canvasDessin.Children.Clear();
            Ellipse cercle = new Ellipse
            {
                Width = rayonCercle * 10, // Taille 
                Height = rayonCercle * 10, // Taille 
                Stroke = Brushes.Red,
                StrokeThickness = 3,
                Fill = Brushes.White
            };

            Canvas.SetLeft(cercle, (canvasDessin.Width - cercle.Width) / 2);
            Canvas.SetTop(cercle, (canvasDessin.Height - cercle.Height) / 2);
            canvasDessin.Children.Add(cercle);
        }

        // --- Ellipse ---
        private void btnEllipse_Click(object sender, RoutedEventArgs e)
        {
            formeSelectionnee = "Ellipse";
            GenererNouvelleEllipse();
            DessinerEllipse();
            btnValider.IsEnabled = true;

            btnCarre.IsEnabled = true;
            btnRectangle.IsEnabled = true;
            btnTriangle.IsEnabled = true;
            btnCercle.IsEnabled = true;
            btnEllipse.IsEnabled = false;
        }

        private void GenererNouvelleEllipse()
        {
            Random rand = new Random();
            semiGrandAxe = rand.Next(1, 11);
            semiPetitAxe = rand.Next(1, 11);
            perimetreAttendu = Math.Round(2 * Math.PI * Math.Sqrt((semiGrandAxe * semiGrandAxe + semiPetitAxe * semiPetitAxe) / 2.0)); // Arrondir le périmètre
            surfaceAttendue = Math.Round(Math.PI * semiGrandAxe * semiPetitAxe); // Arrondir la surface
            txtInfoForme.Text = $"Ellipse : Semi-grand axe = {semiGrandAxe}, Semi-petit axe = {semiPetitAxe}";
        }

        private void DessinerEllipse()
        {
            canvasDessin.Children.Clear();
            Ellipse ellipse = new Ellipse
            {
                Width = semiGrandAxe * 10, // Taille 
                Height = semiPetitAxe * 10, // Taille
                Stroke = Brushes.Yellow,
                StrokeThickness = 3,
                Fill = Brushes.White
            };

            Canvas.SetLeft(ellipse, (canvasDessin.Width - ellipse.Width) / 2);
            Canvas.SetTop(ellipse, (canvasDessin.Height - ellipse.Height) / 2);
            canvasDessin.Children.Add(ellipse);
        }

        // --- Triangle ---
        private void btnTriangle_Click(object sender, RoutedEventArgs e)
        {
            formeSelectionnee = "Triangle";
            GenererNouveauTriangle();
            DessinerTriangle();
            btnValider.IsEnabled = true;

            btnCarre.IsEnabled = true;
            btnRectangle.IsEnabled = true;
            btnTriangle.IsEnabled = false;
            btnCercle.IsEnabled = true;
            btnEllipse.IsEnabled = true;
        }

        private void GenererNouveauTriangle()
        {
            Random rand = new Random();
            double baseTriangle = rand.Next(1, 11);
            double hauteurTriangle = rand.Next(1, 11);
            double cote1 = rand.Next(1, 11);
            double cote2 = rand.Next(1, 11);
            perimetreAttendu = Math.Round(baseTriangle + cote1 + cote2); // Arrondir le périmètre
            surfaceAttendue = Math.Round((baseTriangle * hauteurTriangle) / 2); // Arrondir la surface
            txtInfoForme.Text = $"Triangle : Base = {baseTriangle}, Hauteur = {hauteurTriangle}, Côtés = {cote1}, Cotés = {cote2}";
        }


        private void DessinerTriangle()
        {
            canvasDessin.Children.Clear();
            Polygon triangle = new Polygon
            {
                Stroke = Brushes.Orange,
                StrokeThickness = 3,
                Fill = Brushes.White
            };

            triangle.Points.Add(new Point(canvasDessin.Width / 2, canvasDessin.Height / 2 - 15)); // Sommet
            triangle.Points.Add(new Point(canvasDessin.Width / 2 - 15, canvasDessin.Height / 2 + 15)); // Bas gauche
            triangle.Points.Add(new Point(canvasDessin.Width / 2 + 15, canvasDessin.Height / 2 + 15)); // Bas droit

            canvasDessin.Children.Add(triangle);
        }

        // Validation des résultats
        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double perimetreEntree = double.Parse(txtPerimetre.Text);
                double surfaceEntree = double.Parse(txtSurface.Text);

                if (perimetreEntree == perimetreAttendu && surfaceEntree == surfaceAttendue)
                {
                    txtResultat.Text = "Gagné !";

                    // Générer une nouvelle forme et réinitialiser le nombre d'erreurs
                    GenererNouvelleInformation();
                    ViderTextBox();
                    nombreErreurs = 0;
                    btnVoirReponse.Visibility = Visibility.Hidden;

                    ResultWindow resultWindow = new ResultWindow("Gagné !");
                    resultWindow.ShowDialog();
                }
                else
                {
                    nombreErreurs++;

                    int essaisRestants = MAX_ESSAIS - nombreErreurs;
                    txtResultat.Text = $"Faux ! Il vous reste {essaisRestants} essai(s).";

                    if (nombreErreurs >= MAX_ESSAIS)
                    {
                        btnValider.IsEnabled = false;
                        btnVoirReponse.Visibility = Visibility.Visible;
                        txtResultat.Text = "Encore Faux ! ...";
                    }

                    // Afficher la fenêtre de résultat pour une erreur
                    //ResultWindow resultWindow = new ResultWindow("Faux");
                    //resultWindow.ShowDialog();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez entrer des nombres.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Générer de nouvelles informations pour la forme sélectionnée
        private void GenererNouvelleInformation()
        {
            switch (formeSelectionnee)
            {
                case "Carre":
                    GenererNouveauCarre();
                    DessinerCarre();
                    break;
                case "Rectangle":
                    GenererNouveauRectangle();
                    DessinerRectangle();
                    break;
                case "Cercle":
                    GenererNouveauCercle();
                    DessinerCercle();
                    break;
                case "Ellipse":
                    GenererNouvelleEllipse();
                    DessinerEllipse();
                    break;
                case "Triangle":
                    GenererNouveauTriangle();
                    DessinerTriangle();
                    break;
            }
        }

        // Vider les TextBox
        private void ViderTextBox()
        {
            txtPerimetre.Text = "";
            txtSurface.Text = "";
            txtResultat.Text = "";
        }

        private void btnVoirReponse_Click(object sender, RoutedEventArgs e)
        {
            string messageReponse = $"La réponse correcte est :\n" +
                                    $"Périmètre : {perimetreAttendu}\n" +
                                    $"Surface : {surfaceAttendue}";

            MessageBox.Show(messageReponse, "Réponse Correcte", MessageBoxButton.OK, MessageBoxImage.Information);

            btnVoirReponse.Visibility = Visibility.Hidden;
            nombreErreurs = 0;
            btnValider.IsEnabled = true;
            GenererNouvelleInformation(); // Générer une nouvelle question après avoir affiché la réponse
            ViderTextBox();
        }

    }
}
