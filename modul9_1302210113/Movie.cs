namespace modul9_1302210113
{
    public class Movie
    {
        private string v1;
        private string v2;
        private (string, string, string) value;
        private string v3;
        private (string, string, string, string) value1;

        public string Title { get; set; }

        public string Director { get; set; }

        public List Stars { get; set; } //Mungkin eror disini
        public string Description { get; set; }

        public Movie(
            String Title, 
            String Director, 
            List Stars, //
            String Description)
        {
            this.Title = Title;
            this.Director = Director;
            this.Stars = Stars; //
            this.Description = Description;
        }

        public Movie(string v1, string v2, (string, string, string) value, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.value = value;
            this.v3 = v3;
        }

        public Movie(string v1, string v2, (string, string, string, string) value1, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.value1 = value1;
            this.v3 = v3;
        }
    }


}
