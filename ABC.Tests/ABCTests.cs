using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using ABC;

namespace ABC.Tests
{
    public class UnitTest1
    {
        ABC abc = new ABC();
        BlockFactory blockFactory = new BlockFactory();
        [Fact]
        public void given_CreateBlocks_returns_list()
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

                Assert.Equal(blockFactory.CreateBlocks(), blocks);   
        }

        [Fact]
        public void given_letterExists_when_SearchForCharacter_then_return_indexOfBlock()
        {
            var blocks = new List<string>() { 
                "BO",
                "AK",
            };
            Assert.Equal(1, abc.SearchForCharacter("A", blocks));
        }

        [Fact]
        public void given_letterDoesNotExist_when_SearchForCharacter_then_return_lengthOfBlocks()
        {
            var blocks = new List<string>() { 
                "BO",
                "MK",
            };
            Assert.Equal(2, abc.SearchForCharacter("A", blocks));
        }

        [Fact]
        public void given_indexEqualsOne_when_UpdateBlocks_then_removeBlock_from_list()
        {
            var blocks = new List<string>() { 
                "BO",
                "AK",
            };
            abc.UpdateBlocks(1, blocks);

            var expected = new List<string>(){
                "BO"
            };

            Assert.Equal(blocks, expected);
        }

        [Fact]
        public void given_wordEqualsBARK_when_CanMakeWork_then_return_true()
        {
            Assert.True(abc.CanMakeWork("BARK"));
        }

        [Fact]
        public void given_wordEqualsBark_when_CanMakeWork_then_return_true()
        {
            Assert.True(abc.CanMakeWork("Bark"));
        }

        [Fact]
        public void given_wordEqualsBOOK_when_CanMakeWork_then_return_false()
        {
            Assert.False(abc.CanMakeWork("BOOK"));
        }
    }
}

