# Prototype Pattern #

- The intent of this pattern is to specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype
***
	var exisitingManager = new Manager("Cindy");
	var existingEmployee = new Employee("Kevin", existingManager);

	var newEmployee = new Employee();
	newEmployee.Name = existingEmployee.Name;
	newEmployee.Manager = existingEmployee.Manager;

# Use Case for the Prototype Pattern #
- When a system should be independent of how its objects are created, and to avoid building a set of factories that mimics the class hierachy
- When a system should be independent of how its objects are created, and when instances of a class can have one of only a few different combinations of states
- Document cloning in word processors
- Managing configuration instances
- Creating reusable UI components
- Creating characters in game development

## Pattern Consequnces ##
- Prototype hides the **ConcreteProduct** classes from the client, which reduces what the client needs to know
- Reduced subclassing
- Each implementation of the prototype base class must implement its own clone method