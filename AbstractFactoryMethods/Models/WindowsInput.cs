using System;

public class WindowsInput: IInput
{
    public void Hidden(){
        Console.WriteLine("Windows Input hidden.");
    }

    public void Focused(){
        Console.WriteLine("Windows Input Focused.");
    }
}