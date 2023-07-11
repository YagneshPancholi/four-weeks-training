using System;
using AnimalExercise;

public abstract class Animal
{
	public string? name;
	public int age;
	public abstract void makeSound();
}
public class Dog : Animal, Imovable
{
	public Dog(string name, int age)
	{
	this.name = name;
	this.age = age;
	}
	public override void makeSound()
	{
		Console.WriteLine("Woof Woof!!!!");
	}
	public  void move()
	{
		Console.WriteLine("Dog is moving!!!");
	}
}
public class Cat : Animal, Imovable
{
	public Cat(string name, int age)
	{
		this.name = name;
		this.age = age;
	}
	public override void makeSound()
	{
		Console.WriteLine("Meow Meow!!!!");
	}
	public void move()
	{
		Console.WriteLine("Cat is moving!!!");
	}
}
interface Imovable
{
	void move();
}