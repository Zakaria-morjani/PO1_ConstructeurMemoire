using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_ConstructeurMemoire
{
    public class Joueur
    {
        private string nom;
        private Equipe equipe;

        public Joueur(string nom, Equipe equipe)
        {
            Nom = nom;
            Equipe = equipe;
        }

        public string Nom { get => nom; set => nom = value; }
        public Equipe Equipe { get => equipe; set => equipe = value; }

        public override string? ToString()
        {
            return nom + " Des " + equipe.Nom ;
        }
    }
}
