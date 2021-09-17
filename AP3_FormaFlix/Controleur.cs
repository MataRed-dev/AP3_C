using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_FormaFlix
{
    /// <summary>
    /// Classe Controleur : AP3 FORMA'FLIX
    /// Auteur : C.AUTRET
    /// date : Septembre 2021
    /// </summary>
    public static class Controleur
    {
        private static ModeleConnexion vmodeleC;
        private static ModeleFormation vmodeleF;

        public static ModeleFormation VmodeleF { get => vmodeleF; set => vmodeleF = value; }
        public static ModeleConnexion VmodeleC { get => vmodeleC; set => vmodeleC = value; }

        public static void initConnexion()
        {
            VmodeleC = new ModeleConnexion();
        }
        public static void initFormation()
        {
            VmodeleF = new ModeleFormation();
        }

    }
}
