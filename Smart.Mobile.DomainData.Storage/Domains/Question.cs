namespace Smart.Mobile.DomainData.Storage.Domains;

public class Question
{
    public int Id { get; set; }
    // TODO: Localise default texts in ctors and inits.
    public QuestionType Type { get; set; } = new();
    public string Text { get; set; } = "Example Question";
    public string Answer { get; set; } = "Example Answer";
}