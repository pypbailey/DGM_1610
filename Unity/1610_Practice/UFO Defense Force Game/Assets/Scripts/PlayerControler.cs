using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float horizontalInput;
    public float speed;

    public float xRange;

    public Transform blaster;
    public GameObject lazerbolt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // Set horizontalInput to be recieved by keyboard
       horizontalInput = Input.GetAxis("Horizontal");

    // Moves Player left and right
       transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    // Keep player within bounds
    // Left side wall
       if(transform.position.x < -xRange )
       {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
       }
    // Right side wall
       if(transform.position.x > xRange )
       {
            transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
       }
        // If space bar is pressed fire lazerbolt
       if(Input.GetKeyDown(KeyCode.Space))
       {
            //Create lazerBolt at the blaster transform position maintaining the objects rotation.
            Instantiate(lazerbolt, blaster.transform.position, lazerbolt.transform.rotation);
       }
    }
}
