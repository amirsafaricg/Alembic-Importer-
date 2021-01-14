using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceFile : MonoBehaviour
{
      
   public Material[] ModelMaterials;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void GetInfo(){
            GetComponent<InfoHolder>().Pos = transform.position;
                GetComponent<InfoHolder>().quat = transform.rotation;
                    GetComponent<InfoHolder>().Scale = transform.localScale;
        int b=0;
        if(  GetComponent<InfoHolder>().ChildDepth ==0){
  for(int i=0; i<transform.childCount;i++){
                for(int a =0 ; a< transform.GetChild(i).childCount;a++){
                    b++;
                      GetComponent<InfoHolder>().Materials[b-1] = transform.GetChild(i).transform.GetChild(a).GetComponent<Renderer>().sharedMaterial;
                }
          }
        }else if ( GetComponent<InfoHolder>().ChildDepth ==1){
  for(int i=0; i<transform.GetChild(0).childCount;i++){
                for(int a =0 ; a< transform.GetChild(0).GetChild(i).childCount;a++){
                    b++;
                      GetComponent<InfoHolder>().Materials[b-1] = transform.GetChild(0).GetChild(i).transform.GetChild(a).GetComponent<Renderer>().sharedMaterial;
                }
          }
        }else if( GetComponent<InfoHolder>().ChildDepth ==2){
  for(int i=0; i<transform.GetChild(0).GetChild(0).childCount;i++){
                for(int a =0 ; a< transform.GetChild(0).GetChild(0).GetChild(i).childCount;a++){
                    b++;
                      GetComponent<InfoHolder>().Materials[b-1] = transform.GetChild(0).GetChild(0).GetChild(i).transform.GetChild(a).GetComponent<Renderer>().sharedMaterial;
                }
          }
        }else if( GetComponent<InfoHolder>().ChildDepth ==3){
 for(int i=0; i<transform.GetChild(0).GetChild(0).GetChild(0).childCount;i++){
                for(int a =0 ; a< transform.GetChild(0).GetChild(0).GetChild(0).GetChild(i).childCount;a++){
                    b++;
                      GetComponent<InfoHolder>().Materials[b-1] = transform.GetChild(0).GetChild(0).GetChild(0).GetChild(i).transform.GetChild(a).GetComponent<Renderer>().sharedMaterial;
                }
          }
        }
        else if( GetComponent<InfoHolder>().ChildDepth ==4){
 for(int i=0; i<transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).childCount;i++){
                for(int a =0 ; a< transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(i).childCount;a++){
                    b++;
                      GetComponent<InfoHolder>().Materials[b-1] = transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(i).transform.GetChild(a).GetComponent<Renderer>().sharedMaterial;
                }
          }
        }
         GetComponent<InfoHolder>().InstanceNew();
    }
    public void SetMats(){
          GetComponent<InfoHolder>().SetMats();
    }
    public void DeleteObj(){
          GetComponent<InfoHolder>().DeleteObj();
    }
}
