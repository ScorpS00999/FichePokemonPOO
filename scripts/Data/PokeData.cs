using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class PokeData
{
    [Serializable]
    public struct Infos
    {
        public int vieActuelle;
        public float pntStats;
    }

    public string name;
    public int id;
    public float height;
    public float weight;
    public Sprite icon;

    public Infos info;
    public Stats stats;
    public ApiType[] apiTypes;



    public PokeData() { }

    public PokeData(int id, string name, float height, float weight, Sprite icon)
    {
        this.id = id;
        this.name = name;
        this.height = height;
        this.weight = weight;
        this.icon = icon;
    }

    public void InitCurrentLife()
    {
        this.info.vieActuelle = this.stats.HP;
    }

    public void InitStatsPoints()
    {
        this.info.pntStats = this.info.vieActuelle + this.stats.attack + this.stats.defense;
    }

    public bool IsPokemonAlive() { return this.info.vieActuelle > 0; }
}


[Serializable]
public class Stats
{
    public int HP;
    public int attack;
    public int defense;
    public int special_attack;
    public int special_defense;
    public int speed;

    public Stats() { }


    public Stats(int hP, int attack, int defense, int special_attack, int special_defense, int speed)
    {
        HP = hP;
        this.attack = attack;
        this.defense = defense;
        this.special_attack = special_attack;
        this.special_defense = special_defense;
        this.speed = speed;
    }
}

[Serializable]
public class ApiType
{
    public string name;
    public string image;
    public Sprite img;

    public ApiType(string name, Sprite img)
    {
        this.name = name;
        this.img = img;
    }
}