using Builder;
using Builder.Converters;
using Builder.Word;

void Convert()
{
    WordDocument document = new WordDocument();
    document.Body = new List<WordItem> ();
    document.Body.Add(new WordTitle { Title = "Main Title" });
    document.Body.Add(new WordParagraph
    {
        Lines = new List<string>
        {
            "Hello,",
            "This is Jawad Form Lahore",
            "The most attaractive city of Pakistan"
        }
    });
    var converter = new TextConverter();
    WordReader reader = new WordReader();
    reader.Convert(document, converter);
    Console.WriteLine(converter.GetTextFile().Text.ToString());

}

Convert();