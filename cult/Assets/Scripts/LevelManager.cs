using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    [SerializeField]
    private List<FloatSO> allResources;




    private void Awake()
    {
        foreach (var resource in allResources)
        {
            resource.ResetValue();
        }
    }













}
