using System;

public abstract class Dialogs{

    public abstract IButton CreateButton();
    public void Render(){
        IButton button = CreateButton();
        button.Render();
    }
}