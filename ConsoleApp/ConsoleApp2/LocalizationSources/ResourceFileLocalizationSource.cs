namespace ConsoleApp2.LocalizationSources;

public class ResourceFileLocalizationSource : ILocalizationSource
{
    public class ResourceFileMeta
    {
        public string FileName { get; set; }
        public string Content { get; set; }
    }

    private readonly ResourceFileMeta _meta;

    public ResourceFileLocalizationSource(string locale, ResourceFileMeta meta)
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