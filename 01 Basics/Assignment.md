# 1. Breakpoints
All references to VS documentation for a more detailed explaination are at the bottom of this document.

You can skip to [Watch window](#2-watch-window) if you're used to using breakpoints.

## 1.1. Setting up breakpoints to follow the application process
Explore the console application using breakpoints. Set some breakpoints in program.cs for example line 4 and 49 by click in the left margin of the code editor. You can also set breakpoints by pressing F9 when the cursor is on the line you want to set a breakpoint. 

In the top toolbar, make sure you have the project "01 Introduction" selected and have selected the Debug profile. Start debugging by pressing F5 or clicking the green arrow. The program will start and stop at the first breakpoint.

Use F10 to step over the code line by line. You can also use F11 to step into the code if you want to go into a method. Don't forget that you still need to give input to the console app, or it will hold at a `Console.ReadLine()` line.

## 1.2. View the value of variables
When the program stops at a breakpoint, you can hover over variables to see their values. You can also use the "Watch" window, more about that later in this assignment.

## 1.3. Managing breakpoints
You can manage breakpoints in the "Breakpoints" window. You can open it by going to Debug > Windows > Breakpoints or by pressing Ctrl + Alt + B. In this window, you can enable/disable breakpoints, delete them, and group them. If you have a lot of breakpoints, you can use the search to filter breakpoints by name or condition. You can also give them a label or edit their settings via the right-click context menu.

# 2. Watch window
The watch window is a tool that allows you to monitor the values of variables while debugging. You can add variables to the watch window by right-clicking on them in the code editor and selecting "Add Watch" or by typing them directly into the watch window.

Set a breakpoint on the start of the for loop (line 46) and start debugging. When the program stops at the breakpoint, you can see the values of the variables in the watch window. You can filter for both the value as well as the name or propetry of a variable using the search input.

You can pin values to the top of an object or array, using the pin at the end of the name column. For example, you could pin the `Name` and `IsCompleted` of any todo list item and all of them will then have "Name = "Coffee", IsCompleted = false" as value.

Addionally, you can edit the values directly in the watch window. This can be useful for testing different scenarios without having to change the code. For example, you can change the value of `i` in the watch window and see how it affects the program's behavior.

Lastly, a useful aspect of the watch window is that you can a breakpoint for a specific variable. This means that the program will stop when the value of that variable changes. To do this, right-click on the variable in the watch window and select "Break when value changes". This can be useful for tracking down bugs that are caused by unexpected changes in variable values. As an example, you can set a breakpoint for the `IsCompleted` propery of a sepcific item in the breakfast todo list, breaking the program when said item is marked as completed.

## 2.1. Quick watch
If you have a complex or very large object, it might be hard to view the value in the tooltip or watch window. You can use the "Quick Watch" feature to view the value of an object in a separate window. To do this, right-click on the object in the code editor and select "Quick Watch" or press Shift + F9. This will open a new window that displays the value of the object and its properties. You can also use this window to evaluate expressions and modify values.

# 3. Breakpoint types
## 3.1. Conditional breakpoints
Conditional breakpoints are breakpoints that only trigger when a certain condition is met. This can be useful for debugging specific scenarios without having to set multiple breakpoints. 

To set a conditional breakpoint, right-click on the breakpoint in the Breakpoints window or hover over the breakpoint in the margin and click "settings", and select "Conditions". In the dialog that appears, you can enter a condition that must be met for the breakpoint to trigger. For example, you can only trigger a breakpoint in the for loop when the current item has a ceterain name, such has "Toast". The condition would be `item.Name == "Toast"`.

You can also set a condition to only trigger the breakpoint when the breakpoint has bean hit a number of times.

If you're debbuging complex mutlithreaded applications, you can also use the filter to only trigger the breakpoint when the code is running on a thread with a specific thread id.

## 3.2. Dependent breakpoints
Dependent breakpoints are breakpoints that are only triggered if another breakpoint is hit first. This can be useful for debugging complex scenarios where you want to track the flow of execution through multiple methods or classes.

To set a dependent breakpoint, open the breakpoint settings menu and select "Only hit when the following breakpoint is hit" and select the dependent breakpoint from the list. For example you can set a breakpoint in `ToDoListItem.Complete()` that only get hit after your conditional breakpoint from above has been hit.

## 3.3. Tracepoints
Tracepoints are breakpoints that do not stop the execution of the program, but instead log a message to the output window. This allows you to log information to the debug output without putting `Debug.WriteLine()`'s in your code.

To set a tracepoint, select "Actions" in the breakpoint settings menu and check "Continue execution" and enter a message to log. You can use string interpolation to include variable values in the message. For example, you can log the name of the item that is being completed by entering `Completing {item.Name}` in the message box.

# 4. The call stack
To start exploring the call stack, set a breakpoint in `ToDoListItem.Complete()` and start debugging. 

When the program stops at the breakpoint, open the call stack window by going to Debug > Windows > Call Stack or by pressing Ctrl + Alt + C. Here you can view the full call stack leading up the the current code execution. You can click on the lines to see what calling locations are and explore the local variables via the watch window.

In case your code was called from an external libabry, you can enable "Show external code" to view those function calls. You will not be able to view the code at these locations unless you disable "Just my code", more on that later.

# 5. Changing application flow
While the debugger is paused, you can change where the code execution will continue. For example to enter the body of a conditional statement that the program state doesn't meet the requirement for. Or you can go back to a previous statement to run it again.

To change the application flow you have to drag de yellow arrow in the margin, this will set the next statement to be executed. You should be aware that the program state does not get changed, so your variables might not get set if you skip forward or some may be changed extra if you go back.

# 6. Immediate window
The Immediate window is a powerful tool that allows you to execute a abritrary statements while the debugger is paused within the current applcation state. Both allowing you to change the application state by changing variables and testing possible changes without changing the code.

## 6.1 Evaluating Expressions
When paused at a breakpoint (e.g., line 46 in the for loop), you can evaluate expressions, for example:
- `toDoList.Items.Count` to get the total amount of todo list items
- `toDoList.Items.Where(x => x.IsIsCompleted)` to display all the items are are completed.

## 6.2 Modifying Variables
To change the value of a variable, you simply use an assignment statement, for example `toDoList.Items[0].Name = "Updated Name"`. Or you can call the method of an object, for example `toDoList.Items[0].Complete()`.

# 7. DebuggerDisplay attribute
You can spcify how the value of an object should be formatted in the watch window by using the DebuggerDisplay attribute. For example if you add `[DebuggerDisplay("{Name}")]` above the `ToDoListItem` class, it will show the name as value instead of `{ToDoListItem}`

# References
- [Breakpoints](https://learn.microsoft.com/visualstudio/debugger/get-started-with-breakpoints)
- [Watch window](https://learn.microsoft.com/visualstudio/debugger/watch-and-quickwatch-windows)
- [Breakpoint types](https://learn.microsoft.com/visualstudio/debugger/using-breakpoints)
- [Call stack](https://learn.microsoft.com/visualstudio/debugger/how-to-use-the-call-stack-window)
- [Immediate window](https://learn.microsoft.com/visualstudio/ide/reference/immediate-window)
- [Changing application flow](https://learn.microsoft.com/visualstudio/debugger/move-the-execution-pointer-with-the-debugger)