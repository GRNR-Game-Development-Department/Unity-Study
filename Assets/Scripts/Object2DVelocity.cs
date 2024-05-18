using System.Collections;
using System.Collections.Generic;
using HyeongGeunHW;
using UnityEngine;

namespace HyeongGeunHW {

    class Velocity{
        private float currentVelocityInMps;
        private float currentVelocityInKps;
        private float currentVelocityInKph;

        public Velocity(Vector2 v) {
            currentVelocityInMps = v.magnitude;
            currentVelocityInKps = v.magnitude / 1000;
            currentVelocityInKph = v.magnitude / 1000 * 3600;
        }
        public float CurrentVelocityInMps {
            get { return currentVelocityInMps;  }
            set { currentVelocityInMps = value; }
        }
                public float CurrentVelocityInKps {
            get { return currentVelocityInKps;  }
            set { currentVelocityInKps = value / 1000; }
        }
                public float CurrentVelocityInKph {
            get { return currentVelocityInKph;  }
            set { currentVelocityInKph = value / 1000 * 3600; }
        }
    }
    
    public class Object2DVelocity : MonoBehaviour
    {
        private Rigidbody2D rigid2D;
        private Velocity vel;

    // Start is called before the first frame update
        void Start()
        {
            rigid2D = GetComponent<Rigidbody2D>();
            rigid2D.velocity = new Vector2(1,0);
            vel = new Velocity(rigid2D.velocity);            
        }

    // Update is called once per frame
        void Update()
        {
            rigid2D.AddForce(new Vector2(1,1));
            vel.CurrentVelocityInMps = rigid2D.velocity.magnitude;
            vel.CurrentVelocityInKps = rigid2D.velocity.magnitude;
            vel.CurrentVelocityInKph = rigid2D.velocity.magnitude;
            Debug.Log(vel.CurrentVelocityInMps+"m/s");
            Debug.Log(vel.CurrentVelocityInKps+"km/s");
            Debug.Log(vel.CurrentVelocityInKph+"km/h");
        }
    }
}
