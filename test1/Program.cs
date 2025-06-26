using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

//Exercice brief 

//Exercice 5


/*int note;


for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Merci de saisir la note" + i + "(sur /20) : ");

}*/



/*//Exercice 6
// initialisation des chiffres aléatoires et d'une variable
Random aleatoire = new Random();
int nbMystere = aleatoire.Next(1, 51);
Console.WriteLine(nbMystere);

Console.WriteLine(" --- Trouver le nombre mystère --- ");
//Initialisation des variables 
int nombreDeFois = 0;
int saissieUtilisateur = 0;
// initialisation d'une boucle (saissieUtilisateur n'est pas égal à nbMystere)
while (saissieUtilisateur != nbMystere)
{
    Console.Write("Veuillez saisir un nombre : ");
    saissieUtilisateur = Convert.ToInt32(Console.ReadLine());

    // si saissieUtilisateur est supérieur à nbMystere
    if (saissieUtilisateur > nbMystere)
    {
        // ajoute de couleurs du fonds et des lignes
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Le nombre mystère est plus petit");
        Console.ResetColor();
    } // si saissieUtilisateur est inférieur à nbMystere
    else if (saissieUtilisateur < nbMystere)
    {// ajoute de couleurs du fonds et des lignes
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Le nombre mystère est plus grand");
        Console.ResetColor();
    }
    else // Si l'utilisateur trouve le nombre
    {// ajoute de couleurs du fonds et des lignes
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Bravo !!!! Vous avez trouvé le bon nombre mystère !");
        Console.ResetColor();
    }
    // incrémentation des coups
    nombreDeFois++;
    


};
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Vous avez trouvé en " + nombreDeFois++ + " coups"); // nombre de coups
Console.ResetColor();*/

















/*1. Condition simples*/


/*Exercice 1 
    Écrire un programme qui vérifie si un nombre donné est supérieur à 10. */

/*int nombreSuperieur = 10;

if (nombreSuperieur > 10)
{
    Console.WriteLine("Le nombre est supérier ");
}
else
{
    Console.WriteLine("Le nombre est inférieur à 10");
};
*/

/*Exercice 2 
    Vérifier si un nombre donné est positif, négatif ou nul. */

/*int nombrePositifNegatif = 11;*/

/*if (nombrePositifNegatif < 0)
{
    Console.WriteLine("Négatif");
}
else if (nombrePositifNegatif > 0)
{
    Console.WriteLine("Positif");
}
else
{
    Console.WriteLine("Nul");
};*/


/*Exercice 3
    Créer un programme qui affiche "Vous êtes mineur" si l’âge est inférieur à 18.*/

/*int mineurMajeur = 28;

if (mineurMajeur > 18)
{
    Console.WriteLine("Vous êtes majeur");
}
else
{
    Console.WriteLine("Vous êtes mineur");
};*/


/*Exercice 4
    Écrire un programme qui vérifie si une chaîne de caractères est vide ou non.*/

/*string checkChaineCaract = "oui";

if (checkChaineCaract == "")
{
    Console.WriteLine("La chaîne de caractères est vide !");
}
else
{
    Console.WriteLine("La chaîne de caractères n'est pas vide !");
};*/


/*Exercice 5
    Vérifier si un nombre est pair ou impair.*/
/*
int nombrePairImpair = 564513555;

if (nombrePairImpair % 2 != 0)
{
    Console.WriteLine("Ton nombre est impair !");
}
else
{
    Console.WriteLine("Ton nombre est pair !");
};*/


/*Exercice 6
     Écrire un programme qui compare deux nombres et affiche le plus grand.*/
/*
int nombre1 = 5;
int nombre2 = 6;

if (nombre1 > nombre2)
{
    Console.WriteLine("Ma variable nombre1 est la plus grande : " + nombre1);
}
else
{
    Console.WriteLine("Ma variable nombre2 est la plus grande : " + nombre2);
};*/


/*Exercice 7
    Vérifier si un nombre est divisible par 3 ou par 5*/

/*int nombreDivisible = 18;

if (nombreDivisible % 3 == 0)
{
    Console.WriteLine(nombreDivisible + " est divisible par 3");
}
else if (nombreDivisible % 5 == 0)
{
    Console.WriteLine(nombreDivisible + " est divisible par 5");
}
else
{
    Console.WriteLine(nombreDivisible + "n'est pas divisble par 3 ou 5");
};*/


/*Exercice 8
    Demander à l'utilisateur un mot de passe et vérifier s'il correspond à "admin".*/

/*string motDePasse = "admin";

Console.Write("Entrée votre mot de passe : ");
string saissieUtilisateur =  Console.ReadLine();

if (motDePasse == saissieUtilisateur)
{
    Console.WriteLine("Congratulations !");
}
else
{
    Console.WriteLine("Le mot de passe n'est pas correct ");
};


*/



//Exercice 9
//Créer un programme qui vérifie si une lettre est une voyelle ou une consonne.

/*Console.WriteLine("entre une lettre : ");
string ConsonneOuVoyelle = Console.ReadLine();

if (ConsonneOuVoyelle == "a" || ConsonneOuVoyelle == "e" || ConsonneOuVoyelle == "i" || ConsonneOuVoyelle == "o" || ConsonneOuVoyelle == "u" || ConsonneOuVoyelle == "y" )
{
    Console.WriteLine($"{ConsonneOuVoyelle} est une voyelle");
}
else
{
    Console.WriteLine($"{ConsonneOuVoyelle} est une consonne");
}
*/


/*Exercice 10
    Calculer le nombre de caractères dans une chaîne de caractères, si le nombre de caractères est supérieur à 5, ne garder que les 5 premiers caractères.*/





/*2. Condition imbriquées*/

/*Exercice 11
    Écrire un programme qui vérifie si un nombre est compris entre 10 et 20.*/

/*Console.WriteLine("Entre un nombre et vérifions s'il se trouve entre 10 et 20 : ");
int nombreCompris = Convert.ToInt32(Console.ReadLine());

if (nombreCompris >= 10 && nombreCompris <= 20)
{
    Console.WriteLine(nombreCompris + " se trouve bien entre 10 et 20");
}
else
{
    Console.WriteLine(nombreCompris + " ne se trouve pas entre 10 et 20");
};*/


/*Exercice 12
    Demander à l'utilisateur un âge et afficher s'il est un enfant (moins de 12 ans), 
    un adolescent (entre 12 et 18 ans) ou un adulte (plus de 18 ans).*/

/*Console.WriteLine("Quel âge avez vous ?");
int age = Convert.ToInt32(Console.ReadLine());

if (age > 18)
{
    Console.WriteLine("Vous êtes un adulte");
}
else if (age < 12)
{
    Console.WriteLine("Vous êtes un enfant");
}
else
{
    Console.WriteLine("Vous êtes un adolescent");
};
*/


/*Exercice 13
     Créer un programme qui vérifie si une année est bissextile ou non.*//*

Console.WriteLine("Donne-moi une année et je te dis si elle est bissextile");
int anneeBis = Convert.ToInt32(Console.ReadLine());

if ((anneeBis % 4 == 0 && anneeBis % 100 != 0) || (anneeBis % 400 == 0))
{
    Console.WriteLine(anneeBis + " est une année bissextile");
}
else
{
    Console.WriteLine(anneeBis + " n'est pas une année bissestile");
};*/


/*Exercice 14
    Vérifier si un nombre est positif et multiple de 5.*/

/*Console.WriteLine("Donne moi un nombre, je te dirais si il est positif et multiple de 5");
int positifMultiple = Convert.ToInt32(Console.ReadLine());

if (positifMultiple % 5 == 0 && positifMultiple > 0)
{
    Console.WriteLine(positifMultiple + " est bien un nombre positif et un multiple de 5");
}
else if (positifMultiple < 0)
{
    Console.WriteLine(positifMultiple + " n'est pas un nombre positif");
}
else
{
    Console.WriteLine(positifMultiple + " n'est pas un multiple de 5");
};*/


/*Exercice 15
    Écrire un programme qui vérifie si une chaîne de caractères contient la lettre 'a'.*//*

string chaineCaract = "J'aime la saucisse";
string LettreA = "a";

if (chaineCaract.Contains('a'))
{
    Console.WriteLine("La chaîne de caractères contient bien la lettre : " + LettreA);
}
else
{
    Console.WriteLine("La chaîne de caratères ne contient pas la lettre : " + LettreA);
};
*/


/*Exercice 16
    Vérifier si un nombre est divisible à la fois par 2 et par 3, mais pas par 9.*//*

Console.WriteLine("Donner moi un nombre pour vérifier si il est divisible à la fois par 2 et 3 , mais pas par 9");
int divisibleDeuxouTrois = Convert.ToInt32(Console.ReadLine());

if (divisibleDeuxouTrois % 2 == 0 && divisibleDeuxouTrois % 3 == 0 && divisibleDeuxouTrois % 9 != 0)
{
    Console.WriteLine(divisibleDeuxouTrois + " est bien divisible à la fois par 2 et 3 , mais pas par 9");
}
else
{
    Console.WriteLine(divisibleDeuxouTrois + " ne respecte pas les conditions");
};*/


/*Exercide 17 
    Demander à l'utilisateur un nom d'utilisateur et un mot de passe, et vérifier si les deux sont corrects.*/

/*string utilisateur = "Admin";
string motDePasse = "Password";

Console.WriteLine("Nom utilisateur : ");
string saissieNomUtilisateur = Console.ReadLine();

Console.WriteLine("Mot de passe utilisateur : ");
string saissieMdpUtilisateur = Console.ReadLine();

if (utilisateur == saissieNomUtilisateur && motDePasse == saissieMdpUtilisateur)
{
    Console.WriteLine("Bienvenue " + utilisateur);
}
else
{
    Console.WriteLine("Nom d'utilisateur ou le mot de passe est arroné");
}
;
*/

/*Exercice 18 
    Écrire un programme qui affiche "Excellent" si la note est supérieure à 85, "Bien" si elle est entre 70 et 85, sinon afficher "Peut mieux faire".*//*

int noteExamen = 96;

if (noteExamen < 70)
{
    Console.WriteLine("Peut mieux faire.");
}
else if (noteExamen > 85)
{
    Console.WriteLine("Excellent.");
}
else
{
    Console.WriteLine("Bien.");
};*/


/*Exercice 19
    Créer un programme qui vérifie si une chaîne de caractères est un palindrome.*/

Console.WriteLine("Entre un mot et voyons si c'est un palindrome :");
string entrerUtilisateur = Console.ReadLine();
string palindrome = new string(entrerUtilisateur.Reverse().ToArray());

if (entrerUtilisateur == palindrome)
{
    Console.WriteLine($"{entrerUtilisateur} est une palindrome");
}
else
{
    Console.WriteLine($"{entrerUtilisateur} n'est pas un palindrome");
}

    

/*Exercice 20
    Écrire un programme qui vérifie si un nombre est à la fois positif, pair et supérieur à 100.*/

/*Console.WriteLine("Donne moi un nombre ?");
int nombrePositifPairSuperieur = Convert.ToInt32(Console.ReadLine());

if (nombrePositifPairSuperieur > 0 && nombrePositifPairSuperieur % 2 == 0 && nombrePositifPairSuperieur > 100)
{
    Console.WriteLine(nombrePositifPairSuperieur + " est positif, pair et supérieur à 100.");
}
else
{
    Console.WriteLine(nombrePositifPairSuperieur + " ne respecte pas l'une de ses conditions : positif, pair ou supérieur à 100");
};
*/


//3.Boucles simples


/*Exercice 21
    Afficher les nombres de 1 à 10 avec une boucle `for`.*/


/*for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
};*/


/*Exercice 22
    Afficher les nombres pairs entre 1 et 20.*/


/*for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
};*/


/*Exercice 23
    Utiliser une boucle pour afficher chaque élément d'un tableau.*/


/*string[] tableau = ["Loïc", "Hazel", "Emerick"];

for (int i = 0; i < tableau.Length; i++)
{
    Console.WriteLine(tableau[i]);
};
*/


/*Exercice 24
    Demander à l'utilisateur un nombre de 1 à 10 et afficher la table de multiplication.*/


/*Console.WriteLine("Donne-moi un nombre entre 1 et 10 et j'afficherai la table de multiplication de ce nombre : ");
int tableMultiplication = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i * tableMultiplication);
}
;*/


/*Exercice 25
    Afficher les éléments d'une chaîne de caractères un par un.*/


/*Console.WriteLine(" donner moi une chaîne de caractères");
string chaineCaractere = Console.ReadLine();
string[] separationCaractere = chaineCaractere.Split(' ');

for (int i = 0; i < separationCaractere.Length; i++)
{
    Console.WriteLine(separationCaractere[i]);
};*/



//4. Boucles `while`


/*Exercice 31
     Utiliser une boucle `while` pour afficher les nombres de 1 à 10.*/


/*int nombreUnDix = 0;

while(nombreUnDix < 10)
{
    nombreUnDix++;
    Console.WriteLine(nombreUnDix);
};

*/


/*Exercice 32
    Utiliser une boucle `while` pour calculer la somme des nombres de 1 à 100.*/


//5.Utilisation des boucles avec `break` et `continue`


/*Exercice 41
    Utiliser une boucle pour afficher les nombres de 1 à 20, mais arrêter dès que vous atteignez 10.*/


