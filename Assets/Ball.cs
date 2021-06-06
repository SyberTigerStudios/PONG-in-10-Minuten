using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rg;
    public float speed;
    private int lPunkte, rPunkte;
    public TextMeshProUGUI textR, textL;
    void Start()
    {
        Launch();
    }

    void Launch()
    {
        transform.position = Vector2.zero;
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        rg.velocity = new Vector2(x * speed, y * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Links")
        {
            rPunkte++;
            textR.text = rPunkte.ToString();
            Launch();
        }
        else if (collision.gameObject.tag == "Rechts")
        {
            lPunkte++;
            textL.text = lPunkte.ToString();
            Launch();
        }
    }
}
