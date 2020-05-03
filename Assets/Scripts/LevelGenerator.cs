using UnityEngine;


public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject specialplatformPrefab;
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
            if (i == numberOfPlatforms/2 | i == numberOfPlatforms/3)
            {
                Instantiate(specialplatformPrefab, spawnPosition, Quaternion.identity);
            }
            else
            {
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            }
            
        }
    }
}
