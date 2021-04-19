using System;

public class WindowsFactory: IGuiFactory
{
    public ICheckBox CreateCheckBox()
    {
        return new WindowsCheckBox();
    }

    public IInput CreateInput()
    {
        return new WindowsInput();
    }
}