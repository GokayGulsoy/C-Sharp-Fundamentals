namespace Giraffe
{
    class Movie
    {
        private string rating;
        private string title;
        private string director;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                { 
                    rating = value;
                }

                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
