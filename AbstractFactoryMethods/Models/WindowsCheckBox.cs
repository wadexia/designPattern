using System;

public class WindowsCheckBox: ICheckBox
{
    public void Enabled(){
        Console.WriteLine("Windows CheckBox Enabled.");
    }

    public void Selected(){
        Console.WriteLine("Windows CheckBox Selected.");
    }
}