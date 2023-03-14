using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target; // Referencia al personaje
    public Vector3 offset; // Desplazamiento de la cámara respecto al personaje
    public float rotateSpeed = 3f; // Velocidad de rotación de la cámara

    void FixedUpdate()
    {
        transform.position = target.position + offset;
        transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, rotateSpeed * Time.deltaTime);
    }
}
