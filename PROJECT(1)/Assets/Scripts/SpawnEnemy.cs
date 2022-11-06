using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject enemy;

    private float restartTime = 20f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    IEnumerator Spawn()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(restartTime);
        StartCoroutine(Spawn());
    }
}
