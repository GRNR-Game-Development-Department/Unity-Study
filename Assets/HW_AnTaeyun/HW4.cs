using System.Collections.Generic;
using UnityEngine;

namespace TaeYun
{
    public class Player : MonoBehaviour{
        protected List<Food> inventory = new List<Food>();
        
        public void addInventory(string name){
            switch(name){
                case "apple":
                    inventory.Add(new Apple());
                    break;
                case "apple tree":
                    inventory.Add(new Apple(20));
                    break;
                case "eggplant":
                    inventory.Add(new Eggplant());
                    break;
                case "carrot":
                    inventory.Add(new Carrot());
                    break;
                case "watermelon":
                    inventory.Add(new Watermelon());
                    break;
                case "koreanMelon":
                    inventory.Add(new KoreanMelon());
                    break;
                case "melon":
                    inventory.Add(new Melon());
                    break;
                case "strawberry":
                    inventory.Add(new Strawberry());
                    break;
                default:
                    throw new System.NotImplementedException();
                
            }
        }
        public bool removeInventory(){
            if(inventory.Count > 0){
                inventory[0].Eat();
                inventory.RemoveAt(0);
                return true;
            }
            else{
                return false;
            }

        
        }

        void Start()
        {
            this.addInventory("apple");
            this.addInventory("carrot");
            this.addInventory("koreanMelon");
            this.addInventory("apple tree");
            while (true){
                if (this.removeInventory() == false){
                    break;
                }
            }

        }
        void Update()
        {
        
        }

    }
}