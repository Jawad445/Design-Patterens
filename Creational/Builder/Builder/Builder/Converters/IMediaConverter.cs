using Builder.Word;

namespace Builder.Converters;

public interface IMediaConverter
{
    void ConvertParagraph(WordParagraph paragraph);
    void ConvertTitle(WordTitle title);
    void ConvertImage(WordPicture picture);
}
