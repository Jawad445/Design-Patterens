using AbstractFactory.Frameworks.Base;

namespace AbstractFactory.Frameworks.FluentUI;

public class FluentUIButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering FluentUI Button");
    }
}
