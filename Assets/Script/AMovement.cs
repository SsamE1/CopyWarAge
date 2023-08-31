using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMovement : MonoBehaviour
{
   private float moveSpeed = 2.0f;
   Vector2 diretction=Vector2.right;
    // Update is called once per frame
    void Update()
    {
        Vector2 movement= diretction * moveSpeed *Time.deltaTime;
        transform.position = new Vector3(transform.position.x + movement.x, transform.position.y + movement.y, transform.position.z);
    }
}
