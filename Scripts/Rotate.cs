using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float RotationSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        RotateCube();
    }

    // Update is called once per frame
    void Update()
    {
        RotateCube();
    }

    public void RotateCube()
    {
        this.transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
    }
}
