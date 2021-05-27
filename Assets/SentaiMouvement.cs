using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentaiMouvement : MonoBehaviour

{
    public int niveau = 0;
    public int pressed = 0;
    public Sprite SunGuy0;
    public Sprite SunGuy1;
    public Sprite SunGuy2;
    public Sprite SunGuy3;
    public Sprite SunGuy4;

    public Sprite Dino0;
    public Sprite Dino1;
    public Sprite Dino2;
    public Sprite Dino3;
    public Sprite Dino4;
    public Sprite Dino5;
    public Sprite Dino6;

    public Sprite Victoire;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        niveau = 1;
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = SunGuy0; // set the sprite to sprite1



    }

    // Update is called once per frame
    void Update()
    {

        if (niveau == 1) { 
            if (pressed == 0) { 
               if (Input.GetKey(KeyCode.UpArrow))
            {
                pressed = 1;
                Debug.Log("First move ok");
                spriteRenderer.sprite = SunGuy1;
            }
            }
            if (pressed == 1)
            {
                Debug.Log("Waiting for second move");
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    pressed = 2;
                    Debug.Log("Second move ok");

                    spriteRenderer.sprite = SunGuy2;
                }
            }
            if (pressed == 2)
            {
                Debug.Log("Waiting for third move");
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    pressed = 3;
                    Debug.Log("Third move ok");
                    spriteRenderer.sprite = SunGuy3;
                }
                
            }
            if (pressed == 3)
            {
                Debug.Log("Waiting for 1");
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    pressed = 0;
                    Debug.Log("Third move ok");
                    spriteRenderer.sprite = SunGuy4;
                    niveau = 2;
                }

            }

        }

        if (niveau == 2)
        {
            
            if (pressed == 0)
            {
                Debug.Log("Waiting for 1");
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    pressed = 1;
                    Debug.Log("First move ok");
                    spriteRenderer.sprite = Dino0;
                }
            }
            if (pressed == 1)
            {
                Debug.Log("Waiting for 3");
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    pressed = 2;
                    Debug.Log("Second move ok");

                    spriteRenderer.sprite = Dino1;
                }
            }
            if (pressed == 2)
            {
                Debug.Log("Waiting for 1");
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    pressed = 3;
                    Debug.Log("Third move ok");
                    spriteRenderer.sprite = Dino2;
                }
            }

            if (pressed == 3)
            {
                Debug.Log("Waiting for 1");
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    pressed = 4;
                    spriteRenderer.sprite = Dino3;
                }
            }

            if (pressed == 4)
            {
                Debug.Log("Waiting for 3");
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    pressed = 5;
                    spriteRenderer.sprite = Dino4;
                }
            }

            if (pressed == 5)
            {
                Debug.Log("Waiting for 2");
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    pressed = 6;
                    spriteRenderer.sprite = Dino5;
                    
                }
            }

            if (pressed == 6)
            {
                Debug.Log("Waiting for 3");
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    pressed = 7;
                    spriteRenderer.sprite = Dino6;

                }
            }

            if (pressed == 7)
            {
                Debug.Log("Waiting for 1");
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    pressed = 0;
                    spriteRenderer.sprite = Victoire;
                    niveau = 0;

                }
            }

        }




    }


}
