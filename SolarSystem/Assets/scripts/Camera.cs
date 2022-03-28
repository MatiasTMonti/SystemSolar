using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform camera;
    [SerializeField] private Transform ship;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.position = new Vector3(ship.position.x, ship.position.y + 0.1f, ship.position.z - 0.5f);
        //camera.rotation = ship.rotation.x;
    }
}
