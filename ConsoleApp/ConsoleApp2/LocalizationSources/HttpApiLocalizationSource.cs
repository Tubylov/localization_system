namespace ConsoleApp2.LocalizationSources;

public class HttpApiLocalizationSource : ILocalizationSource
{
    public class HttpApiMeta
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string ApiKey { get; set; }
    }

    private readonly HttpApiMeta _meta;

    public HttpApiLocalizationSource(string locale, HttpApiMeta meta)
    {
        Locale = locale;
        _meta = meta;
    }

    public string Locale { get; }

    public string? GetString(string localizationCode)
    {
        // This is a template for potential future implementation
        throw new NotImplementedException();
    }
}