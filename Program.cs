// See https://aka.ms/new-console-template for more information
      /*
      This program is a copy of the game MadLibs that takes in a word from a user and completes a phrase ussing this word 
      Author: Dan Lindeblom
      */


      // Let the user know that the program is starting:

      Console.WriteLine("The program is starting.  Wait for the prompt, then enter a word!");
      // Give the Mad Lib a title:
      string title = "A Day in the the Life of a Wannabe Programmer";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();
      Console.Write("Enter an emotion: ");
      string emotion = Console.ReadLine();
      Console.Write("Enter a color: ");
      string color = Console.ReadLine();
      Console.Write("Enter a texture: ");
      string texture = Console.ReadLine();
      Console.Write("Enter a verb: ");
      string verb = Console.ReadLine();
      Console.Write("Enter a noun: ");
      string place = Console.ReadLine();
      Console.Write("Enter a noun: ");
      string noun = Console.ReadLine();
      Console.Write("Enter an animal: ");
      string animal = Console.ReadLine();
      Console.Write("Enter a food: ");
      string food = Console.ReadLine();
      Console.Write("Enter a fruit: ");
      string fruit = Console.ReadLine();
      Console.Write("Enter a superhero: ");
      string superhero = Console.ReadLine();
      Console.Write("Enter a country: ");
      string country = Console.ReadLine();
      Console.Write("Enter a dessert: ");
      string dessert = Console.ReadLine();
      Console.Write("Enter a year: ");
      string year = Console.ReadLine();



      // The template for the story:

      string story = $"This morning {name} woke up feeling {emotion}. 'It is going to be a {color} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {place}, which made all the {fruit}s very {texture}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun}s ruled the world.";


      // Print the story:

      Console.WriteLine(story);
