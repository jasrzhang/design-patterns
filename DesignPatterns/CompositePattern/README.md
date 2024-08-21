# Composite Pattern
### Implement senario: file system (With files and directory)
> The Intent of this pattern is to compose objects into **tree structures** to represent part-whole herarchies. 
>
> As such, it lets clients treat individual objects and compositions of objects uniformly: as if they all were individual objects

### Examples:
- XML document structure
- Composing a drawing

## Use Cases
- When you want to represent part-whole hierarchies of objects
- When you want to be able to ignore the difference between compositions of objects and individual objects
> Examples
> - An investoment portfolio, *i.e Portfolio -> Asset Type -> individual investment*
> - Menu systems, *i.e sub menues, menu items*
> - An organization char *i.e. (leaf - employee, composition - departement)*
> - Representing a drawing in a drawing application, *i.e drawing structure, objects -> shape -> lines*


## Pros & Cons
#### Pros:
- Make the client simple
- It is easy to add new kinds of components: `open/closed principle`.

#### Cons:
- It can make the overall system too generic