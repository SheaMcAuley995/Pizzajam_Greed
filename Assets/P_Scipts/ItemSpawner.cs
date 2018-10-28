using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour {

   [SerializeField] GameObject spawnObj1;
   [SerializeField] GameObject spawnObj2;
   [SerializeField] GameObject spawnObj3;

    float Timer;
    [SerializeField] float circleRadius;

	void Update () {

        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        else
        {
            float randomGen = Random.Range(1, 100);
            if (randomGen < 50)
            {
                GameObject newboi = Instantiate(spawnObj1);
                newboi.transform.position = (Vector2)transform.position + Random.insideUnitCircle * circleRadius;
            }
            if(randomGen >= 50 && randomGen <= 90)
            {
                GameObject newboi = Instantiate(spawnObj2);
                newboi.transform.position = (Vector2)transform.position + Random.insideUnitCircle * circleRadius;
            }
            if(randomGen > 90)
            {
                GameObject newboi = Instantiate(spawnObj3);
                newboi.transform.position = (Vector2)transform.position + Random.insideUnitCircle * circleRadius;
            }
            Timer = Random.Range(2,8);
        }
    }
}
