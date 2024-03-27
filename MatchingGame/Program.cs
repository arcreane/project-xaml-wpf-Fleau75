using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Espace de noms pour le projet de jeu de mémoire
namespace MatchingGame
{
    // Classe principale du programme
    static class Program
    {
        /// <summary>
        /// Le point d'entrée principal pour l'application.
        /// </summary>
        [STAThread] // Indique que le thread d'exécution utilise le modèle à thread unique STA
        static void Main()
        {
            Application.EnableVisualStyles(); // Active les styles visuels pour l'application pour suivre le thème de Windows
            Application.SetCompatibleTextRenderingDefault(false); // Paramètre par défaut pour le rendu du texte, false pour plus de performance
            Application.Run(new frmMain()); // Démarre l'application et ouvre le formulaire principal (frmMain)
        }
    }
}
