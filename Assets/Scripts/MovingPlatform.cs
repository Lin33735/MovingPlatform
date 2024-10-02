using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector3 startPosition = new Vector3(0, 0, 0);
    private Vector3 endPosition = new Vector3(0, 0, 5);
    public float speed = 3f;
    private bool forward = true;

    public GameObject Player;

    private void Start()
    {
        startPosition = transform.position; 
        endPosition = new Vector3(startPosition.x, startPosition.y, startPosition.z + 5);
    }
    private void Update()
    {
        if (transform.position.z >= endPosition.z)
        {
            forward = false;
        }
        else if (transform.position.z <= startPosition.z)
        {
            forward = true;
        }

       
        float movement = speed * Time.deltaTime;
        if (forward)
        {
            transform.position += new Vector3(0, 0, movement);
        }
        else
        {
            transform.position -= new Vector3(0, 0, movement);
        }
    }

    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }
    
}
