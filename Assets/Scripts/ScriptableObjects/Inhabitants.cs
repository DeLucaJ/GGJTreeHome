﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inhabitant", menuName = "Inhabitant")]
public class Inhabitants : ScriptableObject
{
    public Sprite sprite;
    public Color color;
    public Action preference;
}
