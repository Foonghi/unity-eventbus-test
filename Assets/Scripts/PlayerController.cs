using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Nvp.Tools.Events.EventBus;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    private float jumpPower = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        // although this is the update function, this is only executed once when space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            sendJumpMessage();
        }
    }

    private void sendJumpMessage()
    {
        NvpEventBus.DispatchEvent(GameEvent.Something, null);
    }

}
