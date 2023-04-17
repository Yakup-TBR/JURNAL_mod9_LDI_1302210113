namespace modul9_1302210113
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            var Movie = new Movie[]
            {
                new Movie("The Shawshank Redemption", " Frank Darabont", ("Tim Robbins", " Morgan Freeman", "William Sadler"), "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."),
                new Movie("The Godfather", " Francis Ford Coppola", (" Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"), "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
                new Movie("The Dark Knight", "Peter Jackson", (" Elijah Wood", "SViggo Mortensen", "Ian McKellen", "Orlando Bloom"), "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."),
            };



            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}




