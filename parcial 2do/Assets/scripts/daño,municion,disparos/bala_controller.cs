using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float xLimit = 140;
    public float menosXLimit = 60;
    public float zlimit = 160;
    public float menosZlimit = -88;
    virtual public void Update()
    {
        CheckLimits();
    }

      private void OnTriggerEnter(Collider other)
    
        
 
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }

    internal virtual void CheckLimits()
    {
        if (this.transform.position.x > xLimit)
        {
            Destroy(this.gameObject);
        }
        if (this.transform.position.x < -xLimit)
        {
            Destroy(this.gameObject);
        }
        if (this.transform.position.x < menosXLimit)
        {
            Destroy(this.gameObject);
        }
        
        if (this.transform.position.z > xLimit)
        {
            Destroy(this.gameObject);
        }
        if (this.transform.position.z < -xLimit)
        {
            Destroy(this.gameObject);
        }
        if (this.transform.position.z < menosZlimit)
        {
            Destroy(this.gameObject);
        }

    }
}
