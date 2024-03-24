using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public PokeDatabase database;

    public ApiPokemon ApiPoke;

    public PokeData GetData(int id) => database.data[id];

    public int Combien() => database.data.Count;

    
    void Awake()
    {
        database.InitData();

        Sprite pokeIcon = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/sprite/38.png", typeof(Sprite));

        //database.CreationPoke(0, "Feunard", 11, 199, pokeIcon, new Stats(73, 76, 75, 81, 100, 100));

        StartCoroutine(ApiPoke.AddApiPoke(280));
        StartCoroutine(ApiPoke.AddApiPoke(281));
        StartCoroutine(ApiPoke.AddApiPoke(282));

        for (int i = 1; i < 10; i++)
        {
            StartCoroutine(ApiPoke.AddApiPoke(i));
        }
    }
}
