using System.Collections;
using System.Collections.Generic;
using Nvp.Tools.Events.EventBus;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody rb;
    private float jumpPower = 10f;
    // Start is called before the first frame update

    private void OnEnable()
    {
        NvpEventBus.AddListener(GameEvent.Something, OnJumpMessage);
    }

    private void OnDisable()
    {
        NvpEventBus.RemoveListener(GameEvent.Something, OnJumpMessage);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnJumpMessage(object obj){
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
}
