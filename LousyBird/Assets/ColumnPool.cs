
using System.Collections;

using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public float spawnRate = 4f;
    public int columnPoolSize = 5;
    public GameObject columnPrefab;
    private GameObject[] column;
    public float columnMin = -1f;
    public float columnMax = 3.5f;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentColumn = 0;
    // Start is called before the first frame update
    void Start()
    {
        column = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            column[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime*3f;
        if(GameControl.instance.gameOver==false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(columnMin, columnMax);
            column[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentColumn++;
            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }
        }
    }
}
