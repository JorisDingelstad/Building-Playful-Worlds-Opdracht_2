using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorFade : MonoBehaviour
{
    public GameObject door;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "groundcheck")
        {
            StartCoroutine(FadeAway(0.0f, 1.0f));
        }
    }

    IEnumerator FadeAway(float value, float time)
    {
        if (door != null)
        {
            float alpha = door.GetComponentInChildren<SpriteRenderer>().color.a;

            for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / time)
            {
                if (door != null)
                {
                    Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, value, t));
                    door.GetComponentInChildren<SpriteRenderer>().material.color = newColor;
                    yield return null;
                }
            }
            Destroy(door);
        } 
    }

}
