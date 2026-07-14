// Exceeding requirements: the program randomly chooses a scripture
// from a small scripture library each time it starts.

using System;

  List<Scripture> scriptures = new List<Scripture>
  {
      new Scripture(new Reference("John", 3, 16, 17), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved."),
      new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
      new Scripture(new Reference("1 Nephi", 3, 7), "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
      new Scripture(new Reference("D&C", 6, 36), "Look unto me in every thought; doubt not, fear not.")
  };
  
  Random random = new Random();
  Scripture scripture = scriptures[random.Next(scriptures.Count)];

  while (true)
  {
      Console.Clear();
      Console.WriteLine(scripture.GetDisplayText());

      if (scripture.AllWordsHidden())
      {
          Console.WriteLine("All words are hidden. Press any key to exit.");
          Console.ReadKey();
          break;
      }

      Console.WriteLine("Press Enter to hide random words or type 'quit' to exit.");
      string input = Console.ReadLine();

      if (input.ToLower() == "quit")
      {
          break;
      }

      scripture.HideRandomWords(3);
  }
  
    