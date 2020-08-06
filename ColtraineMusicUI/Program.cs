using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace ColtraineMusicUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Octaves consist of 12 notes
            // Because you can call some notes two names depending if you are speaking in terms of sharps or flats,
            // I make two Ocatave Lists
            // Actually I think arrays work better. 
            //List<string> octaveSharp = new List<string>() { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            //List<string> octaveFlat = new List<string>() { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" }

            string[] octaveSharp = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            string[]  octaveFlat = new string[]  { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };

            // An interval is the distance between 2 notes and measured in terms of half steps and whole steps
            // Let's go for 5 steps and see what pops up.
            // Let's pick the starting key random.
            Random key = new Random();
            string keyBase = octaveFlat[key.Next(octaveFlat.Length)];
            Console.WriteLine($"Let's see what key we are playing in... {keyBase}");
            Console.WriteLine($"{keyBase} is one of my favorite keys to play in.\n Let's put 3 other chords with it.");

            // I am going to do a fifth music theory via John Coltrain now.

            int startInterval = 0;
            for (int i = 1; i < octaveFlat.Length; i++)
            {
                if (keyBase == octaveFlat[i]) startInterval = i;
            }

            bool chordsChosen = false;
            string[] numChords = new string[4];
            numChords[0] = keyBase;

            while (chordsChosen == false)
            {
                for (int i = 0; i < numChords.Length; i++)
                {


                
                }
            
            }
            



        }
    }
}
