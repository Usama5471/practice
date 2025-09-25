using UnityEngine;

public class player : MonoBehaviour
{
     Rigidbody rb;
    public float force = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();   
    }
    void PlayerMovement()
    {
        float XInput = Input.GetAxis("Horizontal");
        float YInput = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.forward * XInput * force, ForceMode.Force);
        rb.AddForce(Vector3.forward * YInput * force, ForceMode.Force);
    }
}
