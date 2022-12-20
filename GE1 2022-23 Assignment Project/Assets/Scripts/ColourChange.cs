using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    public MeshRenderer[] meshRenderer;

    [SerializeField] [Range(0f, 1f)] private float lerpTime;

    [Header("Colors")]

    [SerializeField] private Color[] lerpColors;

    private int colorIndex = 0;

    private float t = 0f;

    void Update()
    {

        foreach (MeshRenderer meshRenderer in meshRenderer)
        {
            meshRenderer.material.color = Color.Lerp(meshRenderer.material.color, lerpColors[colorIndex], lerpTime * Time.deltaTime);
        }

        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if (t > .9f)
        {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= lerpColors.Length) ? 0 : colorIndex;
        }
    }
}
