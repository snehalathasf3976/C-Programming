using System;
namespace RunTimePolymorphisom;
class Program
{
    public static void Main(string[] args)
    {
        Total total = new Total();
        Student student;
        student = total ; //Pass the Child class object (total class object) to Parent Class (Student Class)

        student.Name = "Sneha";
        student.Display(); //Call the Child Class Object cuz Child object is pass as Reference

        Sports sports = new Sports();
        student=sports;
        student.Name = "Priya";
        student.Display();
        
        
    }
}