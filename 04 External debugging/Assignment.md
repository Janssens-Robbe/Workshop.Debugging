# Debugging external code
Sometimes it could be usefull to debug external code, for example when you want to see how a library works or if you want to debug a bug in the library. To do this, you can use the "Just My Code" feature in Visual Studio. This feature allows you to step into external code and view the source code of the library. To enable this feature, go to Tools > Options > Debugging > General and uncheck "Enable Just My Code".

Set a breakpoint on the EF query on line 23 in program.cs and start debugging. When the program stops at the breakpoint, you can step into the EF query by pressing F11. This will take you to the source code of the EF library, where you can view the code and debug it like you would with your own code.

# References
- [Just My Code](https://learn.microsoft.com/visualstudio/debugger/just-my-code)