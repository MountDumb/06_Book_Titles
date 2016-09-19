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
        public string Title
        {
            get { return title; }
            set
            {
                title = value.Substring(0, 1).ToUpperInvariant() 
                    + value.Substring(1);
            }
        }

    }
}