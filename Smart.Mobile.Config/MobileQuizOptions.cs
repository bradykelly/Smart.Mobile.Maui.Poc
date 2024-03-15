namespace Smart.Mobile.Config;

public class MobileQuizOptions: GlobalOptions
{
    public const string SettingsKey = nameof(MobileQuizOptions);
    public readonly GlobalOptions Global = new();
    
    public string DbPath { get; init; } = "quizzes.db";
}