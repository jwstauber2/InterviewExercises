Order Validation

A new requirement has come in when persisting data to OrderDemo. There is a UserDemo entity has an Id field which is the primary key/identifier of that entity.  OrderDemo.UserId is a foreign key to UserDemo.Id.  
We must validate that OrderDemo.UserId exists as a value in UserDemo.Id to ensure that there is a valid User associated to the Order.

Abstract away the data persistance, and write a test to make this new scenario pass.  Also, make a proposal on how to refactor the structure of the existing code
to make it easier to make changes to accomodate new requirements like this in the future with a lower risk of regressions.
