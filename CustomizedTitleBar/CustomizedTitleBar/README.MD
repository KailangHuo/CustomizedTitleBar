Getting tired of finding a solution to customize your title bar?
No idea about how to set he background color of the titlebar?
well you gotta try this UserControl!

well first you gotta import this nuget into your project, and then
you gotta give your window a name, which will be used in later process
, like this piece of code:
```
<Window x:Class="MainWindow"
        x:Name="ThisWindow"
        ...
        >
```

and then set this UserControl at the top of your Main Grid, you can
also edit its several features by setting just like this:
```
<customizedTitleBar:CustomizedTitileBar_UserControl Margin="0,0,0,-1"
                HostWindow="{Binding ElementName = ThisWindow}"
                Background="#FF24292E"
                BorderThickness="1"
                BorderBrush="Black"
                DrawingColor="WhiteSmoke"
                IconSource="<your_Icon_Path>"
            />

```

DO remember using "Binding" to bind the name of your window, "ThisWindow" in
this case, to the "HostWindow" property by useing the "ElementName" feature.

You are good to go!
