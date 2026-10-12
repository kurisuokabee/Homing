using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHP : MonoBehaviour
{
    [SerializeField] float currentHP;
    [SerializeField] TextMeshProUGUI hpText;

    public void TakeDamage(float damage)
    {
        currentHP = Mathf.Max(currentHP - damage, 0f);
        
        hpText.text = "HP: " + currentHP;

        if(currentHP <= 0)
        {
            Debug.Log("Scene Restart");
            SceneManager.LoadScene("Gameplay");    
        }
    }
}
