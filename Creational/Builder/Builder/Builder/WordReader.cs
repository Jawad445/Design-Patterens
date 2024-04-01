using Builder.MediaFiles;
using Builder.Word;
using Microsoft.VisualBasic.FileIO;

namespace Builder;

public class WordReader
{
    public void Convert(WordDocument doc, FileType fileType)
    {
        if(fileType == FileType.Text)
        {
            var textFile = new TextFile();
            foreach (var item in doc.Body)
            {
                if (item is WordTitle)
                {
                    textFile.ConvertTitle(item as WordTitle);
                }
                else if (item is WordParagraph)
                {
                    textFile.ConvertParagraph(item as WordParagraph);
                }
                else if (item is WordPicture)
                {
                    textFile.ConvertImage(item as WordPicture);
                }
                textFile.OpenText();
            }

        }
        else if(fileType == FileType.Audio)
        {
            var audioFile = new AudioFile();
            foreach (var item in doc.Body)
            {
                if (item is WordTitle)
                {
                    audioFile.ConvertTitle(item as WordTitle);
                }
                else if (item is WordParagraph)
                {
                    audioFile.ConvertParagraph(item as WordParagraph);
                }
                else if (item is WordPicture)
                {
                    audioFile.ConvertImage(item as WordPicture);
                }
                audioFile.openAudio();
            }
        }
    }
}
