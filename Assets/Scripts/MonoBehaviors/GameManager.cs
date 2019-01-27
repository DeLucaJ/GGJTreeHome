﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Action[] actions;
    public Inhabitant[] inhabitants;
    public treegrow tg;
    public int startingVal;
    //public Inhabitant[] inhabitants;

    [NonSerialized]
    public Dictionary<string, int> attributeScores = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start()
    {
        FillDictionary();
        tg.growth = startingVal;
        tg.max_children = startingVal;
        tg.leaf_factor = startingVal;
        tg.fruit_factor = startingVal;
    }

    void FillDictionary() {
        //fill dictionary
        for (int i = 0; i < actions.Length; i++){
            attributeScores.Add(actions[i].name, startingVal);
        }
    }

    private void handleBranch(Action act) {
        tg.max_children = attributeScores[act.name];
    }

    private void handleFruit(Action act) {
        tg.fruit_factor = attributeScores[act.name];
    }

    private void handleHeight(Action act) {
        tg.growth = attributeScores[act.name];
    }

    private void handleLeaf(Action act) {
        tg.leaf_factor = attributeScores[act.name];
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Action act in actions) {
            switch(act.name) {
                case "Branch": handleBranch(act);  break;
                case "Fruit": handleFruit(act); break;
                case "Height": handleHeight(act);  break;
                case "Leaf": handleLeaf(act);  break;
                default: break;
            }
        }
    }
}
