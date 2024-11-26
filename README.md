Clone project. Have .NET 9 installed and an IDE set up to do .NET development to work through any of these exercises.

Order Validation Exercise

A new requirement has come in when persisting data to OrderDemo. There is a UserDemo entity has an Id field which is the primary key/identifier of that entity.  OrderDemo.UserId is a foreign key to UserDemo.Id.  We must validate that OrderDemo.UserId exists as a value in UserDemo.Id to ensure that there is a valid User associated to the Order.  If OrderDemo.UserId does not point to a valid user, throw an exception.

Abstract away the data persistance, and write two unit tests: one which returns success when the UserId is valid, and a second that asserts a thrown ArgumentException when it is not.  

Make note of challenges in the existing structure of the code when implementing these tests, and, make a proposal on how to refactor it, with a goal of making it easier to implement new requirements like this in the future with a lower risk of regressions.  Implement if time permits.
