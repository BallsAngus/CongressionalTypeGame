using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    public WordManager wordManager;
    public Animator animator;
    public AudioSource audioSource;
    public GameObject shield_explosion;

    private void Start()
    {
        animator.SetBool("isDamaged", false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "word")
        {
            wordManager.loseHealth(5);
            Instantiate(shield_explosion, new Vector3(other.transform.position.x, other.transform.position.y, 0f), Quaternion.identity);
            damageShield();
        }
        else if(other.gameObject.tag == "bullet")
        {
            wordManager.loseHealth(2);
            damageShield();
        }
        Destroy(other.gameObject);
        
    }

    private void damageShield()
    {
        audioSource.Play();
        animator.SetBool("isDamaged", true);
    }
}
