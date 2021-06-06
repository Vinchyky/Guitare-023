using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public KeyCode key;
    bool active = false;
    GameObject note, gn;
    SpriteRenderer sr;
    Color old;
    public bool CreateMode;
    public GameObject n;

    void Awake()
    {
        sr=GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        gn = GameObject.Find("GameManager");
        old=sr.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(CreateMode){
            if (Input.GetKeyDown(key)){
                Instantiate(n,transform.position, Quaternion.identity);
            }
        }
        else {
            if(Input.GetKeyDown(key))
                StartCoroutine(Pressed());
            if(Input.GetKeyDown(key)&&active){
                Destroy(note);
                gn.GetComponent<GameManager>().AddStreak();
                Addscore();
                active = false;
            }
            else if (Input.GetKeyDown(key) &&!active)
            {

                gn.GetComponent<GameManager>().ResetStreak();
            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D col){
        active=true;
        if(col.gameObject.tag == "Note")
            note=col.gameObject;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        active=false;
    }

    void Addscore()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score")+gn.GetComponent<GameManager>().GetScore());
    }

    IEnumerator Pressed(){
        
        sr.color=new Color(128,112,112,150);
        yield return new WaitForSeconds(0.2f);
        sr.color=old;
    }
}
