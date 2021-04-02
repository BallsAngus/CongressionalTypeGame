using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMotion : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, -1.7f * Time.deltaTime, 0f);
    }
}
