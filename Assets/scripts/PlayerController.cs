using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Vector3 startGamePosition;
    Vector3 targetPos;
    float laneOffset = 2.5f;
    float laneChangeSpeed = 15;
    bool isJumping = false;
    float jumpPower = 15;
    float jumpGravity = -40;
    float realGravity = -9.8f;
    // Start is called before the first frame update
    void Start()
    {
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            targetPos = new Vector3(targetPos.x - laneOffset, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            targetPos = new Vector3(targetPos.x + laneOffset, transform.position.y, transform.position.z);
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPos, laneChangeSpeed * Time.deltaTime);

        //if (Input.GetKeyDown(KeyCode.W) && isJumping == false)
       // {
        //    Jump();
       // }
    }

    //void Jump()
   // {
     //   isJumping = true;
      //  rb.AddForce(Vector3.up * jumpPower, ForceMode.Inpulse);
       // Physics.gravity = new Vector3(0, jumpGravity, 0);
       // StartCoroutine(StopjumpCoroutine());
   // }

   // IEnumerator StopJumpCorountine()
  //  {
      //  do
      //  {
          //  yiedl return new WaitForSeconds(0.02f);
   //     }
   //     while (rb.velocity.y != 0);
    //    isJumping = false;
    //    Physics.gravity = new Vector3(0, realGravity, 0);
    
    
   // }

}
