using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public AudioSource a_s;
    string myname;
    public GameObject key;
    void Start(){
       
    }
    void Update(){

    }
    void OnCollisionEnter(Collision collision){
        //print(collision.gameObject.name);
        if(collision.gameObject.name != "Piano"){
            print("colliding rn");
            a_s.PlayDelayed(5);
            //key = GameObject.Find("/PianoKeyboard/Key_C");
            transform.Rotate(30, 0, 0);
        }
    }
    void OnCollisionExit(Collision collision){
        //print(collision.gameObject.name);
        if(collision.gameObject.name != "Piano"){
            a_s.Stop();
            print("exiting rn");
            //key = GetComponentInParent<Key_C>();
            //key = GameObject.Find("/PianoKeyboard/Key_C");
            transform.Rotate(-30, 0, 0);
        }
    }
    public AudioSource getthisAudioSource(){
        return a_s;
    }

}