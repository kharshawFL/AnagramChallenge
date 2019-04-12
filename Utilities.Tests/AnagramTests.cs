using System;
using WordFun.Utilities;
using Xunit;

namespace Utilities.Tests
{
    public class AnagramTests
    {
        
        [Fact]
        public void AreAnagrams_SameStrings_ReturnsTrue()
        {
            // arrange
            var anagramCheck = new Anagram();

            // act 
            var result = anagramCheck.AreAnagrams("abc", "abc");

            //assert
            Assert.True(result);            
        }

        [Theory]
        [InlineData("abc", "ABC")]
        [InlineData("abcd", "ABCD")]
        [InlineData("ab cd", "AB CD")]
        public void AreAnagrams_SameWordsMixedCase_DefaultConstructor_ReturnsFalse(string word1, string word2)
        {
            // arrange
            var anagramCheck = new Anagram();

            // act 
            var result = anagramCheck.AreAnagrams(word1, word2);

            //assert
            Assert.False(result);
        }
        [Fact]
        public void AreAnagrams_EmptyStrings_ReturnsTrue()
        {
            // arrange
            var anagramCheck = new Anagram();

            // act 
            var result = anagramCheck.AreAnagrams("", "");

            //assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("qwertyuio", "asdfghjkl")]
        [InlineData("zxcvbnm", "asdfgh")]
        [InlineData("123", "456")]
        public void AreAnagrams_ShareNoLetters_ReturnsFalse(string word1, string word2)
        {
            // arrange
            var anagramCheck = new Anagram();

            // act 
            var result = anagramCheck.AreAnagrams(word1, word2);

            //assert
            Assert.False(result);

        }

        [Theory]
        [InlineData("abc", "cba")]
        [InlineData("abcd", "dcba")]
        [InlineData("ab cd", "dcb a")]
        [InlineData("123", "321")]
        public void AreAnagrams_WordsWithLettersReversed_ReturnsTrue(string word1, string word2)
        {
            // arrange
            var anagramCheck = new Anagram();

            // act 
            var result = anagramCheck.AreAnagrams(word1, word2);

            //assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("aabbcc", "abc")]
        [InlineData("aa", "a")]
        [InlineData("aabbcc", "cba")]
        public void AreAnagrams_SameLettersDifferentLength_ReturnsFalse(string word1, string word2)
        {
            // arrange
            var anagramCheck = new Anagram(true);

            // act 
            var result = anagramCheck.AreAnagrams(word1, word2);

            //assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("cb", "cba")]
        [InlineData("ba", "cba")]
        [InlineData("", "cba")]
        public void AreAnagrams_SameCharactersDifferentLengths_ReturnsFalse(string word1, string word2)
        {
            // arrange
            var anagramCheck = new Anagram();

            // act 
            var result = anagramCheck.AreAnagrams(word1, word2);

            //assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("  ", " ")]
        [InlineData("\t", " ")]
        [InlineData("\t\t", " \t")]
        public void AreAnagrams_MismatchedWhitespace_ReturnsFalse(string word1, string word2)
        {
            // arrange
            var anagramCheck = new Anagram();

            // act 
            var result = anagramCheck.AreAnagrams(word1, word2);

            //assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(null, "cba")]
        [InlineData("abcd", null)]
        [InlineData(null, null)]
        public void AreAnagrams_NullWord_ThrowsInvalidateArgumentException(string word1, string word2)
        {
            // arrange
            var anagramCheck = new Anagram();

            // act & assert
            Assert.Throws<ArgumentNullException>(() => anagramCheck.AreAnagrams(word1, word2));

        }

        [Fact]
        public void AreAnagrams_ContainNonAlphaNumeric_ThrowsArgumentException()
        {
            // arrange
            var anagramCheck = new Anagram();

            // acts & assert
            Assert.Throws<ArgumentException>(() => anagramCheck.AreAnagrams("a$", "a$"));

        }

        [Theory]
        [InlineData("Abc", "abc")]
        [InlineData("ABC", "abc")]
        [InlineData("ABC", "CBA")]
        [InlineData("123", "321")]
        public void AreAnagrams_AnagramDifferentCase_IgnoreCaseTrue_ReturnsTrue(string word1, string word2)
        {
            // arrange
            var anagramCheck = new Anagram(true);

            // act 
            var result = anagramCheck.AreAnagrams(word1, word2);

            //assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("Abc", "abc")]
        [InlineData("ABC", "abc")]
        [InlineData("ABC", "Cba")]
        public void AreAnagrams_AnagramDifferentCase_IgnoreCaseFalse_ReturnsFalse(string word1, string word2)
        {
            // arrange
            var anagramCheck = new Anagram(false);

            // act 
            var result = anagramCheck.AreAnagrams(word1, word2);

            //assert
            Assert.False(result);
        }

    }
}
