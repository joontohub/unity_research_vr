using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public GameObject handBottle;
    public GameObject spoon;
    private Animator animator ;
    public GameObject bottle;
    public GameObject leftHand;
    public bool eatChecker;
    public bool drinkChecker;
    private DrinkEvent drinkEvent;
    private EatEvent eatEvent;
    private static CharacterManager _instance;

    public static CharacterManager Instance
    {
        get {

            if(!_instance)
            {
                _instance = FindObjectOfType(typeof(CharacterManager)) as CharacterManager;

                if (_instance == null)
                    Debug.Log("no Singleton obj");
            }
            return _instance;
        }
    }
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        drinkEvent = animator.GetBehaviour<DrinkEvent>();
        eatEvent = animator.GetBehaviour<EatEvent>();
    }

    // Update is called once per frame

    public void OnEat() 
    {
        animator.SetBool("Eat",true);    
        eatChecker = true;
        EatCheckOff(); // 
    }
    public void OffEat()
    {
        animator.SetBool("Eat",false);
        eatChecker = false;

    }
    public void Blink()
    {
        animator.SetTrigger("Blink");
    }
    public void OnDrink()
    {
        animator.SetBool("Drink", true);
        drinkChecker = true;
        DrinkCheckOff();
    }
    public void OffDrink()
    {
        animator.SetBool("Drink", false);
        drinkChecker = false;
    }
    private void EatCheckOff(){
        Invoke("OffEat", 2f);
    }
    private void DrinkCheckOff()
    {
        Invoke("OffDrink", 2f);
    }
    public void StateOn()
    {
        animator.SetTrigger("State");
    }

}
