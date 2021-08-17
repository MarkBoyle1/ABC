using System;
using System.Collections.Generic;  
using System.Linq;  

namespace ABC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABC Kata results:");
            Console.WriteLine("A: " + CanMakeWork("A"));
            Console.WriteLine("BARK: " + CanMakeWork("BARK"));
            Console.WriteLine("BOOK: " + CanMakeWork("BOOK"));
            Console.WriteLine("TREAT: " + CanMakeWork("TREAT"));
            Console.WriteLine("COMMON: " + CanMakeWork("COMMON"));
            Console.WriteLine("SQUAD: " + CanMakeWork("SQUAD"));
            Console.WriteLine("CONFUSE: " + CanMakeWork("CONFUSE"));
        }

        public static List<string> CreateBlocks()
        {
            var blocks = new List<string>() { 
                "BO",
                "XK",
                "DQ",
                "CP",
                "NA",
                "GT",
                "RE",
                "TG",
                "QD",
                "FS",
                "JW",
                "HU",
                "VI",
                "AN",
                "OB",
                "ER",
                "FS",
                "LY",
                "PC",
                "ZM"
                };
                return blocks;
        }

        public static int SearchForCharacter(string character, List<string> blocks)
        {
            for(var i = 0; i < blocks.Count; i++)
            {
                if(blocks[i].Contains(character))
                {
                    return i;
                }
            }
            return blocks.Count;
        }

        public static bool CanMakeWork(string word)
        {
            var blocks = CreateBlocks();  
            var characters = word.ToUpper().Select(character => character.ToString()).ToArray();
            foreach (string character in characters)
            {
                var result = SearchForCharacter(character, blocks);
                if(result < blocks.Count)
                {
                    blocks = UpdateBlocks(result, blocks);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static List<string> UpdateBlocks(int index, List<string> blocks)
        {
            blocks.RemoveAt(index);
            return blocks;
        }
    }
}
