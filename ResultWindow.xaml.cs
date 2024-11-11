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
using System.Windows.Shapes;

namespace Geometrie
{
    /// <summary>
    /// Logique d'interaction pour ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        // Constructeur qui accepte un message
        public ResultWindow(string message)
        {
            InitializeComponent();
            // On affiche le message passé en paramètre ("Vrai" ou "Faux")
            txtResultatFenetre.Text = message;
        }

        // Gestion de la fermeture de la fenêtre
        private void btnFermer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();  // Fermer la fenêtre quand on clique sur "Fermer"
        }
    }
}
