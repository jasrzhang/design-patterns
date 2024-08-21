**Factory Pattern**

> is a Creational Pattern 
>
> - Facotry Method
>
> - Abstract Factory


### Use Cases for the Factory Method Pattern ###
- When a class can't anticipate the class of objects it must create - when you don't know in advance which types of objects your code should work with
- When a class wants its subclasses to specify the objects it creates
- When classes delegate responsibility to one of server helper subcleasse, and you want to localize the knowledge of which helper subclass is the delgate
- As a way to enable resuing of existing objects

### Pattern Consequnces ###

- Factory methods eliminate the need to bind application-specific classes to your code
- New types of products can be added without breaking client code: open/closed principle
- Creating products is moved to one specific place in your code, the creator: single responsibility principle