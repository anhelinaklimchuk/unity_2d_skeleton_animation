using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScript : MonoBehaviour
{
    public GameObject start;
    public GameObject runner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D item)
    {
        if (item.gameObject.CompareTag("Player"))
        {
            runner.transform.position= start.transform.position;
        }
    }
}
