using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {
    //public variables
    public GameObject min;
    public GameObject max;
    public GameObject father;
    public GameObject[] hazard;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    //private variables
    private GameObject clone;

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnWaves());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(father.transform.position.x - 9, father.transform.position.x + 7), father.transform.position.y + 5, father.transform.position.z);
                Quaternion spawnRotation = Quaternion.identity;
                int random = Random.Range(0, 2);
                switch (random)
                {
                    case 0:
                        clone = Instantiate(hazard[0], spawnPosition, spawnRotation);
                        clone.transform.parent = father.transform;
                        break;
                    case 1:
                        clone = Instantiate(hazard[1], spawnPosition, spawnRotation);
                        clone.transform.parent = father.transform;
                        break;
                }

                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}
