using AbstractFactory.Frameworks.Base;

namespace AbstractFactory.Frameworks.FluentUI;

public class FluentUITextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("Rendering FluentUI TextBox");
    }
}
