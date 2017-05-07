# How to use
Simply copy the "SimplePreviewer.cs" file into your proj.

Then append your void main like so:
```
static void Main()
{
    // if previewer is active don't run normal app logic !!!
    if (AvaloniaPV.SimplePreviewer.Init()) return;

    // do normal stuff (when previewer not active)...
}
```

Test sln is for VS 2017 .NET Core (SimplePreviewer.cs should work with any .net version)