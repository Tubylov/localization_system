using ConsoleApp2;
using ConsoleApp2.LocalizationSources;

var localizationManager = new LocalizationManager(
    new List<ILocalizationSource>(),
    new SourceFactory()
);

localizationManager.RegisterSource("en-US", LocalizationSourceType.InMemory, new Dictionary<string, string>
{
    { "greeting", "Hello!" },
    { "prompt", "Enter your name" },
    { "exit", "Exit" },
});

localizationManager.RegisterSource("ru-RU", LocalizationSourceType.InMemory, new Dictionary<string, string>
{
    { "greeting", "Привет!" },
    { "prompt", "Введите имя" },
    { "exit", "Выход" },
});

Console.WriteLine(localizationManager.GetString("greeting"));