using System;

namespace Film_Default
{
    class Program
    {
        enum GenreFilms { Drama, Actie, Thriller, Horror, Komedie, Cartoon, Kinder, Onbekend};
        static void Main(string[] args)
        {
            Console.WriteLine("Film Default\n");

            //init vars
            string naamFilm = "Fighter";
            int duurFilm = 120;
            GenreFilms genreFilm = GenreFilms.Actie;

            //methode
            Console.WriteLine("\n3 param:");
            FilmRuntime(naamFilm, duurFilm, genreFilm);

            Console.WriteLine("\n2 param:");
            FilmRuntime(naamFilm, duurFilm);

            Console.WriteLine("\n1 param:");
            FilmRuntime(naamFilm);

            Console.WriteLine("\nnamed param:");
            FilmRuntime(naamFilm: "Kungfu Fighter", genreFilm: GenreFilms.Horror, duurFilm: 55);
        }

        private static void FilmRuntime(string naamFilm, int duurFilm = 90, GenreFilms genreFilm = GenreFilms.Onbekend)
        {
            Console.WriteLine($"{naamFilm} ({duurFilm} minuten, {genreFilm})");
        }
    }
}

//Maak een methode FilmRuntime() die 3 parameters accepteert:

//    Een string die de naam van de film bevat
//    Een integer die duur in minuten van de film bevat
//    Een enum-type die het genre van de film bevat (Drama, Actie, etc.)

//Indien de duur van de film niet wordt meegeven wordt een standaard lengte van 90 minuten ingesteld. Indien het genre niet wordt meegeven dan wordt deze default op Onbekend ingesteld.

//De methode geeft niets terug maar toont eenvoudigweg de film op het scherm, gevolgd door z’n duur en genre in volgende formaat.

//The Matrix (120minuten, Actie)

//Toon aan in je main dat de methode werkt met zowel 1, 2 als 3 parameters. Toon ook aan dat je met ‘named arguments’ de methode kan aanroepen.