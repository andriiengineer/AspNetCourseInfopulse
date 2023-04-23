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

**HW 5**
+ CREATE MVC Project
+ Create a new Controller named “Friend”.
+ Create a Model named “Friend” with following properties : FriendID,FriendName,Place
+ Create a Index (List of Friends) View and Method in Friend controller.
+ Update your model Friend for validation.
+ Make it FriendID as Required attribute.
+ Make it FriendName as Error Message = Friend Name Empty Not Allowed.
+ Make it Place entry resticted to Maximum Character = 25
+ Create a Insert new friend --> View and Method in Friend controller.
+ Insert new record with using Model in post.
+ Before Inserting check your Model means validate your model.
+ Insert new record with using Model in post.
+ Before Inserting check your Model means validate your model.
+ Create edit/Update View and Method in Controller.
Update record with using FormCollection technique.
Create Delete view and Method for delete a friend in post method of Controller.