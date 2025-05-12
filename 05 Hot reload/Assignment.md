# Hot reload
Restarting your application every time you make a small edit can be quite cumbersome. This can be sped up using Hot Reload, previously known as "Edit and Continue", or by using dotnet watch if you prefer the CLI. Hot Reload will apply your changes during runtime, allowing you to quickly itterate.

To get started, make sure you have Hot Reload enabled in the settings under Tools > Options > Debugging > .NET / C++ Hot Reload. Here you can also configure hot reload to automatically apply changes when you save the file, like the functionalty of dotnet watch. While the debugger is paused, hot reload will always automaticlly apply on any changes to your code.

Set a breakpoint in the do while loop and start the program. Guess a number and let your breakpoint be hit. You can now easily modify your code, for example change the tries increment, to a decrease instead. Step through your code and you will see that it decremented the tries instead of incrementing them. If you add new methods or classes however, you will need to restart the application. You can find a full list of limitations [here](https://learn.microsoft.com/visualstudio/debugger/supported-code-changes-csharp).

# References
- [Edit and Continue](https://learn.microsoft.com/visualstudio/debugger/how-to-enable-and-disable-edit-and-continue)
- [Hot Reload](https://learn.microsoft.com/visualstudio/debugger/hot-reload)
- [dotnet watch](https://learn.microsoft.com/dotnet/core/tools/dotnet-watch)