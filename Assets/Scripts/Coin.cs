using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    SoundHub soundHub;
    private void Awake()
    {
        soundHub = GameObject.Find("SoundHub").GetComponent<SoundHub>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        soundHub.PlayCoinSound();
        Destroy(this.gameObject);
        FindObjectOfType<GameState>().updateScore();
    }
}
