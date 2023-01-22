using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CollectCoin : MonoBehaviour
{
    public int _score;
    public TextMeshProUGUI _CoinText;

    public PlayerController playerController;
    public Animator PlayerAnim;
    public GameObject Player;

    private void Start() {
        PlayerAnim = Player.GetComponentInChildren<Animator>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Coin"))
        {
            AddCoin();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("End"))
        {
            playerController._runSpeed = 0;
            
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void AddCoin() {
        _score++;
        _CoinText.text = "Score: " + _score.ToString();
    }
}
