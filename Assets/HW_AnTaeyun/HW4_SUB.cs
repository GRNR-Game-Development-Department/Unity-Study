using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace TaeYun
{
    public abstract class Food{
        protected int count;
        protected string foodName;
        
        public void Eat(){
            for(int i=0;i<this.count;i++)
                Debug.Log(this.foodName+"(을)를 먹었습니다");
            this.count = 0;
        }
        
        //생성자
        public Food() : this(1){}
        public Food(int count){
            SetCount(count);
        }
        public void SetFood(string foodName){
            this.foodName = foodName;
        }
        public void SetCount(int count){
            this.count = count;
        }
    }
    public class Apple : Food{
        public Apple() : this(1){}
        public Apple(int count) : base(count){
            SetFood("사과");
        }
        
    }
    public class Eggplant : Food{
        public Eggplant() : this(1){}
        public Eggplant(int count) : base(count){
            SetFood("가지");
        }
    }
    public class Carrot : Food{
        public Carrot() : this(1){}
        public Carrot(int count) : base(count){
            SetFood("당근");
        }
    }
    public class Watermelon : Food{
        public Watermelon() : this(1){}
        public Watermelon(int count) : base(count){
            SetFood("수박");
        }
    }
    public class KoreanMelon : Food{
        public KoreanMelon() : this(1){}
        public KoreanMelon(int count) : base(count){
            SetFood("참외");
        }
    }
    public class Melon : Food{
        public Melon() : this(1){}
        public Melon(int count) : base(count){
            SetFood("멜론");
        }
    }
    public class Strawberry : Food{
        public Strawberry() : this(1){}
        public Strawberry(int count) : base(count){
            SetFood("딸기");
        }
    }
}