using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarknessFade : MonoBehaviour
{
    //this script's purpose is to let a black sprite fade in and out of the visible game to hide parts of the maze when the player moves on to a new layer/floor in the maze  

    public GameObject darknessBelow; // this is the floor the player is entering
    public GameObject darknessAbove; //this is the floor the player came from



    public float fadeTime = 0.5f;

	// Use this for initialization
	void Start ()
    {
        

	}
	
	

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "lightcheck")
        {
            

            StartCoroutine(FadeOut(darknessBelow.GetComponent<SpriteRenderer>()));
            StartCoroutine(FadeIn(darknessAbove.GetComponent<SpriteRenderer>()));
            
            
        }   

        if (collision.gameObject.tag == "lightcheck")
        {
            
            StartCoroutine(FadeIn(darknessBelow.GetComponent<SpriteRenderer>()));
            StartCoroutine(FadeOut(darknessAbove.GetComponent<SpriteRenderer>()));
            
            
        }
    }



    IEnumerator FadeOut(SpriteRenderer dark)
    {
        Color tmpColor = dark.color;

        while ( tmpColor.a > 0f)
        {
            tmpColor.a -= Time.deltaTime / fadeTime;
            dark.color = tmpColor;

            if (tmpColor.a <= 0f) tmpColor.a = 0.0f;

            yield return null;
        }

        dark.color = tmpColor;
    }

    IEnumerator FadeIn(SpriteRenderer dark)
    {
        Color tmpColor = dark.color;

        while (tmpColor.a < 1f)
        {
            tmpColor.a += Time.deltaTime / fadeTime;
            dark.color = tmpColor;

            if (tmpColor.a >= 1f) tmpColor.a = 1.0f;

            yield return null;
        }

        dark.color = tmpColor;
    }
    
}
