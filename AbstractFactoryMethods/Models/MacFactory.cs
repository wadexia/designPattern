using System;

public class MacFactory: IGuiFactory
{
    public ICheckBox CreateCheckBox()
    {
        return new MacCheckBox();
    }

    public IInput CreateInput()
    {
        return new MacInput();
    }
}