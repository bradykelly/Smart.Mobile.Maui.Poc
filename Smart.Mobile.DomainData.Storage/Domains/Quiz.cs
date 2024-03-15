namespace Smart.Mobile.DomainData.Storage.Domains;

public class Quiz
{
    public int Id { get; set; } 
    public string Title { get; set; } = $"Smart Quiz [{DateTime.Now.TimeOfDay.Microseconds}]";
}