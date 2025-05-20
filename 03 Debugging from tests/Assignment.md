# Starting the debugger from a test project
Often, some problem only accours when data is in a spesific state that can be time consuming to replicate over and over again while debugging. This can be overcome by using unit tests to set up the state of the application and then start debugging from there.

To get started, make sure to build the project and open the test explorer by going to Test > Windows > Test Explorer or by pressing Ctrl + E, Ctrl + T. In the test explorer, you can see all the tests in the project and their results. To start debugging, set a breakpoint in the `RandomTest.VeryExampleBadTest()` method and start debugging by clicking the "Debug All Tests" button in the test explorer, or select the specific test, or test group, and right-click to select "Debug". The test should be run and your breakpoint should hit.

# References
- [Debugging with the test explorer](https://learn.microsoft.com/visualstudio/test/debug-unit-tests-with-test-explorer)