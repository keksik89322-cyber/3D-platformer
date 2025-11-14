using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float Speed = 2f;      // Частота колебаний (скорость колебания)
    public float Amplitude = 3f;  // Амплитуда колебаний (расстояние)

    private Vector3 initialPosition;  // Начальная позиция платформы

    void Start()
    {
        // Сохраняем начальную позицию платформы
        initialPosition = transform.position;
    }

    void Update()
    {
        // Рассчитываем новое положение платформы по формуле синусоидальной волны
        float xOffset = Mathf.Sin(Time.time * Speed) * Amplitude;
        transform.position = new Vector3(initialPosition.x + xOffset, initialPosition.y, initialPosition.z);
    }
}