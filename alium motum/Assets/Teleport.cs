using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public string teleport_key = "v";
    public Camera cam;
    public float range;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("mouse 1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range) == false)
        {
            player.position += cam.transform.forward * range;
        }
        else
        {
            player.position = hit.point;
        }

    }
}
