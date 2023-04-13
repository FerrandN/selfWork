using ClassMetier;
using System;

// statement lambda
var s = (string a, string b) =>
{
    string r = a + b;
    return r;
};
// find the sum
Console.WriteLine(s("a","b"));

// method that returns square of a number
int Square(int num)
{
    return num * num;
}

// delegate that points the Square() method 
Func<int, int> square = Square;

// calling square() delegate 
Console.WriteLine(square(7));

//Function that use lambda expression to tell if a student is a teenager
Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;
Student std = new Student() { Age = 21 };
bool isTeen = isStudentTeenAger(std);