using UnityEngine;


public class HomingMissileMovement : MonoBehaviour
{
    public Transform target;
    [SerializeField] float speed;
    
    void Update()
    {
        Vector3 dir = (target.position - transform.position).normalized;

        Quaternion rot = Quaternion.LookRotation(Vector3.forward, dir);

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            rot,
            5f * Time.deltaTime
        );

        transform.position += dir * speed * Time.deltaTime;
    }
}
