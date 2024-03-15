namespace Smart.Mobile.DomainData.Storage;

public interface ISqliteService
{
    // TODO: Find out about `Func<SqliteDataReader, T> map`
    //List<T> Fetch<T>(string fetchSql, Func<SqliteDataReader, T> map);

    IEnumerable<T> Query<T>(string querySql);
    
    // TODO: Could be more generic.
    void Execute(string commandSql);
}