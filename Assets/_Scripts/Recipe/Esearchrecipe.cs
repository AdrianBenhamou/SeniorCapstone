﻿using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class Rootobject
{
    public int took { get; set; }
    public bool timed_out { get; set; }
    public _Shards _shards { get; set; }
    public Hits hits { get; set; }
}
[Serializable]
public class _Shards
{
    public int total { get; set; }
    public int successful { get; set; }
    public int skipped { get; set; }
    public int failed { get; set; }
}
[Serializable]
public class Hits
{
    public int total { get; set; }
    public double max_score { get; set; }
    public Hit[] hits { get; set; }
}
[Serializable]
public class Hit
{
    public string _index { get; set; }
    public string _type { get; set; }
    public string _id { get; set; }
    public double _score { get; set; }
    public _Source _source { get; set; }
}
[Serializable]
public class _Source
{
    public string name { get; set; }
    public ingredients[] ingredients { get; set; }
    public string[] tags { get; set; }
}
[Serializable]
public class ingredients
{
    public string IngredientAmount { get; set; }
    public string IngredientName { get; set; }
}
