using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class GrassInfluenceBehaviour : MonoBehaviour
{

    public float influenceAmount;
    public Color influenceAreaColor;

    void Update()
    {
        Shader.SetGlobalVector("_Grass_Influence_Position", transform.position);
        Shader.SetGlobalFloat("_Grass_Influence_Amount", -influenceAmount);
        Shader.SetGlobalColor("_Grass_Influence_AreaColor", influenceAreaColor);
    }
}
