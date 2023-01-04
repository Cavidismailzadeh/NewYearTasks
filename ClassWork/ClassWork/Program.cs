


//Salmon salmon1=new Salmon();

//using ClassWork.Models;

////Eagle eagle1 = new Eagle();
////Animal animal1 = eagle1;
//animal1.Sound();
//Animal animal2 = salmon1;
using ClassWork.Models;

//Bird bird = new Bird();
////Animal animal3 = new Salmon();


//salmon1.Sound();
//eagle1.Sound();

//Animal animal1 = new Animal();
//animal1.Sound();

//Bird bird1 = new Bird();
//bird1.Sound();


//Bird bird = new Bird();

//Fish fish = new Fish();

//Eagle eagle1 = new Eagle();
//Animal animal1 = new Eagle();
//Fish fish1 = new Fish();
//Animal animal2 = fish1;
//Bird bird1 = new Bird();
//Eagle eagle3 = (Eagle)animal2;


//Animal[] animals = { eagle1, animal1, fish1, animal2, bird1 };

//Animal[] animals = { eagle1, animal1, fish1, animal2, bird1, eagle3 };

//foreach (var item in animals)
//{
//    item.Name = "xxx";
//    Console.WriteLine(item.Name);

//}


int num = 5;
object obj1 = num;
string name = obj1.ToString();


//int num1 = 55;
//object obj1 = num1;
//int num2 = (int)obj1;

//Console.WriteLine(num);
//string str = "55";

//object obj1 = str;

//int num2 = (int)obj1;

//var result = int.Parse(str);

//Console.WriteLine(result); 


//int num1 = 120;
//byte num2 = (byte)num1;
//Console.WriteLine(num2);


//Bird bird = new Bird();
//Fish fish = new Fish();
//Animal animal1 = new Bird();
//Animal animal2 = new Fish();

//object[] objects = { bird, fish, animal1, animal2 };

//foreach (var item in objects)
//{
//    ((Animal)item).Name = "test";
//    Console.WriteLine(((Animal)item).Name);
//}



Bird bird = new Bird();
Fish fish = new Fish();
Animal animal1 = new Bird();
Animal animal2 = new Fish();

object[] objects = { 1, 5, bird, fish, "salam", animal1, animal2, "sagol" };

foreach (var item in objects)
{
    if (item is Animal)
    {
        ((Animal)item).Name = "test";
        Console.WriteLine(((Animal)item).Name);
    }
    else
    {
        Console.WriteLine(item);
    }


}




