using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOnTouch : MonoBehaviour
{
    public Rigidbody rb;

    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform spawn;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Death"))
        {
            player.transform.position = spawn.transform.position;
            rb.velocity = new Vector3(0,0,0);
        }
    }
}
