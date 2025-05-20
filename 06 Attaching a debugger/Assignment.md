# Attaching a debugger
Sometimes you need to debug a process that is already running, for example when you want to debug a web application or a service. To do this, you can use the "Attach to Process" feature in Visual Studio. This feature allows you to attach the debugger to a running process and debug it like you would with your own code.

To get started, build the entire solution in Release. Then go to "Workshop.Debugging\06 Attaching a debugger\bin\Release\net9.0" and start "06 Attaching a debugger.exe". Note that because we build in release mode, we need to disable "Just my code".

Go back to VS, and attatch the process using Debug > Attach to Process or by pressing Ctrl + Alt + P. In the dialog that appears, select the process you want to attach to. You can use the search bar to filter the processes by name or id. Once you have selected the process, click "Attach" to attach the debugger. It is also possible to start debugging an application on a remote machine using the connections drop down, which can be useful for debugging applications in a deployed dev environment.

Now that the process is attached, you can set a breakpoint in the code and start debugging. The debugger will stop at the breakpoint and you can use the same debugging tools as you would with your own code. You can also use the "Detach All" option to detach the debugger from all running processes.

If you quickly want to reattach to the last process, you can use the "Reattach to last process" option in the Debug menu or by using Shift + Alt + P. This can be useful for quickly switching between different processes without having to go through the attach process again.

# References
- [Attatching a running process](https://learn.microsoft.com/visualstudio/debugger/attach-to-running-processes-with-the-visual-studio-debugger)
- [Remote debugging](https://learn.microsoft.com/visualstudio/debugger/remote-debugging)