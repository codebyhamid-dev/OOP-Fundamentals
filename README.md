This project contains multiple classes and examples showing how OOP principles work in C#. Each OOP pillar is implemented in a separate section, and the code includes comments explaining the logic. By exploring this repository, you will learn:

How to protect and manage data with Encapsulation

How to create hierarchical relationships with Inheritance

How to simplify and generalize behavior using Abstraction

How to allow multiple forms and behaviors with Polymorphism

How to use Interfaces to enforce contracts for classes

OOP Concepts in this Repository
1. Encapsulation

The Person class demonstrates encapsulation by:

Using private fields for name and age

Providing public properties with validation logic (getter/setter)

Ensuring data integrity and controlled access

2. Inheritance

The Student class inherits from Person, demonstrating:

How child classes reuse parent class properties and methods

How child classes can override methods to provide specialized behavior (Introduce method)

3. Abstraction

Abstraction is demonstrated with the Employee class and its derived classes OnsiteEmployee and RemoteEmployee:

Employee is an abstract class with an abstract method EmployeeDetails

Derived classes implement this method, showing different behaviors for onsite and remote employees

4. Polymorphism

Polymorphism is demonstrated with the Shape class and its derived classes Circle, Triangle, and Rectangle:

Each class overrides the abstract method CalculateArea

Allows calling CalculateArea on a Shape object without knowing the exact type at compile time

5. Interfaces

The GraduateStudent class demonstrates the use of interfaces:

Combines multiple roles (student + athlete)

Implements methods from an interface to provide specific behavior
