using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class HomingMissile : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;
    
    void Update()
    {
        Vector3 dir = (target.position - transform.position).normalized;

        float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg) - 90f;
        Quaternion rot = Quaternion.Euler(0f, 0f, angle);

        transform.rotation = Quaternion.Slerp(transform.rotation, rot, 5f * Time.deltaTime);


        transform.position += dir * speed * Time.deltaTime;

    }
}
