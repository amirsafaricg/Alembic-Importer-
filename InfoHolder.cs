using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoHolder : MonoBehaviour
{
    // Start is called before the first frame update
[HideInInspector]public Material[] Materials = new Material[1000];
  [HideInInspector] public Vector3 Pos; [HideInInspector] public Quaternion quat;
 [HideInInspector] public Vector3 Scale;
    public GameObject ReplaceWith; 
     public int ChildDepth;
     public int SecondaryDepth;
    [HideInInspector] public Transform NewObj;
    [HideInInspector] public Transform RenderersParent;
         public void InstanceNew(){
         NewObj = Instantiate(ReplaceWith,Pos,quat).transform;
         NewObj.transform.localScale = Scale;
          SetMaterials();
          NewObj.gameObject.AddComponent<InfoHolder>();
             NewObj.gameObject.AddComponent<ReplaceFile>();
             NewObj.GetComponent<InfoHolder>().ChildDepth = ChildDepth;
   
     }
     void SetMaterials(){
            int b=0;
        if( ChildDepth ==0){
  for(int i=0; i<transform.childCount;i++){
                for(int a =0 ; a< transform.GetChild(i).childCount;a++){
                    b++;
                    transform.GetChild(i).transform.GetChild(a).GetComponent<Renderer>().sharedMaterial =  Materials[b-1];
                }
          }
        }else
   if( ChildDepth ==1){
  for(int i=0; i<transform.GetChild(0).childCount;i++){
                for(int a =0 ; a< transform.GetChild(0).GetChild(i).childCount;a++){
                    b++;
                    transform.GetChild(0).GetChild(i).transform.GetChild(a).GetComponent<Renderer>().sharedMaterial =  Materials[b-1];
                }
          }
        }else
        if( ChildDepth ==2){
  for(int i=0; i<transform.GetChild(0).GetChild(0).childCount;i++){
                for(int a =0 ; a< transform.GetChild(0).GetChild(0).GetChild(i).childCount;a++){
                    b++;
                    NewObj.GetChild(0).GetChild(0).GetChild(i).transform.GetChild(a).GetComponent<Renderer>().sharedMaterial =  Materials[b-1];
                }
          }
        }else
            if( ChildDepth ==3){
  for(int i=0; i<transform.GetChild(0).GetChild(0).GetChild(0).childCount;i++){
                for(int a =0 ; a< transform.GetChild(0).GetChild(0).GetChild(0).GetChild(i).childCount;a++){
                    b++;
                    transform.GetChild(0).GetChild(0).GetChild(0).GetChild(i).transform.GetChild(a).GetComponent<Renderer>().sharedMaterial =  Materials[b-1];
                }
          }
            }else
       
         if( ChildDepth ==4){
  for(int i=0; i<transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).childCount;i++){
                for(int a =0 ; a< transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(i).childCount;a++){
                    b++;
                    transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(i).transform.GetChild(a).GetComponent<Renderer>().sharedMaterial =  Materials[b-1];
                }
          }
        }
     }
     public void SetMats(){
         if(SecondaryDepth ==0){
             RenderersParent = NewObj.transform;
         }else if  (SecondaryDepth ==1){
 RenderersParent = NewObj.GetChild(0).transform;
         }else  if(SecondaryDepth ==2){
 RenderersParent = NewObj.GetChild(0).GetChild(0).transform;
         }else  if(SecondaryDepth ==3){
 RenderersParent = NewObj.GetChild(0).GetChild(0).GetChild(0).transform;
         }else  if(SecondaryDepth ==4){
 RenderersParent = NewObj.GetChild(0).GetChild(0).GetChild(0).GetChild(0).transform;
         }
           for(int i = 0;i<RenderersParent.childCount;i++){
               RenderersParent.GetChild(i).GetChild(0).GetComponent<Renderer>().sharedMaterial = Materials[i];
           }
     }
     public void DeleteObj(){
         DestroyImmediate(gameObject);
     }
}
