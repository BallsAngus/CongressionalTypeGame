using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    int diff = 2;

    public void easyDiff()
    {
        diff = 1;
    }

    public void normalDiff()
    {
        diff = 2;
    }

    public void hardDiff()
    {
        diff = 3;
    }

    public int getDiff()
    {
        return diff;
    }
}
