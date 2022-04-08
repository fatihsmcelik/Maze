using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExitBehaviour : MonoBehaviour
{
    public bool finished = false;
   void OnTriggerEnter(Collider other){
       if(other.name == "Character"){
           finished = true;
          
       }
   }
   
   public void Update(){
if(finished){
    Application.LoadLevel(1);
    Player.start = false;

}
   }
}
