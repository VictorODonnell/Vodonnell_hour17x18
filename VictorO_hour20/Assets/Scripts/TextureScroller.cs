using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float speed = .5f;

    Renderer myrenderer;
    float offset;

    // Start is called before the first frame update
    void Start()
    {
        myrenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //increase offset based on time
        offset += Time.deltaTime * speed;
        //keep offset between 1 and 0
        if (offset < 0) 
            offset -= 1;
        //apply the offset to the material 
        myrenderer.material.mainTextureOffset = new Vector2(0, offset);

    }
}
