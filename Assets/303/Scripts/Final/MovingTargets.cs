using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTargets : MonoBehaviour
{
    public GameObject obj;
    public GameObject[] pathing;
    public int numberOfPathPoints;
    public float speed;

    private Vector3 actualPosition;
    private int x;



    // Start is called before the first frame update
    void Start()
    {
        x = 1;
    }

    // Update is called once per frame
    void Update()
    {
        actualPosition = obj.transform.position;
        obj.transform.position = Vector3.MoveTowards(actualPosition, pathing[x].transform.position, speed * Time.deltaTime);

        if(actualPosition == pathing[x].transform.position && x != numberOfPathPoints - 1)
        {
            x++;

        }

    }
}
