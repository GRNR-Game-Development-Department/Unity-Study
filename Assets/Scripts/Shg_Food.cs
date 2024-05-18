using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using UnityEngine;
using HyeongGeunHW;

namespace HyeongGeunHW { 
    public abstract class Food {
        public abstract void Eat();
        protected int count;
    }

    public class Apple : Food {
        override public void Eat() {
            for(int i = 0; i<count; i++) {
                Debug.Log("사과를 먹었습니다.");
            }
        }
        public Apple(int c) {
            count = c;
        }
    }
    public class Eggplant : Food {
        override public void Eat() {
            for(int i = 0; i<count; i++) {
                Debug.Log("가지를 먹었습니다.");
            }
        }
        public Eggplant(int c) {
            count = c;
        }
    }
    public class Carrot : Food {
        override public void Eat() {
            for(int i = 0; i<count; i++) {
                Debug.Log("당근을 먹었습니다.");
            }
        }
        public Carrot(int c) {
            count = c;
        }
    }
    public class Watermelon : Food {
        override public void Eat() {
            for(int i = 0; i<count; i++) {
                Debug.Log("수박을 먹었습니다.");
            }
        }
        public Watermelon(int c) {
            count = c;
        }
    }
    public class Koreanmelon : Food {
        override public void Eat() {
            for(int i = 0; i<count; i++) {
                Debug.Log("참외를 먹었습니다.");
            }
        }
        public Koreanmelon(int c) {
            count = c;
        }
    }
    public class Melon : Food {
        override public void Eat() {
            for(int i = 0; i<count; i++) {
                Debug.Log("멜론을 먹었습니다.");
            }
        }
        public Melon(int c) {
            count = c;
        }
    }
    public class Strawberry : Food {
        override public void Eat() {
            for(int i = 0; i<count; i++) {
                Debug.Log("딸기를 먹었습니다.");
            }
        }
        public Strawberry(int c) {
            count = c;
        }
    }
    
    public class Lemon : Food {
        override public void Eat() {
            for(int i = 0; i<count; i++) {
                Debug.Log("레몬을 먹었습니다.");
            }
        }
        public Lemon(int c) {
            count = c;
        }
    }
    public class Factory {
        public Food create(String food) {
            switch (food)
            {
                case "apple tree":
                    return new Apple(20);
                case "lemon tree":
                    return new Lemon(20);
                default:
                    return null;
            }
        }
        public Food create(String food, int count) {
            switch (food) 
            {
                case "apple": 
                    return new Apple(count);
                case "eggplant":
                    return new Eggplant(count);
                case "carrot":
                    return new Carrot(count);
                case "watermelon":
                    return new Watermelon(count);
                case "koreanmelon":
                    return new Koreanmelon(count);
                case "melon":
                    return new Melon(count);
                case "strawberry":
                    return new Strawberry(count);
                case "lemon":
                    return new Lemon(count);
                default:
                    return null;
            }
        }
    }
}
