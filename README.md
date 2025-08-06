Assignment 04 OOP
Part01
Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:
Accept two integers and return their sum.
Accept three integers and return their sum.
Accept two doubles and return their sum.

Q2) Create a class named Rectangle with the following constructors:
A parameterless constructor that sets the width and height to 0.
A constructor that accepts width and height as integers.
A constructor that accepts a single integer and sets both width and height to that value.



Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
     *Note: Overload the +, - operator to add and subtract two complex numbers.	


Question 4)   
a) Create a base class named Employee with method That Work as it prints    "Employee is  working".

b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
    *Ensure that the Manager class also calls the Work method of the Employee class within its  Overridden method   .






Question 5)  
a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass".

b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.

C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.

 Then explain the difference between using override and new (using binding behavior)	



Part02
1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

2-Override All System. Object Members [To String(), Equals(),GetHashCode() ] .


3-Define All Required Constructors to Produce this output:
Duration D1 =new Duration (1,10,15);
D1.ToString(); 
Output: Hours: 1, Minutes :10, Seconds :15

Duration D1 =new Duration (3600);
D1.ToString(); 
Output: Hours: 1, Minutes :0, Seconds :0

Duration D2 =new Duration (7800);
D2.ToString(); 
Output: Hours: 2, Minutes :10, Seconds :0

Duration D3 =new Duration (666);
D3.ToString(); 
Output: Minutes :11, Seconds :6




4-Implement All required Operators overloading to enable this Code:
D3=D1+D2
D3=D1 + 7800
D3=666+D3
D3= ++D1 (Increase One Minute)
D3 = --D2 (Decrease One Minute)
D1= D1 -D2
If (D1>D2)
If (D1<=D2)
If (D1)
DateTime Obj = (DateTime) D1
