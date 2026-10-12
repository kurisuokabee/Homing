using UnityEngine;


public class HomingMissileDetection : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        Invoke(nameof(Die), 5f);
    }

    void Update()
    {
        float distanceSqr = (transform.position - target.position).sqrMagnitude;

        if (distanceSqr <= .5f * .5f)
        {
            Debug.Log("Detected Player!");
            
            target.GetComponent<PlayerHP>().TakeDamage(1);
            
            Die();

            return;  
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}