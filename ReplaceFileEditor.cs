using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
// Created By Amir Safari , MadMaqz Game Developing team 
// Contact : a.safari1380@gmail.com
[CustomEditor(typeof(ReplaceFile))]
public class ReplaceFileEditor : Editor
{
    ReplaceFile RF;

public override void OnInspectorGUI(){
    serializedObject.Update();
    RF = (ReplaceFile)target;
    if(GUILayout.Button(" Change Model")){
        RF.GetInfo();
    }
    if(GUILayout.Button("ChangeMaterial")){
        RF.SetMats();
    }
    if(GUILayout.Button("Delete")){
        RF.DeleteObj();
    }
}
    }

