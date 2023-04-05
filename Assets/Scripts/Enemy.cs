using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage, float delay)
    {
        currentHealth -= damage;

        StartCoroutine(ShowHurtAnimation(delay));

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    IEnumerator ShowHurtAnimation(float delay)
    {
        yield return new WaitForSeconds(delay);

        animator.SetTrigger("Hurt");
    }
    void Die()
    {
        Debug.Log("Enemy died!");

        animator.SetBool("IsDead", true);

        GetComponent<Collider2D>().enabled = false;
        GetComponent<Rigidbody2D>().simulated = false;

        this.enabled = false;
    }

}
