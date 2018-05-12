using UnityEngine;
using System.Collections;

public class spawnWaves : MonoBehaviour
{
    public GameObject[] hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                int random = Random.Range(0, 2);
                switch (random)
                {
                    case 0:
                        Instantiate(hazard[0], spawnPosition, spawnRotation);
                        break;
                    case 1:
                        Instantiate(hazard[1], spawnPosition, spawnRotation);
                        break;
                    case 2:
                        random = Random.Range(0, 2);
                        switch (random)
                        {
                            case 0:
                                Instantiate(hazard[2], spawnPosition, spawnRotation);
                                break;
                            case 1:
                                Instantiate(hazard[3], spawnPosition, spawnRotation);
                                break;
                            case 2:
                                Instantiate(hazard[4], spawnPosition, spawnRotation);
                                break;      
                        }
                        break;
                }
        
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}