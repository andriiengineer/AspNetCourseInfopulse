**HW 1**
+ Create Asp.net Web API application. 
+ Add new controller Cars
+ Add method get that should return a list of cars
+ P.S. Model cars you can describe as you wish, but it should contain at least 4 properties

**HW 2**
+ Create interface IManagementCars with methods GetCarName(), GetCarEngine(), GetCarAge()
+ Implement interface
+ Register interface in DI
+ create routes for every method (use app.Map)
+ Create middlewares for each route and print information

**HW 3**
+ Create delegate printString and use it  to reference method that takes a string as input and returns nothing.
+ We will use this delegate to call two methods, the first prints the string to the console with green color, and the second one prints it to the console with orange color.
+ Use property Console.ForegroundColor for setup color text.

**HW 4**
+ Create application with Razor pages.
+ Make a page 'About me' and describe yourself in several sentences. (Update index page)
+ Add a page 'My hobbies' and get information from the model. It should be List<Hobby>.
+ Describe model Hobby as you want. Add button on header on start page.