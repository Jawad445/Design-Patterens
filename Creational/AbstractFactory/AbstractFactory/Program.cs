using AbstractFactory.Frameworks.Enums;
using AbstractFactory.Frameworks.FluentUI;
using AbstractFactory.Frameworks.Material;

Render(FrameworkType.FluentUI);

void Render(FrameworkType frameworkType)
{
    switch (frameworkType)
    {
        case FrameworkType.Material:
            new MaterialButton().Render();
            new MaterialTextBox().Render();
            break;
        case FrameworkType.FluentUI:
            new FluentUIButton().Render();
            new FluentUITextBox().Render();
            break;
    }
}