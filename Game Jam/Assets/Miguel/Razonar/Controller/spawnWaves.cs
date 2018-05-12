using UnityEngine;
using System.Collections;

public class spawnWaves : MonoBehaviour
{
    public GameObject palabras;
    public GameObject[] hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    private GameObject clone;

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
                        clone = Instantiate(hazard[0], spawnPosition, spawnRotation);
                        clone.transform.parent = palabras.transform;
                        break;
                    case 1:
                        clone = Instantiate(hazard[1], spawnPosition, spawnRotation);
                        clone.transform.parent = palabras.transform;
                        break;
                    case 2:
                        random = Random.Range(0, 2);
                        switch (random)
                        {
                            case 0:
                                clone = Instantiate(hazard[2], spawnPosition, spawnRotation);
                                clone.transform.parent = palabras.transform;
                                break;
                            case 1:
                                clone = Instantiate(hazard[3], spawnPosition, spawnRotation);
                                clone.transform.parent = palabras.transform;
                                break;
                            case 2:
                                clone = Instantiate(hazard[2], spawnPosition, spawnRotation);
                                clone.transform.parent = palabras.transform;
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