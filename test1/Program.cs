using System.Diagnostics;

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
};
*/
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
     Créer un programme qui vérifie si une année est bissextile ou non.*/

/*Console.WriteLine("Donne-moi une année et je te dis si elle est bissextile");
int anneeBis = Convert.ToInt32(Console.ReadLine());

if (anneeBis % 4 == 0 )
{
    Console.WriteLine("");
}
*/

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
}*/

/*Exercice 15
    Écrire un programme qui vérifie si une chaîne de caractères contient la lettre 'a'.*/
