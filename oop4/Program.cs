/*Then explain the difference between using override and new(using binding behavior)
 override: polymorphic, depends on runtime type but new: hides base method, depends on reference type
*/

using oop4;

BaseClass b1 = new DerivedClass1();
b1.DisplayMessage(); 

BaseClass b2 = new DerivedClass2();
b2.DisplayMessage(); 

DerivedClass2 d2 = new DerivedClass2();
d2.DisplayMessage();

Duration D1 = new Duration(1, 10, 15);
Duration D2 = new Duration(7800);
Duration D3 = new Duration(666);

Console.WriteLine(D1);
Console.WriteLine(D2); 
Console.WriteLine(D3); 

D3 = D1 + D2;
D3 = D1 + 7800;
D3 = 666 + D3;
D3 = ++D1;
D3 = --D2;
D1 = D1 - D2;

if (D1 > D2) Console.WriteLine("D1 is greater");
if (D1 <= D2) Console.WriteLine("D1 is less than or equal");

DateTime time = (DateTime)D1;
Console.WriteLine("Converted to DateTime: " + time.ToLongTimeString());
