using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SkalProj_Datastrukturer_Minne;

class Program
{
    /// <summary>
    /// The main method, vill handle the menues for the program
    /// </summary>
    /// <param name="args"></param>
    static void Main()
    {

        while (true)
        {
            Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                + "\n1. Examine a List"
                + "\n2. Examine a Queue"
                + "\n3. Examine a Stack"
                + "\n4. CheckParenthesis"
                + "\n0. Exit the application");
            char input = ' '; //Creates the character input to be used with the switch-case below.
            try
            {
                input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
            }
            catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
            {
                Console.Clear();
                Console.WriteLine("Please enter some input!");
            }
            switch (input)
            {
                case '1':
                    ExamineList();
                    break;
                case '2':
                    ExamineQueue();
                    break;
                case '3':
                    ExamineStack();
                    break;
                case '4':
                    CheckParanthesis();
                    break;
                /*
                 * Extend the menu to include the recursive 
                 * and iterative exercises.
                 */
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                    break;
            }
        }
    }

    /// <summary>
    /// Examines the datastructure List
    /// </summary>
    static void ExamineList()
    {
        /*
         * Loop this method untill the user inputs something to exit to main menue.
         * Create a switch statement with cases '+' and '-'
         * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
         * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
         * In both cases, look at the count and capacity of the list
         * As a default case, tell them to use only + or -
         * Below you can see some inspirational code to begin working.
        */

        var theList = new List<string>();
        var exit = false;

        do {
            var description = "Use '+<your_text>' to add a text item, '-<your_text>' to remove a text item, or 'q/Q' to quit.";
            Console.WriteLine(description);
            string input = Console.ReadLine() ?? "";
            char nav = input[0];
            string value = input.Substring(1);


            Console.WriteLine($"List capacity before {theList.Capacity}");
            Console.WriteLine($"List count before {theList.Count}");
            switch (nav) {
                case '+':
                    Console.WriteLine($"Add text item");
                    theList.Add(value);
                    break;
                case '-':
                    Console.WriteLine($"Remove text item");
                    theList.Remove(value);
                    break;
                case 'q' or 'Q':
                    exit = true;
                    break;
                default:
                    Console.WriteLine(description);
                    break;

            }
            Console.WriteLine($"List capacity after {theList.Capacity}");
            Console.WriteLine($"List count after {theList.Count}");
        } while (!exit);

        var answer = """
        A List is have first capacity one, the when adding an item to the list the list increase internally to an array with capacity 4.
        Then when the list is full again it will double the size of its internal array to 8, 16, 32, etc... The list will never decrease
        the size of its internal array even if the items are removed to zero items.
        """;
        Console.WriteLine(answer);
    }

    /// <summary>
    /// Examines the datastructure Queue
    /// </summary>
    static void ExamineQueue()
    {
        /*
         * Loop this method untill the user inputs something to exit to main menue.
         * Create a switch with cases to enqueue items or dequeue items
         * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
        */

        var theQueue = new Queue<string>();
        var exit = false;

        do
        {
            var description = "Use '+<your_text>' to add a text item, '-' to remove a text item, or 'q/Q' to quit.";
            Console.WriteLine(description);
            string input = Console.ReadLine() ?? "";
            char nav = input[0];
            string value = input.Substring(1);


            Console.WriteLine($"Queue size before {theQueue.Count}");
            theQueue.ToList().ForEach(item => Console.Write($"{item} "));
            switch (nav)
            {
                case '+':
                    Console.WriteLine($"Add text item");
                    theQueue.Enqueue(value);
                    break;
                case '-':
                    Console.WriteLine($"Remove text item");
                    theQueue.Dequeue();
                    break;
                case 'q' or 'Q':
                    exit = true;
                    break;
                default:
                    Console.WriteLine(description);
                    break;

            }
            Console.WriteLine($"Queue size before {theQueue.Count}");
            theQueue.ToList().ForEach(item => Console.Write($"{item} "));
        } while (!exit);

        // Simulation of ICA queue.
        var icaQueue = new Queue<string>();
        Console.WriteLine("\nSimulation of ICA queue");
        Console.WriteLine("\na. Empty queue");
        icaQueue.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\nb. Kalle in queue");
        icaQueue.Enqueue("Kalle");
        icaQueue.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\n\nc. Greta in queue");
        icaQueue.Enqueue("Greta");
        icaQueue.ToList().ForEach(item => Console.Write($"{item} "));
        icaQueue.Dequeue();
        Console.WriteLine("\n\nd. Kalle leave queue");
        icaQueue.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\n\ne. Stina in queue");
        icaQueue.Enqueue("Stina");
        icaQueue.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\n\nf. Greta leave queue");
        icaQueue.Dequeue();
        icaQueue.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\n\ng. Olle in queue");
        icaQueue.Enqueue("Olle");
        icaQueue.ToList().ForEach(item => Console.Write($"{item} "));

    }


    /// <summary>
    /// Examines the datastructure Stack
    /// </summary>
    static void ExamineStack()
    {
        /*
         * Loop this method until the user inputs something to exit to main menue.
         * Create a switch with cases to push or pop items
         * Make sure to look at the stack after pushing and and poping to see how it behaves
        */

        //Övning 3: ExamineStack()
        //Stackar påminner om köer, men en stor skillnad är att stackar använder sig av Först In Sist
        //Ut(FILO) principen.Alltså gäller att det element som stoppas in först(push) är det som
        //kommer tas bort sist(pop).
        //5 / 7
        //1.Simulera ännu en gång ICA-kön på papper. Denna gång med en stack.Varför är det
        //inte så smart att använda en stack i det här fallet?
        //2.Implementera en ReverseText-metod som läser in en sträng från användaren och
        //med hjälp av en stack vänder ordning på teckenföljden för att sedan skriva ut den
        //omvända strängen till användaren.

        // Simulation of ICA queue with stack.
        var icaQueueAsStack = new Stack<string>();
        Console.WriteLine("\nSimulation of ICA queue with stack (LIFO is not suitable for a ICA queue)");
        Console.WriteLine("\na. Empty queue");
        icaQueueAsStack.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\nb. Kalle in queue");
        icaQueueAsStack.Push("Kalle");
        icaQueueAsStack.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\n\nc. Greta in queue");
        icaQueueAsStack.Push("Greta");
        icaQueueAsStack.ToList().ForEach(item => Console.Write($"{item} "));
        icaQueueAsStack.Pop();
        Console.WriteLine("\n\nd. Kalle want to leave queue but is not last is in queue");
        icaQueueAsStack.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\n\ne. Stina in queue");
        icaQueueAsStack.Push("Stina");
        icaQueueAsStack.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\n\nf. Greta want to leave queue but is not last in queue");
        icaQueueAsStack.Pop();
        icaQueueAsStack.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\n\ng. Olle in queue");
        icaQueueAsStack.Push("Olle");
        icaQueueAsStack.ToList().ForEach(item => Console.Write($"{item} "));

        var description = "\n\nAdd a text that will be reversed.";
        Console.WriteLine(description);
        string input = Console.ReadLine() ?? "";
        var charStack = new Stack<char>();
        input.ToList().ForEach(charStack.Push);
        var inputSize = charStack.Count;
        Console.WriteLine("\nReversed string:");
        Console.WriteLine(GetReverseText(input));
        Console.WriteLine("Reversed string end\n");
    }

    /// <summary>
    /// A method use to reverse text using a stack a stack as DS.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    static string GetReverseText(string text)
    {
        var charStack = new Stack<char>();
        text.ToList().ForEach(charStack.Push);
        var inputSize = charStack.Count;
        var reversedText = new StringBuilder();
        for (int i = 0; i < inputSize; i++)
        {
            reversedText.Append(charStack.Pop());
        }
        return reversedText.ToString();
    }

    static void CheckParanthesis()
    {
        /*
         * Use this method to check if the paranthesis in a string is Correct or incorrect.
         * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
         * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
         */

        var correctExample = "(()), {}, [({})]";
        var inCorrectExample = "(()]), [), {[()}]";
        Console.WriteLine(IsCorrectFormat(correctExample));
        Console.WriteLine(IsCorrectFormat(inCorrectExample));
    }

    /// TODO! Validate and clean up.
    private static bool IsCorrectFormat(string text)
    {
        try
        {
            return IsTextContainingMatchinBrackets(text);
        }
        catch (Exception e) {
            Console.WriteLine(e);
            return false;
        }
    }

    /// TODO! Validate and clean up.
    private static bool IsTextContainingMatchinBrackets(string text) 
    {
        HashSet<char> openingBrackets = ['(', '[', '{', '<'];
        HashSet<char> closingBrackets = [')', ']', '}', '>'];

        var charQueue = new Queue<char>();
        var openingBracketStack = new Stack<char>();
        text.ToList().ForEach(charQueue.Enqueue);
        var textSize = charQueue.Count;

        for (int i = 0; i < textSize; i++)
        {
            var dequeuedChar = charQueue.Dequeue();
            if (openingBrackets.Contains(dequeuedChar))
            {
                openingBracketStack.Push(dequeuedChar);
            }
            else if (closingBrackets.Contains(dequeuedChar))
            {
                if (!IsMatchingBrackets(openingBracketStack.Pop(), dequeuedChar))
                {
                    return false;
                }
            }
        }
        return true;
    }

    /// TODO! Validate and clean up.
    private static bool IsMatchingBrackets(char openingBracket, char closingBracket)
    {
        HashSet<char> openingBrackets = ['(', '[', '{'];
        HashSet<char> closingBrackets = [')', ']', '}'];

        if (!openingBrackets.Contains(openingBracket)) 
        {
            return false; 
        }
        else if (!closingBrackets.Contains(closingBracket)) 
        {
            return false;
        }
        else
        {
            return (
                $"{openingBracket}{closingBracket}" == "()" ||
                $"{openingBracket}{closingBracket}" == "[]" ||
                $"{openingBracket}{closingBracket}" == "{}"
            ); 
        }
    }
}

