using System;

namespace SOLID_Labb {

struct Bird : IAnimal {
	public string Color { get; set; }

    public Bird(string color) => Color = color;

    public void Eat() {
        Console.WriteLine("Bird is peck-peck-pecking away!");
    }
    public void Sleep() {
        Console.WriteLine("Bird is sleeping!");
    }
    public void Speak() {
        Console.WriteLine("Bird is chirping!");
    }
}

class Dog : IOwnedAnimal {
	public string Color { get; set; }
	
	public string Owner { get; set; }

	public Dog(string color) => Color = color;

	public void Eat() {
		if (Owner == null) {
			Console.WriteLine("Dog is eating. There is no owner to be happy for him :(");
		}
		else {
			Console.WriteLine($"Dog is eating. {Owner} is happy!");
		}
	}
	public void Sleep() {
		Console.WriteLine("Dog is sleeping!");
	}
	public void Speak() {
		Console.WriteLine("Dog is barking!");
	}
}

class Hedgehog : IAnimal {
	public string Color { get; set; }
	
	public Hedgehog(string color) => Color = color;

	public void Eat() {
		Console.WriteLine("Hedgehog is omnomnoming!");
	}
	public void Sleep() {
		Console.WriteLine("Hedgehog is napping!");
	}
	public void Speak() {
		Console.WriteLine("Hedgehog is squeeking!");
	}
}

}; // namespace SOLID_Labb