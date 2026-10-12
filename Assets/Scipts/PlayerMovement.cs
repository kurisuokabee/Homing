using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float turnSpeed;

    
    void Update()
    {
        float turnInput = Input.GetAxis("Horizontal");

        transform.position += transform.up * moveSpeed * Time.deltaTime;

        Quaternion turnRotation = Quaternion.Euler(0, 0, -turnInput * turnSpeed * Time.deltaTime);

        transform.rotation *= turnRotation;
    }
}
