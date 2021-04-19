using System;

public class WindowsDialog: Dialogs{
    public WindowsDialog(){
    }

    public override IButton CreateButton(){
        return new WindowsButton();
    }
}