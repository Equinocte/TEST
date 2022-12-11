using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;

    private bool obtained = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                //GameManager.instance.NoteHit();
                obtained = true;
                gameObject.SetActive(false);

                if (Mathf.Abs(transform.position.y) > 1.5)
                {
                    Debug.Log("hit");
                    GameManager.instance.NormalHit();
                }
                else if (Mathf.Abs(transform.position.y) > 0.5)
                {
                    Debug.Log("good");
                    GameManager.instance.GoodHit();
                }
                else
                {
                    Debug.Log("perfect");
                    GameManager.instance.PerfectHit();
                }


            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
            if (!obtained)
            {
                GameManager.instance.NoteMissed();
            }

        }
    }
}
