using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRotation : MonoBehaviour
{
    public GameObject orb;
    public float radius;

    public PauseMenu paused;

    private Transform pivot;

    public float minAngle;
    public float maxAngle;

    void Start()
    {
        pivot = orb.transform;
        transform.parent = pivot;
        transform.position += Vector3.up * radius;
    }

    void Update()
    {
        if (!paused.isPaused)
        {
            LookMouse();
        }
    }

    void LookMouse()
    {
        Vector3 orbVector = Camera.main.WorldToScreenPoint(orb.GetComponent<Transform>().position);
        orbVector = Input.mousePosition - orbVector;
        float angle = Mathf.Atan2(orbVector.y, orbVector.x) * Mathf.Rad2Deg;
        
        if (angle < minAngle)
        {
            this.transform.rotation = Quaternion.AngleAxis(-75, Vector3.forward);
        }
        else if (angle > maxAngle)
        {
            this.transform.rotation = Quaternion.AngleAxis(75, Vector3.forward);
        }
        else this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
