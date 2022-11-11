using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject projectile;
    public float speed = 5f;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var spawn = Instantiate(projectile, SpawnPoint.position, SpawnPoint.rotation);
            spawn.GetComponent<Rigidbody>().velocity = SpawnPoint.forward * speed;
        }    
    }
}
