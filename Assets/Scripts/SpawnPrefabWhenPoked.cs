using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabWhenPoked : MonoBehaviour
{
    public GameObject prefab;

    public void Poke() {
        var instance = Instantiate(prefab);
        instance.transform.position = this.transform.position;
    }
}
