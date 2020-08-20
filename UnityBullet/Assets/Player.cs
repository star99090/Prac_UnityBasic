using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 7f;
    float h;
    float v;
    public int hp;

    void FixedUpdate()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        
        transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime, Space.Self);
    }
}
