using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMainScript: MonoBehaviour
{
    public float moveSpeed = 3;
    public float LRSpeed = 2.4f;
    public int health = 3;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {
            if(this.gameObject.transform.position.x > LevelBoundary.LeftSide)
            {
            transform.Translate(Vector3.left * Time.deltaTime * LRSpeed);
            }
        }
        
        if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            if(this.gameObject.transform.position.x < LevelBoundary.RightSide)
            {
            transform.Translate(Vector3.left * Time.deltaTime * LRSpeed * -1);
            }
        }
    }
}
