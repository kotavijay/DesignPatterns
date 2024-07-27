﻿using AbstractFactoryPattern.AbstractFactory;

namespace AbstractFactoryPattern.ConcreteFactory;

public class PetAnimalFactory : IAnimalFactory
{
    public IDog GetDog()
    {
        return new PetDog();
    }

    public ITiger GetTiger()
    {
        return new PetTiger();
    }
}