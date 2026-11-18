using System.Collections;
using TMPro;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    public int enemyHealth = 10;
    public TMP_Text enemyText;

    private bool isDying = false;


    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Death();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("sword") || other.CompareTag("bullet"))
        {
            enemyHealth -= 10;
        }
    }
    void Death()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
            StartCoroutine(EnemyDeath());
        }
       
        IEnumerator EnemyDeath()
        {
            isDying = true;

            // Show the enemy's last words
            enemyText.gameObject.SetActive(true);
            enemyText.text = "I'm dead skull emoji";

            // Wait 2 seconds
            yield return new WaitForSeconds(2f);

            // Destroy the enemy
            Destroy(gameObject);
        }
    }


}