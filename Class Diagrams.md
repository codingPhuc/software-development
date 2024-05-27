## Class Diagram

- Class diagrams are created with three compartments.
- Classes are named starting with an uppercase letter (UpperCamelCase), a common rule for good source code.

### Attributes and Methods

- Attributes start with a lowercase letter.
- Methods also start with a lowercase letter.

### Class Diagram Challenge

- The actor is the elevator.
- Name your class using UpperCamelCase.
- The robot must have a unique identifier.
- The robot can diagnose, service, and repair.
- Keep your class simple.

## Visibility

- `+public`: Can also be used by code outside of the object.
- `-private`: Can only be accessed within the defining class.
- `#protected`: Accessible from the defining and child classes.
- `~package`: Available within its enclosing package.

The rule is to expose as much as needed and hide everything else. This lets us control what the caller controls in our trip attribute. The trip name is never shorter than 3 characters, and the start date needs to be set.

To get the items, you need to provide getter and setter methods.

## Association

- The associated class does not know anything about its parent associate.
- Draw a line that represents the multiplicity of associated objects.
- A trip can have multiple expenses (`*`).
- A trip can have one home currency (`1`).
- A trip can have 0 to 1 (`0..1`) trips.

An association is a more general relationship that simply indicates that there is some form of a link between two classes, while a dependency is a more specific relationship that indicates one class relies on another to function.

## Generalization

- Generalization is when one model element is based on another model element.
- A parent can have multiple children.
- There are many programming languages that enable multiple inheritance.
- Indicate that a child element inherited its parent use cases, operations, and relationships.

## Dependency

- Association indicates that a class has an attribute of the other class type, whereas dependency is usually created when a class receives a reference from another class.

- **Dependency**, on the other hand, is a relationship where one class depends on another. If one class uses another class, then the former class is dependent on the latter class. The direction between them specifies which class depends on the other. It arises when one class uses another class in its method definition. The class being used is not passed as a parameter during runtime but is used directly in the method of a class.
## Aggregation

- Represents a part-whole relationship and is drawn as a solid line with a diamond at its owner end.
- Composite is ownership. When the owner object is destroyed, then the owned object will be removed too.

## Realization

- Realization indicates that a class implements the behavior specified by another model element.
- It is represented by a hollow triangle and a dashed line.
![[class_5_usedcases.PNG]]