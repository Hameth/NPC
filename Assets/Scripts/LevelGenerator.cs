using UnityEngine;


public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public int numberOfPlatforms;
    public float levelWidth = 3f;
    public float minY = .5f;
    public float maxY = 1.5f;

    private void Start()
    {
        var spawnPosition = new Vector3();
        
        for (var i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
