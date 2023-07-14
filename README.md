
# .NET CORE Console Application

This project was developed as a coding test.\
The details and requirements can beviwed in this link:
https://www.mindmeister.com/app/map/2791288199?t=BstVaGMoba

Notes:
-
- The project was developed using the global namespace for simplicity. It could, and should, have separated namespaces for each section.
- There's no separation of business and interface logic because in this context those two are represented by "Writelines" and "Readlines" and the complexity of doing so wasn't worth it.
- Mocking in this context is complicated and there's not really much space to implement it in a meaningful way. Because we depend in user inputs to do all the work and control the flux I considered the method "Console.SetIn()" as a mock.