# Design Patterns
Design patterns are solutions to software design problems you find again and again in real-world application development. Patterns are about reusable designs and interactions of objects.

## Creational Patterns
* **Abstract Factory** -	Creates an instance of several **families of classes**
* **Builder**	- Separates object construction from its representation
* **Factory Method** - Creates an instance of several derived classes
* **Prototype** - A fully initialized instance to be copied or cloned
 * **ICloneable** - Using the built in ICloneable Interface
 * **Shallow Copy** - Will copy all non-static properties but it will not copy references to other objects
 * **Deep Copy** - Will copy all non-static properties and references to other objects
* **Singleton** - A class of which only a single instance can exist. Unlike Static classes, a Singleton can be passed around as paramater and can implement Interfaces
 *  **Non-Thread Safe** - Not recommended. Multiple Threads could be requesting GetInstance at the same time
 *  **Thread Safe** - Instance is set to **volatile** and a **lock** is used
 *  **Double-checked Locked** - Only **lock** if the instance is null
 *  **Lazy** - Using built in **Lazy** generic. Thread-safe and lazy loaded.
 *  **Nested Class** - Lazy loaded using nested class, and internal instance.

## Structural Patterns
* **Adapter**	- Match interfaces of different classes
* **Bridge**	- Separates an object’s interface from its implementation
* **Composite**	- A tree structure of simple and composite objects
* **Decorator**	- Add responsibilities to objects dynamically
* **Facade** - A single class that represents an entire subsystem
* **Flyweight** -	A fine-grained instance used for efficient sharing
* **Proxy**	- An object representing another object
 
## Behavioral Patterns
* **Chain of Responsibility** -	A way of passing a request between a chain of objects
* **Command**	- Encapsulate a command request as an object
* **Interpreter** -	A way to include language elements in a program
* **Iterator** - Sequentially access the elements of a collection
* **Mediator** - Defines simplified communication between classes
* **Memento**	- Capture and restore an object's internal state
* **Observer** - A way of notifying change to a number of classes
* **State** - Alter an object's behavior when its state changes
* **Strategy** - Encapsulates an algorithm inside a class
* **Template Method** -	Defer the exact steps of an algorithm to a subclass
* **Visitor**	- Defines a new operation to a class without change



