using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float v0, angle, g;
    float vx, vy;

    void Start()
    {
        vx = v0 * Mathf.Cos(angle * Mathf.Deg2Rad);
        vy = v0 * Mathf.Sin(angle * Mathf.Deg2Rad);
    }

    void FixedUpdate()
    {
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        //x = ???;
        //vy = ???;
        //y = ???;
        this.transform.position = new Vector3(x, y, 0f);
    }

    void OnTriggerEnter()
    {
        //print(???);
    }
}
