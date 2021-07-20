using SQLite;
using System;

namespace HangmanGame.Resources.Moldels
{
    public class Word
    {
        [PrimaryKey, AutoIncrement]
        public int WordID { get; set; }
        public string hint { get; set; }
        public string text { get; set; }
    }
}