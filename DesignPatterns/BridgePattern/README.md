# Bridge Pattern
## Implementation 
### Restaurant cash register

The intent of this pattern is to decouple an abstraction from its implementation so the two can very independently

> Separate abstraction from implementation
>
> - means to replace an ***implementation with another implementation*** without modifying the abstraction
> - Think of an ***abstraction*** as ***a way to simplify something complex***
> - Abstractions handle complexity by hiding the parts we don't need to know about


## Use Cases
- When you want to avoid a permanent biding between an abstraction and its implementation (to enable switching implementations at runtime)
- When abstraction and implementations should be extensible by subclassing
- When you don't want changes in the implementation of an abstraction have an impact on the client

### Examples
> - Separating notification mechanisms in a notification system
- Separating streaming protocols in audio/video streaming
- Separating UI components from rendering code
- Separating functionalities from a specific device in universal remote-control application

## Pattern Consequnces
- Decoupling: the implementation isn't permanently bound to the abstraction
- As the abstraction and implementation hierachies can evolve independently, new ones can be introduces as such: `open/closed principle`
- you can hide implementation details away from clients
- you can focus on high-level in the abstraction, and on the details in the implementation: `single responsibility principle`
