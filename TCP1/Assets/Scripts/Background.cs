using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed, endX, startX;
    private Material currentMaterial;
    private float offset;

    void Start ()
    {
        currentMaterial = this.gameObject.GetComponent<SpriteRenderer>().material;
    }

    void Update ()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
        /*offset += 0.001f;
        currentMaterial.SetTextureOffset("_MainTex", new Vector2(offset * speed, 0));*/
    }
}
