using AnimalsRegistre.Models;
using System.Data;
using System.Data.SQLite;

namespace AnimalsRegistre.Services.Impl
{
    public class AnimalsRepository : IAnimalsRepository
    {
        private const string connectionString = "Data Source = animals.db; Version = 3; Pooling = true; Max Pool Size = 10;";
        public int Create(Animals item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "INSERT INTO Animals(ClassName, AnimalName, DateOfBirth, ExecutableCommands, AdditionalCommands, AdditionalCommandsToo) VALUES (@ClassName, @AnimalName, @DateOfBirth, @ExecutableCommands, @AdditionalCommands, @AdditionalCommandsToo)";
            command.Parameters.AddWithValue("@ClassName", item.ClasslName);
            command.Parameters.AddWithValue("@AnimalName", item.AnimalName);
            command.Parameters.AddWithValue("@DateOfBirth", item.DateOfBirth.Ticks);
            command.Parameters.AddWithValue("@ExecutableCommands", item.ExecutableCommands);
            command.Parameters.AddWithValue("@AdditionalCommands", item.AdditionalCommands);
            command.Parameters.AddWithValue("@AdditionalCommandsToo", item.AdditionalCommandsToo);
            command.Prepare();
            int res = command.ExecuteNonQuery();  
            connection.Close();
            return res;
        }

        public int Delete(int id)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "DELETE FROM animals WHERE AnimalId = @AnimalId";
            command.Parameters.AddWithValue("@AnimalId", id);         
            command.Prepare();
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res;
        }

        public int Delete(Animals item)
        {
            throw new NotImplementedException();
        }

        public int DeleteAll()
        {
            throw new NotImplementedException();
        }

        public IList<Animals> GetAll()
        {
            List<Animals> list = new List<Animals>();   
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "SELECT * FROM animals";
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Animals animal = new Animals();
                animal.AnimalId = reader.GetInt32(0);
                animal.ClassName = reader.GetString(1);
                animal.AnimalName = reader.GetString(2);
                animal.DateOfBirth = new DateTime (reader.GetInt64(3));
                animal.ExecutableCommands = reader.GetString(4);
                animal.AdditionalCommands = reader.GetString(5);
                animal.AdditionalCommandsToo = reader.GetString(6);

                list.Add(animal);
            }
            
            connection.Close();
            return list;
        }

        public Animals GetById(int id)
        {
          
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "SELECT * FROM animals WHERE AnimalsId = @AnimalsId";
            command.Parameters.AddWithValue("@AnimalId", id);
            command.Prepare();
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Animals animal = new Animals();
                animal.AnimalId = reader.GetInt32(0);
                animal.ClassName = reader.GetString(1);
                animal.AnimalName = reader.GetString(2);
                animal.DateOfBirth = new DateTime(reader.GetInt64(3));
                animal.ExecutableCommands = reader.GetString(4);
                animal.AdditionalCommands = reader.GetString(5);
                animal.AdditionalCommandsToo = reader.GetString(6);

                connection.Close();
                return animal;
            }
            else
            {
                connection.Close();
                return null;
            }
        }

        public int Update(Animals item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "UPDATE animals SET ClassName=@ClassName, AnimalName=@AnimalName, DateOfBirth=@DateOfBirth, ExecutableCommands=@ExecutableCommands, AdditionalCommands=@AdditionalCommands, AdditionalCommandsToo = @AdditionalCommandsToo WHERE AnimalId=@AnimalId";
            command.Parameters.AddWithValue("@AnimalId", item.AnimalId);
            command.Parameters.AddWithValue("@ClassName", item.ClasslName);
            command.Parameters.AddWithValue("@AnimalName", item.AnimalName);
            command.Parameters.AddWithValue("@DateOfBirth", item.DateOfBirth.Ticks);
            command.Parameters.AddWithValue("@ExecutableCommands", item.ExecutableCommands);
            command.Parameters.AddWithValue("@AdditionalCommands", item.AdditionalCommands);
            command.Parameters.AddWithValue("@AdditionalCommandsToo", item.AdditionalCommandsToo);

            command.Prepare();
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res;
        }
    }
}
