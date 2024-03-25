using AbstractFactory.Frameworks.Base;
using AbstractFactory.Frameworks.FluentUI;

namespace AbstractFactory.Frameworks.Factories
{
    public class FluentUIViewFactory : IViewFactory
    {
        public IButton CreateButton()
        {
            return new FluentUIButton();
        }

        public ITextBox CreateTextBox()
        {
            return new FluentUITextBox();
        }
    }
}
