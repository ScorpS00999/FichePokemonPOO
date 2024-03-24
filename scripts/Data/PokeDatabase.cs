using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Database/Pokemon", order = 0)]
public class PokeDatabase : ScriptableObject
{
    public List<PokeData> data = new();

    public void InitData()
    {
        data.RemoveAll(data => data.id > 0);
        //> 0 et pas >= 0 pour ne pas avoir de problème d'index au lancement 
    }

    
    public void CreationPoke(int id, string nom, int height, float weight, Sprite icon, Stats stats)
    {
        data.Add(new PokeData(id, nom, height, weight, icon));
    }
}
