using AbstractFactory.Frameworks.Base;

namespace AbstractFactory.Frameworks.Material;

public class MaterialButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Material Button");
    }
}
