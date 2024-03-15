namespace Smart.Mobile.DomainData.Storage.Domains;

public class QuestionType
{
    public int Id { get; set; }
    public string Name { get; set; } = "Simple answer";
    public string Description { get; set; } = "Simple question with one correct answer.";
    public int CorrectAnswers { get; set; } = 1;
    public int RequiredAnswers { get; set; } = 1;
    // TODO: Add more question type properties e.g. images, audio, video, etc.
}