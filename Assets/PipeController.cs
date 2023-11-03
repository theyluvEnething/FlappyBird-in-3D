using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    void Update()
    {
        transform.position = transform.position + new Vector3(0f, 0f, -0.015f);
    }
}
