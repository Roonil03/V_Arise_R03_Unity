using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool JumpKeyPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;
    [SerializeField] private  Transform groundCheck = null;
    [SerializeField] private LayerMask playerMask;
    public int score = 0;
    [SerializeField] private int speedCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true) //check if space key is checked out
        {
            //Debug.Log("Space key was pressed");
            JumpKeyPressed = true;
        }
        horizontalInput = Input.GetAxis("Horizontal")*3;

     }
     //fixed update is called everyone physics update
     void FixedUpdate()
     {
        rigidbodyComponent.velocity = new Vector3(horizontalInput,rigidbodyComponent.velocity.y,0);
        if(Input.GetKeyDown(KeyCode.W) == true&&speedCounter>0)
        {
            speedCounter--;
            horizontalInput *= 4;
        }
        if(Physics.OverlapSphere(groundCheck.position,0.1f,playerMask).Length == 0)
        {
            return;
        }
        if (JumpKeyPressed == true) //check if space key is checked out
        {
            rigidbodyComponent.AddForce(Vector3.up*5,ForceMode.VelocityChange);
            JumpKeyPressed = false;
        }
       
     }
     private void OnTriggerEnter(Collider other)
     {
        if(other.gameObject.layer == 7)
        {
            Destroy(other.gameObject);
            score++;
            speedCounter++;
        }
     }
}
