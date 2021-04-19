using System;

public class WebDialog: Dialogs{
    public WebDialog(){
    }

    public override IButton CreateButton(){
        return new HtmlButton();
    }
}