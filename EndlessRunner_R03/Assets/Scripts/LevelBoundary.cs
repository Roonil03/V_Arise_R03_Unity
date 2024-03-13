using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -3.5f
    public static gloat rightSide = -3.5f
    public float internalRight;
    public float internalLeft;
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
