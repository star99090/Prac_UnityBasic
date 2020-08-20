using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    public GameObject bulletPrefab;
    float delay = 1f;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= delay)
        {
            //Instantiate(복제대상, 생성위치, 발사방향)
            var bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity).GetComponent<Bullet>();
            bullet.Fire(transform.forward);
            timer = 0f;
        }
    }
}
