using Dapper;
using Microsoft.Data.Sqlite;
using Smart.Mobile.Config;
using Smart.Mobile.DomainData.Storage;

namespace Smart.Mobile.Storage;

public class SqliteService(MobileQuizOptions options): ISqliteService
{
    public IEnumerable<T> Query<T>(string querySql)
    {
        using var conn = new SqliteConnection($"Data Source={options.DbPath}");
        return conn.Query<T>(querySql);
    }

    public void Execute(string commandSql)
    {
        using var conn = new SqliteConnection($"Data Source={options.DbPath}");
        conn.Execute(commandSql);
    }
}