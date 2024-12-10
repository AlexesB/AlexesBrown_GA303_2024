using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveTargets : MonoBehaviour
{
    private NewWaveScript targetSpawner;

    [SerializeField]
    Transform[] wayPoints;
    int currentWayPoint = 0;
    Rigidbody rb;
    [SerializeField]
    float moveSpeed = 5;

    public GameObject target;

    private float countdown = 5f;

    public object Vector3_dir { get; private set; }


    // Start is called before the first frame update
    private void Start()
    {
        rb= GetComponent<Rigidbody>();

        targetSpawner = GetComponent<NewWaveScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (countdown <= 0)
        {
            Destroy(gameObject);
            targetSpawner.waves[targetSpawner.waveIndex].targetsLeft--;
        }
 
    }

    void Movement()
    {
        if(Vector3.Distance(transform.position,wayPoints[currentWayPoint].position) < .25f)
        {
            currentWayPoint++;
            currentWayPoint = currentWayPoint % wayPoints.Length;
        }
        Vector3 _dir = (wayPoints[currentWayPoint].position - transform.position).normalized;
        rb.MovePosition(transform.position + _dir * moveSpeed * Time.deltaTime);
    }
}
