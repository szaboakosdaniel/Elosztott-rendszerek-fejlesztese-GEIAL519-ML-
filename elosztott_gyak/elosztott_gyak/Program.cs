namespace elosztott_gyak
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args); // példányosítunk builder

            // Add services to the container.

            builder.Services.AddControllers(); // itt adja hozza a kontrollert
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer(); // End point API expoller
            builder.Services.AddSwaggerGen(); // Swagger

            var app = builder.Build(); // Prog tervezés Builder minte tervezési minta Komplexebb objektum ne mindent a konstrukturba

            // Configure the HTTP request pipeline.
           // if (app.Environment.IsDevelopment()) // ha developmentbe vagyunk
           // {
                app.UseSwagger(); // mostmár mindig használni fogja a sawggert
                app.UseSwaggerUI();
           // }

            app.UseAuthorization();

            app.MapControllers(); // Ahol én felanotáltam hogy legyen egy GET ott tényleg lesz

            app.Run();// elindítja
        }
    }
}