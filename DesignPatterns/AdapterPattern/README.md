# Adapter Pattern #

### Implementation - Travel agent senario ###

## Definitions ##

- The intent of this parttern is to **convert the interface of a class into another interface clients expected**. Adapter lets classes work together thaht couldnt otherwise because of incompatible interfaces. 

## Use Cases

- When you want to use an existing class but the interface does not match the one you need
- When you want to create a resuable class (the adapter) that works with classes that don't have compatible interfaces
- When you need to use several existing subclasses, don't want create additional subclasses for each of them, but still need to adapt their interface

> Examples:
> - Intergrating with a third-party library
> - Integrating with a web service
> - Mocking objects during testing
> - Integrating with logging or monitoring frameworks


## Pattern Consequences

- A single adapter can work with many adaptees, and can add functionality to all adaptees at once
- The interface (adapter code) is separated out from the rest of the code: `single responsibility princile`
- New types of adapters can be introduced without breaking client code:	`open/closed principle`
- The object adapter makes it hard to override adaptee behaviour


