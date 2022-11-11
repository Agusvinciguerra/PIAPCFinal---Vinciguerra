using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    public GameObject uno;
    public GameObject dos;
    public GameObject tres;
    public GameObject cuatro;
    public GameObject bossito;
    bool uActive;
    bool dActive;
    bool tActive;
    bool cActive;

    void Start()
    {
        
    }
    void Update()
    {
        if (uno.activeInHierarchy)
        {
            uActive = false;
            Debug.Log("Active");
        } else {
            uActive = true;
            Debug.Log("chau");
        }

        if (dos.activeInHierarchy)
        {
            dActive = false;
            Debug.Log("dos");
        } else {
            dActive = true;
            Debug.Log("a mimir");
        }
        
        if (tres.activeInHierarchy)
        {
            tActive = false;
        } else {
            tActive = true;
        }

        if (cuatro.activeInHierarchy)
        {
            cActive = false;
        } else {
            cActive = true;
        }

        if (uActive && dActive && tActive && cActive)
        {
            bossito.SetActive(true);
        }
    }
}
