using UnityEngine;

public class Collectible : MonoBehaviour
{
    public ScoreDisplay scoreDisplay;
    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.TryGetComponent<PlayerController>(out var player))
        {
            scoreDisplay.IncreaseScore();
            // Уничтожаем текущий объект
            Destroy(gameObject);
        }
    }
}