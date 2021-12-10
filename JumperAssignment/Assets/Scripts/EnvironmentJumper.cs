using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentJumper : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    public GameObject Obstacles;
    public bool canSpawnObstacles = true;
    public GameObject CoinsPrefab;
    public GameObject Coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        Obstacles = transform.Find("Obstacles").gameObject;
        Coins = transform.Find("Coins").gameObject;
        StartCoroutine(SpawnObstacleContinuously());

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnObstacleContinuously()
    {
        while (true)
        {
            float r = Random.Range(2f, 5.0f);
            yield return new WaitForSeconds(r);
            if (r>3)
            {
                SpawnObstacle();

            }
            else
            {
                SpawnCoins();
            }
        }
    }

    //Spawn every X seconds

    public void SpawnObstacle()
    {
        GameObject newObstacle = Instantiate(ObstaclePrefab.gameObject);

        newObstacle.transform.SetParent(Obstacles.transform);
        newObstacle.transform.localPosition = new Vector3(-8, 0.5f, 0);
    }

    public void SpawnCoins()
    {
        GameObject newCoin = Instantiate(CoinsPrefab.gameObject);
        newCoin.transform.SetParent(Coins.transform);
        newCoin.transform.localPosition = new Vector3(-8, 0.5f, 0);
    }

    public void ClearEnvironment()
    {        
        foreach (Transform obstacle in Obstacles.transform)
        {
            GameObject.Destroy(obstacle.gameObject);
        }
        foreach (Transform coin in Coins.transform)
        {
            GameObject.Destroy(coin.gameObject);
        }

        canSpawnObstacles = true;
    }
}
