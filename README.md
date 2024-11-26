Order Validation

A new requirement has come in when persisting data to OrderDemo. There is a UserDemo entity has an Id field which is the primary key/identifier of that entity.  OrderDemo.UserId is a foreign key to UserDemo.Id.  
We must validate that OrderDemo.UserId exists as a value in UserDemo.Id to ensure that there is a valid User associated to the Order.  If OrderDemo.UserId does not point to a valid user, throw an exception.

Abstract away the data persistance, and write two twos: one which returns success when the UserId is valid, and a second that asserts a thrown ArgumentException when it is not.  

In addition, make a proposal on how to refactor the structure of the existing code to make it easier to make changes to accomodate new requirements like this in the future with a lower risk of regressions, and implement if time permits.
