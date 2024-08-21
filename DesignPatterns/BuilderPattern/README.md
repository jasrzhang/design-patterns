# Builder Pattern #

- is a Creational Pattern
- The intent of the builder pattern is to separate the construction of a complex object from its representation. 
- By doing so, the same construction process can create different presentations. 

## Use Cases ##
- When you want to make the algorithm for creating a complex object independnt of the parts that make up the object and how they are assembled
- When you want to construction process to allow different representations for the object that is constructed

### Example ###
- Generating documents
- Building a database query
- Creating a game character
- Constructing a UI or form

### Pattern Consequences ###
- It lets us vary a products' internal representation
- It isolates codes for construction and representation; it thus improves modularity by encapsualating the way a complex object is constructed and represented: `single reponsibility principle `
- It gives us finer control over the construction process
- **COMPLEXITY** of code base **INCREASES**