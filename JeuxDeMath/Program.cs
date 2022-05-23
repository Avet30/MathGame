
namespace JeuxDeMath
{
    class Program
    {
        enum e_Operateur
        {
            ADDITION = 1,
            MULTIPLICATEUR = 2,
            SOUSTRACTION = 3,
        }

        static bool PoserQuestion(int min, int max)
        {
            Random random = new Random();
            int reponseInt = 0;
            
            while (true)
            {
                int a = random.Next(min, max + 1);
                int b = random.Next(min, max + 1);
                e_Operateur o = (e_Operateur)random.Next(1, 4);
                int resultatAttendu;

                // if o == 1 -> addition
                // if o == 2 -> multiplication

                //VERSION SWITCH

                switch(o)
                {
                    case e_Operateur.ADDITION:
                        Console.WriteLine(a + " + " + b + " = ");
                        resultatAttendu = a + b;
                        break;
                    case e_Operateur.MULTIPLICATEUR:
                        Console.WriteLine(a + " x " + b + " = ");
                        resultatAttendu = a * b;
                        break;
                    case e_Operateur.SOUSTRACTION:
                        Console.WriteLine(a + " - " + b + " = ");
                        resultatAttendu = a - b;
                        break;
                    default:
                        Console.WriteLine("Erreur : Operateur inconnu!");
                        return false;
                }

                //VERSION IF/ELSE IF

                //if (o == e_Operateur.ADDITION)
                //{
                //    Console.WriteLine(a + " + " + b + " = ");
                //    resultatAttendu = a + b;
                //}
                //else if(o == e_Operateur.MULTIPLICATEUR)
                //{
                //    Console.WriteLine(a + " x " + b + " = ");
                //    resultatAttendu = a * b;
                //}
                //else if(o == e_Operateur.SOUSTRACTION)
                //{
                //    Console.WriteLine(a + " - " + b + " = ");
                //    resultatAttendu = a - b;
                //}
                //else
                //{
                //    Console.WriteLine("Erreur : Operateur inconnu!");
                //    return false;
                //}
               
                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    
                    if(reponseInt == resultatAttendu)
                    {
                        return true;
                    } 
                    return false;
                }
                catch
                {
                    Console.WriteLine("Erreur : Vous devez rentrer un nombre");
                }
            }

        }
        static void Main(string[] args)
        {
            const int NombreMin = 1;
            const int NombreMax = 10;
            const int NbQuestions = 4;
            int points = 0;
            

            for (int i = 0; i < NbQuestions; i++)
            {
                Console.WriteLine($"Question {i + 1} sur {NbQuestions}" );

                bool bonneReponse = PoserQuestion(NombreMin, NombreMax);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne reponse");
                    points++;
                }
                else
                {
                    Console.WriteLine("Mauvaise reponse");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Vous avez obtenu le score de {points}/{NbQuestions}!");

            float moyenne = NbQuestions / 2f;

            if(points == NbQuestions)
            {   Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Super, bien joue!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            else if(points == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tu es nul!");
                Console.ForegroundColor= ConsoleColor.White;
            }
            else if(points > moyenne)
            {
                Console.WriteLine("ca passe...");
            }
            else
            {
                Console.WriteLine("bof");
            }

        }
    }
}

