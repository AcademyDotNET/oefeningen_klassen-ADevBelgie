using System;

namespace Caesar_encryptie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caesar-encryptie\n ");

            //init vars
            int encriptionKey = GetUserKey();
            char[] userChars = GetCharArray();

            //print & crypt
            Console.WriteLine("user array: ");
            printArray(arrayChar: userChars);

            Console.WriteLine("\nuser array encrypted: ");
            Encrypt(userChars, encriptionKey);
            printArray(arrayChar: userChars);

            Console.WriteLine("\nuser array decrypted: ");
            Decrypt(userChars, encriptionKey);
            printArray(arrayChar: userChars);
        }

        private static int GetUserKey()
        {
            int encriptionKey;
            Console.WriteLine("Geef de Key: ");
            while (!Int32.TryParse(Console.ReadLine(), out encriptionKey))
            {
                Console.WriteLine("Geef een valide Key: ");
            }

            return encriptionKey;
        }

        private static char[] GetCharArray()
        {
            //init vars
            bool charArrayValid = false;
            Console.WriteLine("Geef de string: ");
            string tempString = Console.ReadLine();

            //check if valid
            charArrayValid = CheckIfCharArrayvalid(tempString);
            while (!charArrayValid)
            {
                Console.WriteLine("Geef een valide string: ");
                tempString = Console.ReadLine();
                charArrayValid = CheckIfCharArrayvalid(tempString);
            }

            char[] userChars = tempString.ToCharArray();

            return userChars;
        }

        private static bool CheckIfCharArrayvalid(string tempString)
        {
            for (int i = 0; i < tempString.Length; i++)
            {
                if (tempString[i] > 90 || tempString[i] < 65)
                {
                    return false;
                }
            }
            return true;
        }

        private static void Decrypt(char[] userChars, int encriptionKey)
        {
            encriptionKey = encriptionKey % 25;
            for (int i = 0; i < userChars.Length; i++)
            {
                userChars[i] -= (char)encriptionKey;
                if (userChars[i] < 65)
                {
                    userChars[i] += (char)26;
                }
            }
        }

        private static void Encrypt(char[] userChars, int encriptionKey)
        {
            encriptionKey = encriptionKey % 25;
            for (int i = 0; i < userChars.Length; i++)
            {
                userChars[i] += (char)encriptionKey;
                if (userChars[i] > 90)
                {
                    userChars[i] -= (char)26;
                }
            }
        }

        private static void printArray(bool[] arrayBool = null, int[] arrayInt = null, char[] arrayChar = null)
        {
            if (arrayBool != null)
            {
                var array = arrayBool;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.WriteLine($"{array[array.Length - 1]}");
            }
            else if (arrayInt != null)
            {
                var array = arrayInt;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.WriteLine($"{array[array.Length - 1]}");
            }
            else if (arrayChar != null)
            {
                var array = arrayChar;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.WriteLine($"{array[array.Length - 1]}");
            }
        }
    }
}

//Maak 2 methoden Encrypt en Decrypt die als parameters telkens een chararray krijgen en een integer. Bedoeling is dat de Encrypt-methode de array van het type string versleuteld gegeven de sleutel x volgens het Caesar cipher (zie hieronder). Als resultaat komt er uit de methode de geëncrypteerde array.

//De decrypt-methode doet hetzelfde maar omgekeerd: je kan er een versleutelde tekst insteken en de sleutel en de ontcijferde tekst komt terug (merk op dat je decrypt-methode gebruik kan maken van de encrypt-methode!).

//Toon in je main aan dat je methoden werken (door bijvoorbeeld aan de gebruiker een stuk tekst als string te vragen en een sleutel en deze dan te encrypteren/de-crypteren).

//    Encryptie is de kunst van het vercijferen van data. Hierbij gaat men een gewone tekst zodanig omvormen (versleutelen) zodat deze onleesbaar is en enkel kan ontcijferd worden door de ontvanger die weet hoe de tekst terug kan verkregen worden en enkel indien deze ook de ‘private’ sleutel heeft.

//    Een klassiek encryptie-algoritme uit de oudheid is de Caesar substitutie.Hierbij gaan we het alfabet met x plaatsen opschuiven en vervolgens de te vercijferen tekst letter per letter vervangen met z’n respectievelijke opgeschoven versie. Hierbij is x dus de geheime sleutel die zender en ontvanger moeten afspreken.

//Stel bijvoorbeeld dat x = 3 dan krijgen we volgende nieuwe alfabet:

//DEFGHIJKLMNOPQRSTUVWXYZABC

//Waarbij dus de A zal vervangen worden door een D, de Z door een C, etc.

//Willen we deze tekst dus encrypteren:

//the quick brown fox jumps over the lazy dog

//dan krijgen we:

//WKH TXLFN EURZQ IRA MXPSV RYHU WKH ODCB GRJ

