using System;

public class MacInput: IInput
{
    public void Hidden(){
        Console.WriteLine("Mac Input hidden.");
    }

    public void Focused(){
        Console.WriteLine("Mac Input Focused.");
    }
}