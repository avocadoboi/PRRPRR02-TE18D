
namespace SOLID_Labb {

public interface IAnimal {
	string Color { get; set; }
	
	void Eat();
	void Sleep();
	void Speak();
}

public interface IOwnedAnimal : IAnimal {
	string Owner { get; set; }
}

} // namespace SOLID_Labb
