using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target; 
    [SerializeField] private Transform[] proectileSpawnPoint;
    [SerializeField] private GameObject projectilePrefab;
    public float EnemyRange = 40f;
    public float FireRate = 3f;
    private float distanceBetweenTarget;
    private NavMeshAgent navMeshAgent;
    private float countdownBetweenFire = 2f;
    public Animator enemyAnim;


    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        distanceBetweenTarget = Vector3.Distance(target.position, transform.position);

        if (distanceBetweenTarget <= EnemyRange)
        {
            navMeshAgent.SetDestination(target.position);
            enemyAnim.SetBool("playerDetected", true);
        } else {
            enemyAnim.SetBool("playerDetected", false);
        }

        if (distanceBetweenTarget <= navMeshAgent.stoppingDistance)
        {
            if (countdownBetweenFire <= 0f)
            {
                foreach (Transform SpawnPoints in proectileSpawnPoint)
                {
                    Instantiate(projectilePrefab, SpawnPoints.position, transform.rotation);
                }

                countdownBetweenFire = 2f / FireRate;
            }

            countdownBetweenFire -= Time.deltaTime;
        }
    }
}