using System.Linq;
using Microsoft.Data.Sqlite;
using Dapper;
using Smart.Mobile.Config;

namespace Smart.Mobile.Storage.Sqlite;

public class Bootstrapper(MobileQuizOptions options): ISqliteBootstrapper
{
    public void Initialize()
    {
        using var conn = new SqliteConnection($"Data Source={Path.Combine(options.Global.StoragePath, options.DbPath)}");
        
        var tableName = conn.Query<string>("SELECT name FROM sqlite_master WHERE type='table' AND name = 'tags';")
            .FirstOrDefault();
        // TODO: Isn't there a neater way to do this compare?
        if (!string.IsNullOrWhiteSpace(tableName) && tableName == "tags")
            return;
        
        conn.Execute("Create Table tags (" +
                           "name VARCHAR(100) NOT NULL," +
                           "value VARCHAR(1000) NULL);");
    }
}