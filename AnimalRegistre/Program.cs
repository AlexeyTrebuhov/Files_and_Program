using AnimalsRegistre.Services;
using AnimalsRegistre.Services.Impl;
using System.Data.SQLite;

namespace AnimalRegistre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ConfigureSqliteConnection();
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IAnimalsRepository, AnimalsRepository>();

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

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
        private static void ConfigureSqliteConnection()
        {
            string connectionString = "Data Source = animals.db; Version = 3; Pooling = true; Max Pool Size = 10;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            PrepareSchema(connection);
        }
        private static void PrepareSchema(SQLiteConnection connection)
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "DROP TABLE IF EXISTS Animals";
            command.ExecuteNonQuery();

            command.CommandText =
                @"CREATE TABLE Animals(
                AnimalID INTEGER PRIMARY KEY,
                ClassName TEXT,
                AnimalName TEXT,
                DateOfBirth INTEGER,
                ExecutableCommands TEXT,
                AdditionalCommands TEXT,
                AdditionalCommandsToo TEXT)";

            command.ExecuteNonQuery();          
                

        }
    }
}