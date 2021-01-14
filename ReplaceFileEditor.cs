using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
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

