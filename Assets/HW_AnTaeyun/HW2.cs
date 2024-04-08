using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TaeYun;

namespace TaeYun
{

    class Entity {
        private Rigidbody2D _rigid;
        public double VelocityMS{
            get{return Mathf.Sqrt(_rigid.velocity[0]*_rigid.velocity[0]+_rigid.velocity[1]*_rigid.velocity[1]);}
        }
        public double VelocityKmS{
            get{return Mathf.Sqrt(_rigid.velocity[0]*_rigid.velocity[0]+_rigid.velocity[1]*_rigid.velocity[1])/1000f;}
        }
        public double VelocityKmh{
            get{return Mathf.Sqrt(_rigid.velocity[0]*_rigid.velocity[0]+_rigid.velocity[1]*_rigid.velocity[1])*3.6f;}
        }


        public Entity(Rigidbody2D objectRb){
            _rigid = objectRb;
        }
    }
    public class HW2 : MonoBehaviour
    {
        private Entity _temp;
        // Start is called before the first frame update
        void Start()
        {
            _temp = new Entity(GetComponent<Rigidbody2D>());
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(_temp.VelocityMS + "m/s");
            Debug.Log(_temp.VelocityKmS + "km/s");
            Debug.Log(_temp.VelocityKmh + "km/h");
        }
    }
}