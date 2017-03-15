<Query Kind="Program" />

void Main()
{
	var rex = new Dog("Rex", 3);
	rex.Name = "Max";
	rex.Bark();
}

// Define other methods and classes here
public void TestMethod(){

}

class Dog {
	public string Name;
	public int Age;
	
	public Dog(string name, int age){
		Name = name;
		Age = age;
	}
	
	public void Bark(){
		Console.WriteLine($"{Name} is barking");
	}
}

