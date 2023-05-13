using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal Program!");
        Entry myChoice = new Entry();
        Journal myEntry = new Journal();
        PromptGenerator myPrompts = new PromptGenerator();
        myPrompts._prompts.Add("If I had one thing I could do over today, what would it be?");
        myPrompts._prompts.Add("What are you planning to do this weekend?");
        myPrompts._prompts.Add("How was your day?");
        myPrompts._prompts.Add("Is there something you missed doing today?");
        myPrompts._prompts.Add("Did you start to work in your school project for this week?");
       
        myPrompts._prompt = "";
        myEntry._entry = "";
        
        while(myChoice._answer != "5"){
            
            myChoice.DisplayMenu();
            myChoice._answer = Console.ReadLine();            
            if(myChoice._answer == "1"){
                 myPrompts._prompt = myPrompts.GetRandomPrompt();
                 Console.WriteLine(myPrompts._prompt);
                 myEntry._entry = Console.ReadLine();
                 myEntry.SaveEntries(myEntry._entry,myPrompts._prompt);     
            }

            if(myChoice._answer == "2"){
                myEntry.DisplayEntries();
            }

            if(myChoice._answer == "3"){
                Console.Write("Please type the name of the file: ");
                string fileOpen = Console.ReadLine();
                myEntry.LoadFile(fileOpen);
            }

            if(myChoice._answer == "4"){
                Console.Write("Please type the name of the file, like this 'myfile.txt': ");
                string fileName = Console.ReadLine();
                myEntry.SaveToFile(fileName);
            }
        }

    }
}