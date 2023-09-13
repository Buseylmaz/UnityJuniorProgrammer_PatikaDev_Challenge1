using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerControllerX : MonoBehaviour
{
    [SerializeField] private float propellerSpeed;

    
    /// <summary>
    /// Pervanenin d�nmesi
    /// </summary>
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * propellerSpeed);
    }
}
