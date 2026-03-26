using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health = 5;
    public TextMeshProUGUI healthText;
    public GameObject gameOverPanel;

    void Start()
    {
        healthText.text = "Vidas: " + health;
        gameOverPanel.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            health--;
            Destroy(other.gameObject);
            healthText.text = "Vidas: " + health;

            if (health <= 0)
            {
                gameOverPanel.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}