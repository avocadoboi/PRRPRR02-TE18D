using System;

namespace SOLID_Labb {

class ConsoleUtilities {
    public static void PrintDivider() {
        Console.WriteLine("###############\n");
    }
}

class Program {
    // Inte mitt fel att det inte går att ge ett bra namn på det här kodstycket...
    static void OperateOnAnimal<T>(T animal) where T: IAnimal {
        // Skulle kunna ändras till:
        // if (animal is IOwnedAnimal owned_animal)
        // ifall Niklas äger alla djur som kan ägas.
        if (animal is Dog dog) {
            dog.Owner = "Niklas";
        }

        animal.Eat();
        animal.Sleep();
        animal.Speak();
        
        // Jag... ifrågasätter inte detta
        animal.Color = "Grey";

        Console.WriteLine($"{animal.GetType().Name} is {animal.Color}\n");

        ConsoleUtilities.PrintDivider();
    }

    static void Main(string[] args) {
        var animals = new IAnimal[] {
            new Dog("Black"),
            new Hedgehog("Pink"),
            new Bird("Yellow")
        };

        ConsoleUtilities.PrintDivider();

        foreach (var animal in animals) {
            OperateOnAnimal(animal);
        }
    }
}

} // namespace SOLID_Labb
