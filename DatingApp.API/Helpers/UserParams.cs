namespace DatingApp.API.Helpers
{
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        public int pageSize { get; set; } = 10;
        public int MyProperty 
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value ; }
        }

        public int UserId {get; set;}
        public string Gender { get; set; }

        public int MinAge { get; set; } = 18;

        public int MaxAge { get; set; } = 99;

        public string OrderBy { get; set; }
<<<<<<< HEAD
=======
        public bool Likees { get; set; }  = false;
        public bool  Likers { get; set; } = false; 


>>>>>>> 56de0b010384e2fd3c67421b1929e042d6a8cc24

    }
}