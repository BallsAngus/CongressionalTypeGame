using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip laser;
    public Text text;
    public float fallSpeed = 0.7f;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public GameObject projectile;
    public Transform projectileSpawn;
    private Transform cam;

	public float nextFire = 3.0f;
	public float currentTime = 0.0f;


    public GameObject explosion;

    private void Start()
    {
        projectileSpawn = this.gameObject.transform;
        cam = Camera.main.transform;
    }

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        if(text != null)
        {
            text.text = text.text.Remove(0, 1);
            text.color = Color.red;
        }
    }

    public void RemoveWord()
    {
        explode();
        Destroy(gameObject);
    }

    private void Update()
    {
        if(gameObject.tag == "shooty word")
        {
            if(transform.position.y > 2.5f + cam.position.y)
            {
                transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
            }
            else
            {
                transform.Translate(0f, -0.3f * Time.deltaTime, 0f);
                shoot();
            }
        }
        else
        {
            transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        }
    }

    public SpriteRenderer GetSpriteRenderer()
    {
        return spriteRenderer;
    }

    public Sprite getSprite()
    {
        return newSprite;
    }

    public void shoot()
    {
        currentTime += Time.deltaTime;
		if (currentTime > nextFire) 
		{
			nextFire += currentTime;
            audioSource.PlayOneShot(laser);
			Instantiate(projectile, projectileSpawn.position, Quaternion.identity); //FIRE!
			nextFire -= currentTime;
			currentTime = 0.0f;
		}
    }

    public bool isNull()
    {
        if(text == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void explode()
    {
        Instantiate(explosion, new Vector3(transform.position.x, transform.position.y, 0f), Quaternion.identity);
    }
}
    

