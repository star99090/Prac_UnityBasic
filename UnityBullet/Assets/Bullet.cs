using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
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

    void Update()
    {
        if (isFire)
        {
            transform.Translate(direction * Time.deltaTime * speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        var target = collision.collider.GetComponent<Player>();
        if (target != null)
        {
            target.hp -= 1;
        }
        Destroy(gameObject);
    }
}
