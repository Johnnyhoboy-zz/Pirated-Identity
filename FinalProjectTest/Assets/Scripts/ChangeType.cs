﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeType : MonoBehaviour
{
    public class Type : IComparable<Type>
    {
        public string type;
        public int points;
        public Type(string type, int points)
        {
            type = this.type;
            points = this.points;
        }
        public int CompareTo(Type other)
        {
            if (other == null)
            {
                return 1;
            }
            return points - other.points;
        }
    }

    public static Type red, green, blue;
    public Material currentMaterial;
    public Material redM, greenM, blueM;
    List<Material> mats;
    public GameObject Object;
    // Use this for initialization
    void Start()
    {
        red = new Type("Red", 0);
        green = new Type("Green", 0);
        blue = new Type("Blue", 0);
        // define the materials
        mats = new List<Material>(new Material[] { redM, greenM, blueM });
        Object.GetComponent<MeshRenderer>().material = currentMaterial;
    }

    // Update is called once per frame
    void Update()
    {

        if (red.CompareTo(green) > 0 && red.CompareTo(blue) > 0)
        {
            Object.GetComponent<MeshRenderer>().material = redM;
        }
        else if (green.CompareTo(red) > 0 && green.CompareTo(blue) > 0)
        {
            Object.GetComponent<MeshRenderer>().material = greenM;
        }
        else if (blue.CompareTo(red) > 0 && blue.CompareTo(green) > 0)
        {
            // blue material
            Object.GetComponent<MeshRenderer>().material = blueM;
        }
        else {
            Object.GetComponent<MeshRenderer>().material = currentMaterial;
        }
    }
}