# CollectionGenerics
School assignment in list &amp; stack for handling data

# About the task:

This lab is about using two common generic types in C#. You will create a class and objects based on that class, and then manipulate them using Stack and List.

# What you need to do:

## Part 1 – Stack

- [ ] Create a class called `Employee`
    - [ ] This class should have several properties: Id, Name, Gender, Salary.

- [ ] Create a Stack of objects:
    - [ ] In the `Main()` method, create five objects of the class with different Id, Name, Gender, and Salary.
    - [ ] Then, create a `Stack` and add the five objects you created using `Push()`.
- [ ] Print all objects in the stack:
    - [ ] Print all objects in your Stack.
    - [ ] You can use a foreach loop to print all elements in the stack.
    - [ ] After each line or element, print how many objects are left in the stack.
- [ ] Retrieve all objects with the Pop method:
    - [ ] Retrieve all objects in the stack using the `POP()` method and print them.
    - [ ] After each line or element, print how many objects are left in the stack.
    - [ ] Add all objects back using the `Push()` method.
- [ ] Retrieve objects with the Peek method:
    - [ ] Retrieve two objects with the `Peek()` method.
    - [ ] After each line or element, print how many objects are left in the stack.
- [ ] Check if object number 3 exists in the stack or not and print the result.

## Part 2 – List

- [ ] Create a List
- [ ] Insert five objects of the `Employee` class into your list.
- [ ] Create a condition using the `Contains()` method to check if a specific object exists in the list. If it exists, print "Employee2 object exists in the list" to the console. Otherwise, print "Employee2 object does not exist in the list".
- [ ] Then, use the `Find()` method to find and print the first object in the list with `Gender = "Male"`.
- [ ] Next, use the `FindAll()` method to find and print all objects in the list with `Gender = "Male"`.
