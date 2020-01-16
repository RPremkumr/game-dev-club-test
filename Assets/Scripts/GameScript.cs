using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{

    private GameObject player;
    private GameObject coin;

    private GameObject playerPrefab;
    private GameObject enemyPrefab;
    private GameObject coinPrefab;

    // Start is called before the first frame update
    void Start()
    {
        playerPrefab = Resources.Load<GameObject>("Player");
        player = Instantiate(playerPrefab);

        SpawnEnemy();
        SpawnCoin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        if(player.GetComponent<Collider2D>().IsTouching(coin.GetComponent<Collider2D>())) {
            Destroy(coin);
            // add point
            SpawnCoin();
        }
    }

    void SpawnEnemy() {
        enemyPrefab = Resources.Load<GameObject>("Enemy");
        enemyPrefab.GetComponent<EnemyControl>().player = player;
        Instantiate(enemyPrefab);
    }

    void SpawnCoin() {
        coinPrefab = Resources.Load<GameObject>("Coin");
        coinPrefab.transform.localPosition = new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(-3.5f, 3.5f), 0);
        coin = Instantiate(coinPrefab);
    }
}
