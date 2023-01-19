using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDie : MonoBehaviour
{
    public float dieTime = 0.7f;
    public GameObject DiePEffect;

    void Start()
    {
        StartCoroutine(Timer());
    }
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if (collisionGameObject.name != "Player")
        {
            Die();
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(dieTime);
        Die();
    }

    private void Die()
    {
        if (DiePEffect != null)
        {
            Instantiate(DiePEffect, transform.position, Quaternion.identity);

        }
        Destroy(gameObject);
    }
}