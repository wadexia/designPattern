using System;

public class MacCheckBox: ICheckBox
{
    public void Enabled(){
        Console.WriteLine("Mac Input hidden.");
    }

    public void Selected(){
        Console.WriteLine("Mac Input Focused.");
    }
}