using System;

interface Bird
{
    void fly();
    void makeSound();
}

class Sparrow : Bird
{
    public void fly()
    {
        Console.WriteLine("Flying");
    }
    public void makeSound()
    {
        Console.WriteLine("Chirp Chirp");
    }
}

interface ToyDuck
{
    void squeak();
}

class PlasticToyDuck : ToyDuck
{
    public void squeak()
    {
        Console.WriteLine("Squeak");
    }
}

class BirdAdapter : ToyDuck
{
    Bird bird;
    public BirdAdapter(Bird bird)
    {
        this.bird = bird;
    }

    public void squeak()
    {
        bird.makeSound();
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Sparrow sparrow = new Sparrow();
        ToyDuck toyDuck = new PlasticToyDuck();

        ToyDuck birdAdapter = new BirdAdapter(sparrow);

        Console.WriteLine("Sparrow...");
        sparrow.fly();
        sparrow.makeSound();

        Console.WriteLine("ToyDuck...");
        toyDuck.squeak();

        Console.WriteLine("BirdAdapter...");
        birdAdapter.squeak();
    }
}
