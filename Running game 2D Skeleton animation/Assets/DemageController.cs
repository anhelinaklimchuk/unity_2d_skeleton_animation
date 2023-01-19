using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemageController : MonoBehaviour
{
    public GameObject runner;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Damage();
        }

    }
    void Damage()
    {
        runner.SetActive(false);
    }
}