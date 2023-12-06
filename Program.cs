/*using System;
namespace MyfirstGame;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Word Guessing Game!");

        int totalLives = 3;
        int totalGames = 5;

        for (int game = 1; game <= totalGames; game++)
        {
            Console.WriteLine($"\n----- Game {game} -----");

            // Player 1 and Player 2 take turns
            for (int player = 1; player <= 2; player++)
            {
                int totalAttempts = 0;
                int totalCorrectGuesses = 0;

                Console.WriteLine($"\n----- Player {player} -----");

                Console.Write($"Player {player}, enter the number of words for this level: ");
                int numberOfWords = int.Parse(Console.ReadLine());

                for (int level = 0; level < numberOfWords; level++)
                {
                    Console.WriteLine($"\n----- Word {level + 1} -----");

                    // Player 1 enters a word
                    string secretWord = "";
                    if (player == 1)
                    {
                        Console.Write("Enter a word: ");
                        secretWord = Console.ReadLine().ToLower();
                    }

                    // Clear the console to hide the entered word
                    Console.Clear();

                    // Player 2 guesses the word
                    int attempts = 0;
                    int lives = totalLives;
                    bool wordGuessed = false;

                    Console.WriteLine($"Welcome Player {player}! Try to guess the word.");

                    while (!wordGuessed && lives > 0)
                    {
                        Console.WriteLine($"Lives: {lives}");

                        Console.Write("Enter your guess: ");
                        string guess = Console.ReadLine().ToLower(); // Convert the guess to lowercase for case-insensitivity

                        attempts++;

                        if (guess == secretWord)
                        {
                            Console.WriteLine($"Congratulations! You guessed the word '{secretWord}' in {attempts} attempts.");
                            wordGuessed = true;
                            totalCorrectGuesses++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect guess. Try again.");
                            lives--;
                        }
                    }

                    if (!wordGuessed && player == 2)
                    {
                        Console.WriteLine($"Sorry, you ran out of lives. The correct word was '{secretWord}'.");
                    }

                    totalAttempts += attempts;
                }

                double score = (double)totalCorrectGuesses / totalAttempts * 100;
                Console.WriteLine($"\nPlayer {player} Score: {score:F2}%");
            }
        }

        Console.WriteLine("\nGame Over!");
        Console.ReadLine(); // Wait for user input before closing the console
    }
}
/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Word Guessing Game!");

        int totalLives = 3;
        int totalGames = 5;

        for (int game = 1; game <= totalGames; game++)
        {
            Console.WriteLine($"\n----- Game {game} -----");

            // Player 1 and Player 2 take turns
            for (int player = 1; player <= 2; player++)
            {
                int totalAttempts = 0;
                int totalCorrectGuesses = 0;

                Console.WriteLine($"\n----- Player {player} -----");

                for (int level = 0; level < game; level++) // Adjusted the levels based on the game number
                {
                    Console.WriteLine($"\n----- Level {level + 1} -----");

                    // Get words for the level
                    string[] words = GetWordsForLevel(level + 3); // Adjusted to start with 3 words and increase by 1 for each level

                    foreach (string secretWord in words)
                    {
                        Console.Write($"Player {player}, enter a word: ");
                        Console.ReadLine(); // Player enters the word without revealing it

                        Console.Clear(); // Clear the console to hide the entered word

                        int attempts = 0;
                        int lives = totalLives;
                        bool wordGuessed = false;

                        Console.WriteLine($"Welcome Player {player}! Try to guess the word.");

                        while (!wordGuessed && lives > 0)
                        {
                            Console.WriteLine($"Lives: {lives}");

                            Console.Write("Enter your guess: ");
                            string guess = Console.ReadLine().ToLower();

                            attempts++;

                            if (guess == secretWord)
                            {
                                Console.WriteLine($"Congratulations! You guessed the word '{secretWord}' in {attempts} attempts.");
                                wordGuessed = true;
                                totalCorrectGuesses++;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect guess. Try again.");
                                lives--;
                            }
                        }

                        if (!wordGuessed)
                        {
                            Console.WriteLine($"Sorry, you ran out of lives. The correct word was '{secretWord}'.");
                        }

                        totalAttempts += attempts;
                    }
                }

                double score = (double)totalCorrectGuesses / totalAttempts * 100;
                Console.WriteLine($"\nPlayer {player} Score: {score:F2}%");
            }
        }

        Console.WriteLine("\nGame Over!");
        Console.ReadLine(); // Wait for user input before closing the console
    }

    static string[] GetWordsForLevel(int numberOfWords)
    {
        string[] words = new string[numberOfWords];

        for (int i = 0; i < numberOfWords; i++)
        {
            Console.Write($"Enter word {i + 1}: ");
            words[i] = Console.ReadLine().ToLower();
        }

        return words;
    }
}
*/
using System;
namespace MyfirstGame{
    public class Swwap{
        public static void Main(string[] args)
        {
            int x=30;
            int y=20;

            x=x+y;
            y=x-y;
            x=x-y;
            Console.WriteLine("X="+x);
            Console.WriteLine("Y="+y);
            Console.ReadKey();
            
                   }
    }
}