namespace AbstractFactoryPattern.AbstractFactory;

public interface IAnimalFactory
{
    IDog GetDog();
    ITiger GetTiger();
}
