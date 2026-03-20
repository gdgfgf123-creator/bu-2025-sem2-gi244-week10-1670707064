using NUnit.Framework;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab1;
    public GameObject obstaclePrefab2;
    public GameObject obstaclePrefab3;
    
    public int ObP = 1;
    public Vector3 spawnPos = new(25, 0, 0);

    public float startDelay = 2;
    public float repeatRate = 2;

    private PlayerController playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Instantiate(obstaclePrefab, new Vector3(25, 0, 0), obstaclePrefab.transform.rotation);

        InvokeRepeating(nameof(SpawnObstacle), startDelay, repeatRate);

        GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        if (ObP == 1)
        {
            Instantiate(obstaclePrefab1, spawnPos, obstaclePrefab1.transform.rotation);
            ObP++;
        }
        else if (ObP == 2)
        {
            Instantiate(obstaclePrefab2, spawnPos, obstaclePrefab2.transform.rotation);
            ObP++;
        }
        else if (ObP == 3)
        {
            Instantiate(obstaclePrefab3, spawnPos, obstaclePrefab3.transform.rotation);
            ObP = 1;
        }
    }
}
