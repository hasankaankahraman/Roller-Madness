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
            //SpawnObject(enemyprefab, spawnpositions[RandomSpawnNumber()]); Normalde tek tek �a��r�yorduk prefablar� diziye aktard�k.Yukar�daki sat�r.


            print("Spawn");
        }
    }

    private void SpawnObject(GameObject obj, Transform newtransform)
    {
        Instantiate(obj, newtransform.position,newtransform.rotation); // Coin spawnlad�k.
    }

    private int RandomSpawnNumber()
    {
        return Random.Range(0, spawnpositions.Length); // prefablar�n ��kaca�� posizyonlar� diziden random se�tik.
    }
    private int RandomObjects()
    {
        return Random.Range(0,spawnobjects.Length); // prefablar� diziden random se�tik.
    }
}









/*
spawntime = looptime - time;

if (Time.time > looptime)
{
    time = 0f;
}

Bu �ekilde spawn s�resini geri say�c� yapmaya �al��t�m her 5 snde bir s�f�rlanarak geri sayacak.
Bunu tekrar dene !!! :D
*/