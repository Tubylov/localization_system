namespace ConsoleApp2.LocalizationSources;

public interface ISourceFactory
{
    public ILocalizationSource BuildSource(string locale, LocalizationSourceType type, object meta);
}

public class SourceFactory : ISourceFactory
{
    public ILocalizationSource BuildSource(string locale, LocalizationSourceType type, object meta)
    {
        return type switch
        {
            LocalizationSourceType.InMemory => new InMemoryLocalizationSource(
                locale,
                meta as Dictionary<string, string> ?? throw new InvalidDataException()
            ),
            LocalizationSourceType.ResourceFile => new ResourceFileLocalizationSource(
                locale,
                meta as ResourceFileLocalizationSource.ResourceFileMeta ?? throw new InvalidDataException()
            ),
            LocalizationSourceType.HttpApi => new HttpApiLocalizationSource(
                locale,
                meta as HttpApiLocalizationSource.HttpApiMeta ?? throw new InvalidDataException()
            ),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}