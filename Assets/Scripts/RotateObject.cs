using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Vector3 moveDirection;

    Vector3 startingLocation;   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.Rotate(moveDirection * moveSpeed);
    }


}
