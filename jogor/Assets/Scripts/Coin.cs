using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int scoreValue;
    private AudioSource sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sound.Play();
            GameController.instance.UpdateScore(scoreValue);
            Destroy(gameObject, 0.1f);
        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
