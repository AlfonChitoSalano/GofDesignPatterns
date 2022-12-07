# Gang of Four Design Patterns in C#
Coding some of the design patterns using C# 11.0. The intention of this is to code some of the common design patterns using the updated C# version

## Creational
### Singleton 
The intent of this is to create a single instance of the object throughout the application.

### Factory 
The intent of this is to create the interface, letting you create subclasses or polymorphism without exposing interface internal creation.

### Abstract 
The intent of this is just like a factory but with the grouping of the related factories into one factory object.

### Builder 
The intent of this is to separate the construction of a complex object from its representation and you will need a director that generates the final product.

## Structural
### Adapter 
The intent of this is to convert the interface that clients expect that couldn't be because of incompatible interfaces.

## Behavioral
### Observer 
The intent of this is to provide loose coupling between a notifier to listeners. If the notifier changes its state then all listeners are notified. Some called this pub/sub.

### Command
The intent of this is to encapsulate the request into a separate object so that you can support queuing and undo operations.

### Chain of Responsibility
The intent of this is to pass the request to the next chain (successor) efficiently, before it passes to the successor the request is processed to some validations or rules and then decides whether it goes to the successor or not.

### Mediator
The intent of this is to encapsulate the object "mediator" that defines how the participants interact by forcing them to communicate via a mediator.

### Iterator
The intent of this is to provide a way to iterate the elements of the list of objects without exposing its representations.
