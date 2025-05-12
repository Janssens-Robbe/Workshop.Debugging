# 1. Exception settings
Some exceptions, by default do not pause the debugger while you want them to, or they might do when don't want them to. This can be configured in the Exception settings window. You can open it by going to Debug > Windows > Exception Settings or by pressing Ctrl + Alt + E. In this window, you can enable or disable the exceptions that you want to break on. You can also set conditions for when to break on exceptions, such as only breaking on unhandled exceptions or only breaking on specific types of exceptions.

We have some custom exceptions for our deep fryer, make sure that de debugger pauses when the `DisallowedProductException` or `FryerToColdException`. Make sure you select "02 Exceptions" as the startup program and run the program to see if you can find when these exceptions get throw by picking some random options from the menu.

We have two places where an `ArgumentOutOfRangeException` gets thrown, however we don't care when our own code throws this exception. Configure the `ArgumentOutOfRangeException` so that it will only pause the debugger when the excption is thown from the `CommonLib` library. This can be configured using "edit condition" in the right-click context menu in the exception settings window. To confirm it is correctly set up, the debugger should pause when you pick "Freeze fried chicken" and not pause when you pick "Burt onions".

# 2. Stack explorer
Sometimes you can get very large calls stacks in your logs and it can get hard to naviage to where the error is located. To make this easier you can make use of the stack explorer. To get started, copy the stack trace from below and focus to a VS window. This should open the stack explorer, otherwise you can open it from View > Other Windows > Stack Trace Explorer or by using Ctrl + E, Ctrl + S.

The stack trace explorer allows you to naviage through the stack trace and view the code at each location. To do so, just click on one of the classes, methods, or filepaths once you've pasted the stack trace.

```
at CommonLib.TermpratureAsserter.CheckValidFryerTemprature(Decimal temperature) in D:\someplace\Workshop.Debugging\CommonLib\TermpratureAsserter.cs:line 9
at Workshop.Debugging.DeepFryer.DeepFryer.Heat(Decimal targetTemperature) in D:\someplace\Workshop.Debugging\02 Exceptions\DeepFryer.cs:line 10
at Workshop.Debugging.DeepFryer.Cook.Prepare(String food) in D:\someplace\Workshop.Debugging\02 Exceptions\Cook.cs:line 21
at Program.<Main>$(String[] args) in D:\someplace\Workshop.Debugging\02 Exceptions\Program.cs:line 20
```

# References
- [Inspecting exceptions](https://learn.microsoft.com/visualstudio/debugger/exception-helper)