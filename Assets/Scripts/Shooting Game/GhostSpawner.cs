using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] EnemieReferences;


    private GameObject spawnedEnemie;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnimie());
    }
    IEnumerator SpawnEnimie()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            randomIndex = Random.Range(0, EnemieReferences.Length);
            randomSide = Random.Range(0, 2);
            spawnedEnemie = Instantiate(EnemieReferences[randomIndex]);
             void OnCollisionEnter2D(Collision2D collision)
            {
                if (collision.gameObject.CompareTag("Bullet"))
                {
                    Destroy(gameObject);
                }
            }

            if (randomSide == 0)
            {

                // left side spawned
                spawnedEnemie.transform.position = leftPos.position;
               spawnedEnemie.GetComponent<Ghost>().speed = Random.Range(3, 6);
               // Debug.Log("left side spawned");

            }
            else
            {
                //right side spawned

                spawnedEnemie.transform.position = rightPos.position;
               spawnedEnemie.GetComponent<Ghost>().speed = -Random.Range(3, 6);
                spawnedEnemie.transform.localScale = new Vector3(-1f, 1f, 1f);
             //   Debug.Log("right side spawned");
            }

        }
    }
}