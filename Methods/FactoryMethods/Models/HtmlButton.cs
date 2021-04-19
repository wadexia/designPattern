using System;

public class HtmlButton: IButton{
    public HtmlButton(){

    }
    public void Click(){
        Console.WriteLine("Html Button Clicked !");
    }
    public void Render(){
        Console.WriteLine("Html Button Rendered !");
    }
}