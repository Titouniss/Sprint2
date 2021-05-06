using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoupGarou
{
    public class Jeu
    {
        public Dictionary<int, Joueur> lesJoueurs = new Dictionary<int, Joueur>();
        public Dictionary<int, Joueur> lesJoueursEnBallotage = new Dictionary<int, Joueur>();
        public Dictionary<int, Joueur> lesJoueursActifs = new Dictionary<int, Joueur>();
        public Dictionary<int, Joueur> lesLoupsGarous = new Dictionary<int, Joueur>();
        public Dictionary<int, Joueur> lesVillageois = new Dictionary<int, Joueur>();
        public List<Role> lesRoles = new List<Role>();
        public List<Jour> lesJours = new List<Jour>();
        public string laNarration;
        public Jour leJourEnCour;
        public Joueur leMaire;
        public Jeu()
        {
            /*Déclaration de variable
            *
            * Début
            * Ajouter le role Villageois à lesRoles
            * Ajouter le role Loup à lesRoles
            * Ajouter le role Maire à lesRoles
            *
            * Fin
            */
            Role Villageois;
            Role Loup;
            Role Maire;
            lesRoles.Add(new Role("Villageois"));
            lesRoles.Add(new Role("Loup"));
            lesRoles.Add(new Role("Maire"));
        }
        public void init()
        {
            /* Déclaration de variable
            *
            * Début
            * POURCHAQUE element de lesJoueurs FAIRE
            * ajouter clé et valeur de element à lesJoueursActifs
            * FINPOURCHAQUE
            * Fin
            */

            foreach (KeyValuePair<int, Joueur> element in lesJoueurs)
            {

                lesJoueursActifs[element.Key] = element.Value;

            }
        }
        public void activerDesactiver(Dictionary<int, Joueur> laListe, bool etat)
        {
            /* Déclaration de variable
            *
            * Début
            * POURCHAQUE element de laListe
            * element.Value.estActif <- etat
            * FINPOURCHAQUE
            * Fin
            */
            foreach (KeyValuePair<int, Joueur> element in laListe)
            {
                etat = element.Value.estActif;
            }
        }
        public void attribuerDesRoles()
        {
            /*Déclaration de variable
            * temp:Dictionary<int, Joueur>
            * _Random:Random
            * _Aleatoire:integer
            * _nbreLoup:integer
            * _nbreVillageois:integer
            * n:integer*/
            Dictionary<int, Joueur> temp;
            Random _Random = new Random();
            int _Aleatoire;
            int _nbreLoup;
            int _nbreVillageois;
            int n;

            /*
            * Debut
            * temp <- new Dictionary<int, Joueur>()
            * POURCHAQUE element dans lesJoueur
            * ajouter element.Key et element.Value à temp
            * FINPOURCHAQUE
            * _nbreVillageois <- lesJoueurs.Count/2 +1
            * _nbreLoup <- lesJoueurs.Count - _nbreVillageois*/
            temp = new Dictionary<int, Joueur>();
            foreach (KeyValuePair<int, Joueur> element in lesJoueurs)
            {
                temp[element.Key] = element.Value;
            }
            _nbreVillageois = lesJoueurs.Count / 2 + 1;
            _nbreLoup = lesJoueurs.Count - _nbreVillageois;


            /* n <- _nbreVillageois-1
            * POUR i allant de 0 à _nbreVillageois FAIRE
            * _Aleatoire <- _Random.Next(0, n)
            * lesJoueurs[temp.ElementAt(_Aleatoire).Key].leRole <- lesRoles[0]
            * Supprimer l'objet avec la clé temp.ElementAt(_Aleatoire).Key de temp
            * n <- n-1
            * FINPOUR*/
            n = _nbreVillageois - 1;
            for (int i = 0; i < _nbreVillageois; i++)
            {
                _Aleatoire = _Random.Next(0, n);
                lesJoueurs[temp.ElementAt(_Aleatoire).Key].leRole = lesRoles[0];
                temp.Remove(temp.ElementAt(_Aleatoire).Key);
                n = n - 1;
            }

            /* n <- _nbreLoup-1
            * POUR i allant de 0 à _nbreLoup FAIRE
            * __Aleatoire <- _Random.Next(0, n)
            * lesJoueurs[temp.ElementAt(_Aleatoire).Key].leRole <- lesRoles[0]
            * Supprimer l'objet avec la clé temp.ElementAt(_Aleatoire).Key de temp
            * n <- n-1
            * FINPOUR
            * Fin
            */
            n = _nbreLoup - 1;
            for (int i = 0; i < _nbreLoup; i++)
            {
                _Aleatoire = _Random.Next(0, n);
                lesJoueurs[temp.ElementAt(_Aleatoire).Key].leRole = lesRoles[0];
                temp.Remove(temp.ElementAt(_Aleatoire).Key);
                n = n - 1;
            }
        }
        public void setlaNarration(int option)
        {
            /*Déclaration de variable
            * leTexte : String*/
            string leTexte;

            /* Début
            * Selon option FAIRE
            * cas 0
            * laNarration <- "Texte d'introduction du jeu"
            * sortir
            * cas 1
            * laNarration <- "Texte d'introduction du jour"
            * sortir
            * cas 2
            * laNarration <- "Texte d'introduction la nuit"
            * sortir
            * cas 3
            * laNarration <- "Texte d'introduction la levée du jour"
            * sortir *
            * cas 4
            * laNarration <- "Texte pour voter"
            * sortir
            * cas 5
            * laNarration <- "Texte pour annoncer le résultat du vote général"
            * sortir
            * cas 6
            * laNarration <- "Texte pour annoncer le ou les morts"
            * sortir
            * cas 7
            * laNarration <- "Texte pour annoncer le vote du maire"
            * sortir
            * cas 8
            * laNarration <- "Texte de fin de jeu"
            * sortir
            * etc...
            * FINSELON
            * Fin
            */
            switch (option)
            {
                case 0:
                    laNarration = "texte d'introduction du jeu";
                    break;
                case 1:
                    laNarration = "texte d'introduction du jour";
                    break;
                case 2:
                    laNarration = "texte d'introduction du nuit";
                    break;
                case 3:
                    laNarration = "texte d'introduction de la lavée du jour";
                    break;
                case 4:
                    laNarration = "texte pour voter";
                    break;
                case 5:
                    laNarration = "texte pour annoncer le resultat du vote general";
                    break;
                case 6:
                    laNarration = "texte pour annoncer le ou les morts";
                    break;
                case 7:
                    laNarration = "texte d'introduction du jeu";
                    break;
                case 8:
                    laNarration = "texte pour annoncer le vote du maire";
                    break;
                case 9:
                    laNarration = "texte d'introduction de fin du jeu";
                    break;


            }
        }
        public void voter(int choix)
        {
            /* Déclaration de variable
            *
            * Début
            * SI lesJoueursEnBallotage contiennent la clé choix FAIRE
            * lesJoueursEnBallotage[choix].leNbrVote <- lesJoueursEnBallotage[choix].leNbrVote+1
            * SINON
            * Ajouter l'élément de clé choix et de valeur lesJoueursActifs[choix] à la collection lesJoueursEnBallotage
            * lesJoueursEnBallotage[choix].leNbrVote <- lesJoueursEnBallotage[choix].leNbrVote+1
            * FINSI
            * Fin
            */
            if (lesJoueursEnBallotage.ContainsKey(choix))
            {
                lesJoueursEnBallotage[choix].leNbreVote = lesJoueursEnBallotage[choix].leNbreVote + 1;
            }
            else
            {
                lesJoueursEnBallotage.Add(choix, lesJoueursActifs[choix]);
                lesJoueursEnBallotage[choix].leNbreVote = lesJoueursEnBallotage[choix].leNbreVote + 1;
            }
        }

        public bool verifierVote(int choix)
        {
            /*
            * Déclaration de variable
            * result:booléen
            *
            * Début
            * result <- false
            * SI validationVote() != 0 FAIRE
            * result <- true
            * FINSI
            * Retourner result
            * Fin
            */
            bool result;
            result = false;
            if (validationVote() != 0)
            {
                result = true;
            }
            return result;
        }
        public int validationVote()
        {
            /*
            * Déclaration de variable
            * result : integer
            *
            * Début
            * result <- 0
            * POUR i allant de 0 à lesJoueursEnBallotage.Count par pas de 1 FAIRE
            * SI result < lesJoueursEnBallotage.ElementAt(i).Value.leNbreVote FAIRE
            * result <- lesJoueursEnBallotage.ElementAt(i).Value.leNbreVote
            * 
            * SI i>0 FAIRE
            * Effacer lesJoueursEnBallotage.ElementAt(i-1).Key de la collection lesJoueursEnBallotage
            * FINSI
            * 
            * SINON SI result > lesJoueursEnBallotage.ElementAt(i).Value.leNbreVote FAIRE
            * Effacer lesJoueursEnBallotage.ElementAt(i).Key de la collection lesJoueursEnBallotage
            * FINSI
            * FINPOUR
            *
            * SI lesJoueursEnBallotage.Count est égale à 1 FAIRE
            * result <- lesJouersEnBallotage.ElementAt(0).Key
            * SINON
            * * result <- 0
            * FINSI
            *
            * retourner result
            *
            * Fin
            */
            int result;
            result = 0;
            for (int i = 0; i < lesJoueursEnBallotage.Count; i++)
            {
                if (result < lesJoueursEnBallotage.ElementAt(i).Value.leNbreVote)
                {
                    result = lesJoueursEnBallotage.ElementAt(i).Value.leNbreVote;
                }
                if (i > 0)
                {
                    lesJoueursEnBallotage.Remove(lesJoueursEnBallotage.ElementAt(i - 1).Key);
                }
                else if (result > lesJoueursEnBallotage.ElementAt(i).Value.leNbreVote)
                {
                    lesJoueursEnBallotage.Remove(lesJoueursEnBallotage.ElementAt(i).Key);
                }
            }

            if (lesJoueursEnBallotage.Count == 1)
            {
                result = lesJoueursEnBallotage.ElementAt(0).Key;
            }
            else
            {
                result = 0;
            }
            return result;
        }
        public bool verifierGagnant()
        {
            /*
            * Déclaration de variable
            * result:booléen
            *
            * Début
            * result <- false
            *
            * SI lesLoupsGarous.Count est égale 0 ou lesVillageois.Count est égale 0 FAIRE
            * result <- true
            * FINSI
            *
            * Retourner result
            * Fin
            */
            bool result;
            result = false;
            if (lesLoupsGarous.Count == 0 || lesVillageois.Count == 0)
            {
                result = true;
            }
            return result;
        }
        public void MAJlesJoueurs()
        {
            /*
            * Déclaration de variable
            *
            * Début
            * vider lesLoupsGarous
            * vider lesVillageois
            *
            * POURCHAQUE element dans lesJoueursActifs
            * SI element.Value.leRole est égale à lesRoles[0] ou element.Value.leRole est égale à lesRoles[2] FAIRE
            * Ajouter element.Key, element.Value à lesVillageois
            * SINON
            * Ajouter element.Key, element.Value à lesLoupsGarous
            * FINSI
            * FINPOURCHAQUE
            * Fin
            */
            lesLoupsGarous.Clear();
            lesVillageois.Clear();

            foreach (KeyValuePair<int, Joueur> element in lesJoueursActifs)
            {
                if (element.Value.leRole == lesRoles[0] || element.Value.leRole == lesRoles[2])
                {
                    lesVillageois.Add(element.Key, element.Value);
                }
                else
                {
                    lesLoupsGarous.Add(element.Key, element.Value);
                }
            }
        }
        public void initVote()
        {
            /*Déclaration de variable
            *
            * Début
            * SI validationVote() est différent de 0 ALORS
            * lesJoueurs[validationVote()].estActif <- false
            * lesJoueurs[validationVote()].estMort <- true
            * Supprimer l'objet à la clé validationVote() de la collection lesJoueursActifs
            * MAJLesjoueurs()
            * FINSI
            * 
            *
            * Vider lesJoueursEnBallotage
            *
            * POUR i allant de 0 à lesJoueursActifs.Count FAIRE
            * lesJoueursActifs.ElementAt(i).Value.leNbrVote <- 0
            * FINPOUR
            * Fin
            */
            if (validationVote() != 0)
            {
                lesJoueurs[validationVote()].estActif = false;
                lesJoueurs[validationVote()].estMort = true;
                lesJoueursActifs.Remove(lesJoueurs.ElementAt(validationVote()).Key);
                MAJlesJoueurs();
            }

            lesJoueursEnBallotage.Clear();

            for (int i = 0; i < lesJoueursActifs.Count(); i++)
            {
                lesJoueursActifs.ElementAt(i).Value.leNbreVote = 0;
            }
        }
    }
}