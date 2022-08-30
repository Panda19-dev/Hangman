// See https://aka.ms/new-console-template for more information

static void Start() {
    System.Console.WriteLine("\n\n\n\n\n\n\n\n  \t\t\t\t\t\t  Välkommen till Hangman!");
    System.Console.WriteLine("\n\n\n \t\t\t\t\t Regler: Tryck 1 \t Starta Spel: Tryck 2");
    System.Console.ReadKey();
    ConsoleKey key = Console.ReadKey(true).Key;
    switch(key) {

        case ConsoleKey.D1:
            Turtorial();
            break;

        case ConsoleKey.D2:
            Play();
            break;

        case default:
            System.Console.WriteLine("Var snäll följ instruktionerna!");
            System.Console.WriteLine("\n Tryck enter för att fortsätta");
            System.Console.ReadLine();
            Start();
            break;
    }
}

static void Turtorial() {
    System.Console.WriteLine("Hangman is a simple word guessing game. Players try to figure out an unknown word by guessing letters. If too many letters which do not appear in the word are guessed, the player is hanged (and loses).");
    System.Console.WriteLine("\nOm det behövs på svenska så får du drömma vidare");
    System.Console.WriteLine("\n\nTryck Enter för att gå tillbaka");
    Console.ReadLine();
    Start();
}

static void Play() {

}


Start();