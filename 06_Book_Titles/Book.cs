using System.Linq;

namespace _06_Book_Titles
{
    internal class Book
    {
        //Fields
        private string title;
        //Constructor
        public Book()
        {
        }

        //Properties

        private string Capitalize(string s)
        {
            string[] blacklist = {"the", "a", "an", "and", "in", "of" };
            string[] words = s.Split();

            string cappedwords = words[0].Substring(0,1).ToUpperInvariant()
                + words[0].Substring(1) + " ";

            for (int i = 1; i < words.Length; i++)
            {
                if (!blacklist.Contains(words[i]))
                {
                    cappedwords += words[i].Substring(0, 1).ToUpperInvariant()
                                + words[i].Substring(1) + " ";
                }
                else
                {
                    cappedwords += words[i] + " ";
                }
            }

           
            return cappedwords.Trim(); 
        }
        
        //Properties
        public string Title
        {
            get { return title; }
            set
            {
                title = Capitalize(value);

            }
        }

    }
}