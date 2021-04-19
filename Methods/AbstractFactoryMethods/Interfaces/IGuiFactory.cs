using System;

public interface IGuiFactory
{
    IInput CreateInput();
    ICheckBox CreateCheckBox();
}