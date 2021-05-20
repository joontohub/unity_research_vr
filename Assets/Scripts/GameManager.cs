using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject Character;
    private Animator characterAnim;
    public GameObject lightObject;
    private Light objectLight;
    private void Start() {
      objectLight   = lightObject.GetComponent<Light>();
      characterAnim = Character.GetComponent<Animator>();
    }
    public void LightOnOff()
    {
        objectLight.enabled = !objectLight.enabled;
    }
    private void Update() {
      if(Input.GetKeyDown(KeyCode.A))
      {
        objectLight.enabled = !objectLight.enabled;
      }
      else if(Input.GetKeyDown(KeyCode.B))
      {
        characterAnim.SetTrigger("Blink");
      }
      else if (Input.GetKeyDown(KeyCode.E))
      {
        CharacterManager.Instance.OnEat();
      }
      else if(Input.GetKeyDown(KeyCode.R))
      {
        CharacterManager.Instance.OffEat();
      }
      else if (Input.GetKey(KeyCode.D))
      {
        CharacterManager.Instance.OnDrink();
      }
      else if (Input.GetKey(KeyCode.F))
      {
        CharacterManager.Instance.OffDrink();
      }
      else if(Input.GetKey(KeyCode.L))
      {
        CharacterManager.Instance.StateOn();
      }
      else if(Input.GetKey(KeyCode.O))
      {
        LightOnOff();
      }
      else if( Input.GetKey(KeyCode.M))
      {
        MusicController._instance.PlayAudio();
      }
      else if( Input.GetKey(KeyCode.N))
      {
        MusicController._instance.PlayAudio();
      }
    }
}
