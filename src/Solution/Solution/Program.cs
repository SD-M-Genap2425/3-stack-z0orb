using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        var browserHistory = new HistoryManager();
        browserHistory.KunjungiHalaman("google.com");
        browserHistory.KunjungiHalaman("example.com");
        browserHistory.KunjungiHalaman("stackoverflow.com");

        Console.WriteLine($"Halaman saat ini: {browserHistory.LihatHalamanSaatIni()}");
        
        browserHistory.Kembali();
        Console.WriteLine($"Halaman saat ini: {browserHistory.LihatHalamanSaatIni()}");

        browserHistory.TampilkanHistory();
        // Bracket validator

        var validator = new BracketValidator();

            
            string[] testExpressions = {
                "[{}](){}",       
                "(]",             
                "([]{[]})[]{{}()}", 
                "{[(])}",         
                "",               
                "(((",            
                ")))"             
            };

            foreach (var expression in testExpressions)
            {
                bool isValid = validator.ValidasiEkspresi(expression);
                Console.WriteLine($"Ekspresi '{expression}' valid? {isValid}");
            }

        

        //Palindrome Checker
        // Test cases for palindrome checking
        string[] testInputs = {
            "Kasur ini rusak",              // Valid palindrome
            "Hello World",                  // Not a palindrome
            "A man, a plan, a canal: Panama", // Valid palindrome with mixed case and punctuation
            "",                             // Empty string (valid palindrome)
            "12321",                        // Numeric palindrome
            "12345"                         // Not a palindrome
        };

        Console.WriteLine("Palindrome Checker:");
        foreach (var input in testInputs)
        {
            bool isPalindrome = PalindromeChecker.CekPalindrom(input);
            Console.WriteLine($"\"{input}\" is a palindrome? {isPalindrome}");
        }
        

    }
}
