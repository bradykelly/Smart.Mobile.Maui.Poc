using Microsoft.Data.Sqlite;
using Smart.Mobile.Config;

namespace Smart.Mobile.Quizzes.Sqlite;

public class Sqlite(MobileQuizzOptions options)
{
    public IEnumerable<T> Fetch<T>(string fetchSql, Func<SqliteDataReader, T> map)
    {
        using var connection = OpenConnection();           

        using var command = new SqliteCommand(fetchSql, connection);
        using var reader = command.ExecuteReader();

        while (reader.Read())   
        {
            yield return map(reader);
        }
    }

    private SqliteConnection OpenConnection()
    {
        var connection = new SqliteConnection($"Data Source={options.DbPath}"); 
        connection.Open();
        return connection;
    }
}