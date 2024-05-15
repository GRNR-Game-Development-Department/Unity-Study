using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KimYoungBin : MonoBehaviour
{
    static void Main()
    {
        Player player=new Player();

        player.AddFood("Apple");
        player.AddFood("Melon");
        player.ShowFood();
    }
    
}

public class Player : MonoBehaviour
{
    protected List<Food> Inventory = new List<Food>();
    
    public void AddFood(string foodName)
    {
        Food food = FoodFactory.AddFood(foodName);
        Inventory.Add(food);
    }

    public void ShowFood()
    {
        foreach (Food food in Inventory)
        {
            Console.WriteLine(food.foodName);
        }
        
    }
    
}

public static class FoodFactory
{
    public static Food AddFood(string foodName)
    {
        switch (foodName)
        {
            case "Apple":
                return new Apple(1);
            case "Carrot":
                return new Carrot(1);
            case "Melon":
                return new Melon(1);
            default:
                return null;
        }
    }
}

public abstract class Food
{
    protected int _count;
    protected string _foodName;
    public void Eat()
    {
        for(int i=0; i < _count; i++)
        {
            Debug.Log(this._foodName + "(을)를 먹었습니다.\n");
        }
        this._count = 0;
    }

    //생성자
    public Food(): this(1) { }
    public Food(int count) { this._count = count; }
    public void SetFood(string foodName)
    {
        this._foodName = foodName;
    }
    public string foodName
    {
        get { return this._foodName; }
    }
}

public class Apple : Food
{
    public Apple(int count)
    {
        _count = count;
        SetFood("사과");
    }
}

public class Carrot : Food
{
    public Carrot(int count)
    {
        _count = count;
        SetFood("당근");
    }
}

public class Melon: Food
{
    public Melon(int count)
    {
        _count = count;
        SetFood("멜론");
    }
}
