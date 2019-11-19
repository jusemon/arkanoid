using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group : MonoBehaviour
{
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        var blocks = GetComponentsInChildren<SpriteRenderer>();
        foreach (var block in blocks)
        {
            block.color = new Color(color.r, color.g, color.b);
        }
    }
}
