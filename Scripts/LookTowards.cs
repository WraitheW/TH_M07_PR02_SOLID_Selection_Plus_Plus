using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTowards : MonoBehaviour
{
    public Transform target;

    public float speed = 100.0f;

    private void Start()
    {
        //I know this is coupling it
        //target = GameObject.Find("FPSController").GetComponent<Transform>();
    }
    void Update()
    {
        Vector3 targetDirection = target.position - transform.position;

        float singleStep = speed * Time.deltaTime;

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        Debug.DrawRay(transform.position, newDirection, Color.red);

        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
