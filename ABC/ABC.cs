using System.Collections.Generic;  
using System.Linq;  

namespace ABC
{
    public class ABC
    {

        public int SearchForCharacter(string character, List<string> blocks)
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

        public bool CanMakeWork(string word)
        {
            BlockFactory createBlocks = new BlockFactory();
            var blocks = createBlocks.CreateBlocks();  
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

        public List<string> UpdateBlocks(int index, List<string> blocks)
        {
            blocks.RemoveAt(index);
            return blocks;
        }
    }
}
