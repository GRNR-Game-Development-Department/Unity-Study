using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TaeYun;

namespace TaeYun
{
    public class Homework2 : MonoBehaviour
    {
        private Rigidbody2D rigid;
        
        private double VelocityMS{
            get{return Mathf.Sqrt(rigid.velocity[0]*rigid.velocity[0]+rigid.velocity[1]*rigid.velocity[1]);}
        }
        private double VelocityKmS{
            get{return Mathf.Sqrt(rigid.velocity[0]*rigid.velocity[0]+rigid.velocity[1]*rigid.velocity[1])/1000f;}
        }
        private double VelocityKmH{
            get{return Mathf.Sqrt(rigid.velocity[0]*rigid.velocity[0]+rigid.velocity[1]*rigid.velocity[1])*3.6f;}
        }

        // Start is called before the first frame update
        void Start()
        {
            //this = new HW() 생략됨
            this.rigid= GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(this.VelocityMS + "m/s");
            Debug.Log(this.VelocityKmS + "km/s");
            Debug.Log(this.VelocityKmH + "km/h");
        }
    }
}