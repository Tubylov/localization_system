namespace ConsoleApp2.LocalizationSources;

public interface ILocalizationSource
{
    public string Locale { get; }
    public string? GetString(string localizationCode);
}

public enum LocalizationSourceType
{
    InMemory,
    ResourceFile,
    HttpApi,
}