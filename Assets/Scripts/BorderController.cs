using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderController : MonoBehaviour
{
    private bool changeDirection = false;
    private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "word")
        {
            changeDirection = !changeDirection;
        }
	}

    public bool getDirectionStatus()
    {
        return changeDirection;
    }
}
