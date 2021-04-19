using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory Methods
            // Dialogs WindowsDialog = new WindowsDialog();
            // IButton WindowsButton = WindowsDialog.CreateButton();
            // WindowsButton.Click();
            // Dialogs WebDialog = new WebDialog();
            // WebDialog.Render();

            //Abstract Factory Methods
            ICheckBox wck = new WindowsFactory().CreateCheckBox();
            wck.Enabled();
            wck.Selected();
            IInput mi = new MacFactory().CreateInput();
            mi.Focused();
        }
    }
}
