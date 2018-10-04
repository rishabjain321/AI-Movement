using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
	public Transform[] patrolPoints;
	public float moveSpeed;
	private int currentPoint;

    // Use this for initialization
    void Start()
    {
        transform.position = patrolPoints[0].position;
        currentPoint = 0;

    }


    // Update is called once per frame
    void Update ()
	{
        if (transform.position != patrolPoints[currentPoint].position)
        {

            Vector3 pos = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, moveSpeed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
            Debug.Log("Position Reached.");
        }
        else currentPoint = (currentPoint + 1) % patrolPoints.Length;
	}
}
