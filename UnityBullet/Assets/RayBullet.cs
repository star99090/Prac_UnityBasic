using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayBullet : MonoBehaviour
{
    bool isFire;
    Vector3 direction;
    public float speed = 20f;

    public void Fire(Vector3 dir)
    {
        direction = dir;
        isFire = true;
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
