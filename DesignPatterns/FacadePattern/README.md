# Facade
The intent of this pattern is to provide a unified interface to a set of interfaces in a subsystem.
It defines a higher-level interface that makes the subsystems easier to use. 

## Use Cases
- When you want to provide a simple interface into a complex subsystem
- When there are many dependencies between a client and the implementation classes of the abstraction

### Examples:
- Integrating with legacy systems
- Content management systems, i.e. unified interface for add, update, delete, etc
- Multimedia playback, unified interface including play, pause, quite for various kinds of media types
- Payment processing

### Pros & Cons
#### Pros:
> - The number of objects clients have to deal with are reduced
> - It promotes weak coupling between the subsystem and its clients, enabling subsystem components to vary witouth affecting the client, `open/close principle`
> - Clinets are not forbidden to use subsystem classes