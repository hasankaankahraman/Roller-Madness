using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnobjects;
    [SerializeField] private  float looptime = 5f;
                     private float spawntime = 0f;
    [SerializeField] private Transform[] spawnpositions;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawntime)
        {
            spawntime += looptime;
            //Instantiate(coinprefab,transform.position,transform.rotation);
            SpawnObject(spawnobjects[RandomObjects()], spawnpositions[RandomSpawnNumber()]); 
            //SpawnObject(enemyprefab, spawnpositions[RandomSpawnNumber()]); Normalde tek tek çağırıyorduk prefabları diziye aktardık.Yukarıdaki satır.


            print("Spawn");
        }
    }

    private void SpawnObject(GameObject obj, Transform newtransform)
    {
        Instantiate(obj, newtransform.position,newtransform.rotation); // Coin spawnladık.
    }

    private int RandomSpawnNumber()
    {
        return Random.Range(0, spawnpositions.Length); // prefabların çıkacağı posizyonları diziden random seçtik.
    }
    private int RandomObjects()
    {
        return Random.Range(0,spawnobjects.Length); // prefabları diziden random seçtik.
    }
}









/*
spawntime = looptime - time;

if (Time.time > looptime)
{
    time = 0f;
}

Bu şekilde spawn süresini geri sayıcı yapmaya çalıştım her 5 snde bir sıfırlanarak geri sayacak.
Bunu tekrar dene !!! :D
*/