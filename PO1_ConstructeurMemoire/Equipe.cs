using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_ConstructeurMemoire
{
    public class Equipe //click droit puis action rapide et ... puis generer le constructeur
    {
        private string nom;
        private string ville;

        public Equipe(string nom, string ville)
        {
            Nom = nom;
            Ville = ville;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Ville { get => ville; set => ville = value; }

        public override string? ToString() // meme chose dans equipe puis generer les substitutions
        {
            return nom + " de " + ville;
        }
    }
}
