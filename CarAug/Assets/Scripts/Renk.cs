using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renk : MonoBehaviour
{
    public FlexibleColorPicker fcp;
    public Material mat;

    void Update()
    {
        mat.color = fcp.color;
    }
}
