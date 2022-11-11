using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Animator enemyAnim;
    public float timer = 0.5f;
    private int hitTimes = 0;
    public GameObject win;
    
    void Update()
    {
        if (hitTimes == 10)
        {
            //gameObject.SetActive(false);
            Destroy(gameObject);
            //win.SetActive(true);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            GetHit();
            hitTimes = hitTimes + 1;
            //Debug.Log("hit " + hitTimes);
        }
    }
    void GetHit()
    {
        //gameObject.SetActive(false);
        enemyAnim.SetBool("shotTaken", true);
        StartCoroutine(shotFade());
    }

    IEnumerator shotFade()
    {
        yield return new WaitForSeconds(1);
        enemyAnim.SetBool("shotTaken", false);
    }

}
