using System;

public class WindowsButton: IButton{
    public WindowsButton(){

    }
    public void Click(){
        Console.WriteLine("Windows Button Clicked !");
    }
    public void Render(){
        Console.WriteLine("Windows Button Rendered !");
    }
}