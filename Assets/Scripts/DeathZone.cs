using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private Transform spawnPoint;
    private LivesDisplay livesDisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectWithTag("Respawn").transform;
        livesDisplay = FindObjectOfType<LivesDisplay>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            livesDisplay.LoseHeart();
            other.transform.position = spawnPoint.position;
        }
    }
}