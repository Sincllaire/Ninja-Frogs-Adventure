using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int pineapples = 0;

    [SerializeField] private Text PineapplesText;

    [SerializeField] private AudioSource itemcollectSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pineapple"))
        {
            itemcollectSoundEffect.Play();
            Destroy(collision.gameObject);
            pineapples++;
            PineapplesText.text = "Pineapples: " + pineapples;

        }
    }
}

