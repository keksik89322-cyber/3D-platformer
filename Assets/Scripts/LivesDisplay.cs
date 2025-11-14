using TMPro;
using UnityEngine;

public class LivesDisplay : MonoBehaviour
{
    public TextMeshProUGUI lifeText; // текстовый элемент, содержащий сердечки
    private string originalLives; // оригинальная строка сердечек
    private int livesLeft; // текущее количество сердец

    void Start()
    {
        // Запоминаем оригинал строки и считаем количество сердец
        originalLives = "♥♥♥";
        livesLeft = CountHearts(originalLives);
    }

    public void LoseHeart()
    {
        // Убираем одно сердце
        livesLeft--;
        if (livesLeft >= 0)
        {
            // Формируем новую строку с уменьшенным числом сердец
            lifeText.text = originalLives.Substring(0, livesLeft);
        }
        else
        {
            // Если сердец больше нет, очищаем текст
            lifeText.text = "";
        }
    }

    // Вспомогательная функция для подсчета сердец
    private int CountHearts(string text)
    {
        return text.Length;
    }
}
