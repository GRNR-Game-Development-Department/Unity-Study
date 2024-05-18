using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using UnityEngine;
using HyeongGeunHW;

namespace HyeongGeunHW { 
    public class Player : MonoBehaviour
    {
        protected List<Food> inventory = new List<Food>();        
        Factory factory = new Factory();
        public void AddFood(String s) {
            inventory.Add(factory.create(s));
        }
        public void AddFood(String s, int i) {
            Food food = factory.create(s, i);
            inventory.Add(food);
        }
        // Start is called before the first frame update
        void Start()
        {
            AddFood("apple", 2);
            AddFood("watermelon", 3);
            AddFood("apple tree");
            AddFood("strawberry", 5);
            AddFood("lemon tree");
        
            for(int i=inventory.Count - 1; i>=0; i--) {
                inventory[i].Eat();
                inventory.RemoveAt(i);
            }
        }

        // Update is called once per frame
        void Update()
        {
        }   
    }
}
