internal class Program
{
    /// <summary>
    /// Program's main method. Displays the initial prompt, loads the dictionary with all allowed
    /// characters, and takes in the user message input. Removes all non-allowed characters,
    /// clears the console, and invokes the PrintMessage method.
    /// </summary>
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter a message including: a-z, 0-9, ( ), +, /, -, _, .");
            Console.Write("Your message: ");

            Dictionary<char, List<string>> allLetters = GetAllLetters();
            List<char> message = Console.ReadLine().ToLower().ToList();

            RemoveUnknownCharacters(message, allLetters);

            Console.Clear();
            PrintMessage(allLetters, message);

            Console.Write("Press any key to continue...");
            Console.ReadKey();

            Console.Clear();
            Thread.Sleep(700);
        }
    }

    /// <summary>
    /// Removes all non-allowed characters from the user's input message.
    /// </summary>
    /// <param name="message">The user's normalized message as a char array.</param>
    /// <param name="allLetters">A dictionary where the keys are all allowed symbols.</param>
    private static void RemoveUnknownCharacters(List<char> message, Dictionary<char, List<string>> allLetters)
    {
        for (int i = 0; i < message.Count; i++)
        {
            if (!allLetters.ContainsKey(message[i]))
            {
                message.RemoveAt(i--);
            }
        }
    }

    /// <summary>
    /// Inserts a buffer of underscores if the message's length exceeds the console's width.
    /// for each character of the message, creates a new Character class, giving its constructor
    /// the necessary named segments by getting the 'allLetters' respective array value, and the current coordinates.
    /// If the X coordinates becomes more than the Console's width, a pause is made, and then the message is re-rendered
    /// with one letter forward, so that it flows left like on an information display.
    /// </summary>
    /// <param name="allLetters">A dictionary which's keys are the allowed characters,
    /// and the values being the character's necessary named segments.</param>
    /// <param name="message"></param>
    public static void PrintMessage(Dictionary<char, List<string>> allLetters, List<char> message)
    {
        if (message.Count > 9)
        {
            message.InsertRange(0, "_____".ToList());
        }

        int x = 2;
        int y = 1;

        for (int i = 0; i < message.Count; i++)
        {
            char c = message[i];
            Character currentCharacter = new Character(allLetters[c], x, y);
            currentCharacter.PrintCharacter();

            x += 12;

            if (c == '.')
            {
                x -= 12;
            }

            if (x > Console.BufferWidth)
            {
                Thread.Sleep(150);
                Console.Clear();

                x = 2;
                y = 1;
                i -= 9;
            }
        }
    }

    /// <summary>
    /// Returns a dictionary where the keys are letters of the alphabet and other symbols.
    /// The values are lists of type string that hold the letter's necessary named segments.
    /// </summary>
    /// <returns></returns>
    public static Dictionary<char, List<string>> GetAllLetters()
    {
        Dictionary<char, List<string>> allLetters = new Dictionary<char, List<string>>();

        allLetters['a'] = "a1 a2 b c e f g1 g2".Split().ToList();
        allLetters['b'] = "a1 a2 b c d1 d2 g1 g2 i l".Split().ToList();
        allLetters['c'] = "a1 a2 d1 d2 e f".Split().ToList();
        allLetters['d'] = "a1 a2 b c d1 d2 i l".Split().ToList();
        allLetters['e'] = "a1 a2 d1 d2 e f g1 g2".Split().ToList();
        allLetters['f'] = "a1 a2 g1 g2 e f".Split().ToList();
        allLetters['g'] = "a1 a2 f e d1 d2 c g2".Split().ToList();
        allLetters['h'] = "f b e c g1 g2".Split().ToList();
        allLetters['i'] = "a1 a2 i l d1 d2".Split().ToList();
        allLetters['j'] = "b c d1 d2 e".Split().ToList();
        allLetters['k'] = "f e g1 j m".Split().ToList();
        allLetters['l'] = "f e d1 d2".Split().ToList();
        allLetters['m'] = "e f h j b c".Split().ToList();
        allLetters['n'] = "e f h m c b".Split().ToList();
        allLetters['o'] = "a1 a2 b c d1 d2 e f".Split().ToList();
        allLetters['p'] = "e f a1 a2 b g2 g1".Split().ToList();
        allLetters['q'] = "a1 a2 b c d1 d2 e f m".Split().ToList();
        allLetters['r'] = "a1 a2 b g2 g1 f e m".Split().ToList();
        allLetters['s'] = "a2 a1 f g1 g2 c d2 d1".Split().ToList();
        allLetters['t'] = "a1 a2 i l".Split().ToList();
        allLetters['u'] = "f e d1 d2 c b".Split().ToList();
        allLetters['v'] = "f e k j".Split().ToList();
        allLetters['w'] = "f e k m c b".Split().ToList();
        allLetters['x'] = "h j k m".Split().ToList();
        allLetters['y'] = "f g1 g2 b c d2 d1 ".Split().ToList();
        allLetters['z'] = "a1 a2 j k d1 d2".Split().ToList();
        allLetters['0'] = "a1 a2 b c d1 d2 e f j k".Split().ToList();
        allLetters['1'] = "j b c".Split().ToList();
        allLetters['2'] = "a1 a2 b g2 g1 e d1 d2".Split().ToList();
        allLetters['3'] = "a1 a2 b g2 g1 c d2 d1".Split().ToList();
        allLetters['4'] = "f g1 g2 b c".Split().ToList();
        allLetters['5'] = "a2 a1 f g1 m d2 d1".Split().ToList();
        allLetters['6'] = "a2 a1 f e d1 d2 c g2 g1".Split().ToList();
        allLetters['7'] = "a1 a2 j k".Split().ToList();
        allLetters['8'] = "a1 a2 b c d2 d1 e f g1 g2".Split().ToList();
        allLetters['9'] = "a1 a2 b c d2 d1 g2 g1 f".Split().ToList();
        allLetters['+'] = "i l g1 g2".Split().ToList();
        allLetters['-'] = "g1 g2".Split().ToList();
        allLetters['_'] = "d1 d2".Split().ToList();
        allLetters['/'] = "j k".Split().ToList();
        allLetters['('] = "j m".Split().ToList();
        allLetters[')'] = "h k".Split().ToList();
        allLetters[' '] = "".Split().ToList();
        allLetters['.'] = ".".Split().ToList();

        return allLetters;
    }
}

/// <summary>
/// The character class. It handles drawing a single character on the console.
/// </summary>
class Character
{
    public Character(List<string> inputSegments, int x, int y)
    {
        SegmentsArray = LoadSegments(inputSegments);
        DrawActions = LoadActions(x, y);
    }

    public string LetterName { get; set; } = string.Empty;
    public int[] SegmentsArray { get; set; }
    public List<Action> DrawActions { get; set; }

    /// <summary>
    /// Invokes the DrawLine method with different coordinates, so that all
    /// 16 segments of the display are drawn, as well as a final 17th method for the dot.
    /// The sequential delegates for drawing all segments are returned as an Action array.
    /// </summary>
    /// <param name="x">Current letter X coordinate.</param>
    /// <param name="y">Current letter Y coordinate.</param>
    /// <returns></returns>
    public static List<Action> LoadActions(int x, int y)
    {
        List<Action> drawActions = new List<Action>
        {
            () => DrawLineH(x, y),
            () => DrawLineH(x + 4, y),
            () => DrawLineV(x + 7, y + 1),
            () => DrawLineV(x + 7, y + 5),
            () => DrawLineH(x, y + 8),
            () => DrawLineH(x + 4, y + 8),
            () => DrawLineV(x - 1, y + 5),
            () => DrawLineV(x - 1, y + 1),
            () => DrawLineH(x, y + 4),
            () => DrawLineH(x + 4, y + 4),
            () => DrawLineDRight(x, y + 1),
            () => DrawLineV(x + 3, y + 1),
            () => DrawLineDLeft(x + 6, y + 1),
            () => DrawLineDLeft(x + 2, y + 5),
            () => DrawLineV(x + 3, y + 5),
            () => DrawLineDRight(x + 4, y + 5),
            () => DrawDot(x - 3, y + 7)
        };

        return drawActions;
    }

    /// <summary>
    /// Compares which named segment of the input letter is present, and returns an array of 0 and 1
    /// where 0 is a segment to be drawn, and 1 is for a segment not to be drawn.
    /// </summary>
    /// <param name="letterInput">The letter's named segments.</param>
    /// <returns></returns>
    public static int[] LoadSegments(List<string> letterInput)
    {
        string[] allSegments = new string[] { "a1", "a2", "b", "c", "d1", "d2", "e", "f", "g1", "g2", "h", "i", "j", "k", "l", "m", "." };
        int[] character = new int[17];

        for (int i = 0; i < allSegments.Length; i++)
        {
            string currentSegment = allSegments[i];

            if (!letterInput.Contains(currentSegment))
            {
                character[i] = 1;
            }
        }

        return character;
    }

    /// <summary>
    /// Draws a dot on the console with the given coordinates.
    /// </summary>
    /// <param name="x">The given X coordinate value.</param>
    /// <param name="y">The given Y coordinate value.</param>
    private static void DrawDot(int x, int y)
    {
        Console.SetCursorPosition(x, y + 1);
        Console.Write("#");
    }

    /// <summary>
    /// Draws a diagonal forward slash on the console with the given coordinates.
    /// </summary>
    /// <param name="x">The given X coordinate value.</param>
    /// <param name="y">The given Y coordinate value.</param>
    private static void DrawLineDLeft(int x, int y)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(x--, y++);
            Console.Write("*");
        }
    }

    /// <summary>
    /// Draws a diagonal backward slash on the console with the given coordinates.
    /// </summary>
    /// <param name="x">The given X coordinate value.</param>
    /// <param name="y">The given Y coordinate value.</param>
    private static void DrawLineDRight(int x, int y)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(x++, y++);
            Console.Write("*");
        }
    }

    /// <summary>
    /// Draws a vertical line on the console with the given coordinates.
    /// </summary>
    /// <param name="x">The given X coordinate value.</param>
    /// <param name="y">The given Y coordinate value.</param>
    private static void DrawLineV(int x, int y)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(x, y + i);
            Console.Write("*");
        }
    }

    /// <summary>
    /// Draws a horizontal forward slash on the console with the given coordinates.
    /// </summary>
    /// <param name="x">The given X coordinate value.</param>
    /// <param name="y">The given Y coordinate value.</param>
    public static void DrawLineH(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine("***");
    }

    /// <summary>
    /// Prints the character on the console. It goes through the letter's 0 and 1 array
    /// of 17 elements where a 0 means invoking the i-th Action method from the delegate
    /// array to draw the respective segment.
    /// This way only the necessary segments are drawn.
    /// </summary>
    public void PrintCharacter()
    {
        for (int i = 0; i < SegmentsArray.Length; i++)
        {
            if (SegmentsArray[i] == 0)
            {
                DrawActions[i].Invoke();
            }
        }

        Console.SetCursorPosition(0, 12);
    }
}