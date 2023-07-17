using System.Globalization;
using ConsoleApp2.LocalizationSources;

namespace ConsoleApp2;

public class LocalizationManager
{
    private readonly List<ILocalizationSource> _sources;
    private readonly ISourceFactory _sourceFactory;

    public LocalizationManager(List<ILocalizationSource> defaultSources, ISourceFactory sourceFactory)
    {
        _sources = defaultSources;
        _sourceFactory = sourceFactory;
    }

    public string? GetString(string localizationCode, CultureInfo? cultureInfo = null)
    {
        cultureInfo ??= Thread.CurrentThread.CurrentCulture;
        return _sources
            .Where(s => s.Locale == cultureInfo.Name)
            .Select(source => source.GetString(localizationCode))
            .FirstOrDefault(result => result != null);
    }

    public void RegisterSource(string locale, LocalizationSourceType type, object meta)
    {
        try
        {
            _sources.Add(_sourceFactory.BuildSource(locale, type, meta));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}