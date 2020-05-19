using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour, IClickable
{
    public void Click()
    {
        transform.Rotate(new Vector3(0f, 0f, 45f));
    }
}
