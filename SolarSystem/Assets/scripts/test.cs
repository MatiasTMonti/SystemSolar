using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Transform pivotObj;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivotObj.transform.position, new Vector3(0, 0, 1), rotationSpeed * Time.deltaTime);
    }
}
