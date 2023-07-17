namespace ConsoleApp2.LocalizationSources;

public class InMemoryLocalizationSource : ILocalizationSource
{
    private readonly Dictionary<string, string> _data;

    public InMemoryLocalizationSource(string locale, Dictionary<string, string> data)
    {
        Locale = locale;
        _data = data;
    }

    public string Locale { get; }

    public string? GetString(string localizationCode)
    {
        return _data.GetValueOrDefault(localizationCode);
    }
}