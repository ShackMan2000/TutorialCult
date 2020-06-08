using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceDisplay : MonoBehaviour
{

    [SerializeField]
    private Image iconImage;

    [SerializeField]
    private Text valueText;

    [SerializeField]
    private FloatSO resource;



    private void Awake()
    {
        SetText(resource.Value);
    }


    private void OnEnable()
    {
        resource.ValueChangedBy += SetText;
        resource.ValueSetToNewAmount += SetText;
    }



    private void OnValidate()
    {
        if (resource == null) return;

        iconImage.sprite = resource.icon;
        gameObject.name = resource.floatName + " Display";

        SetText(resource.Value);

    }



    private void SetText(float newAmount)
    {
        valueText.text = resource.Value.ToString("F0");
        
    }



    private void OnDisable()
    {
        resource.ValueChangedBy -= SetText;
        resource.ValueSetToNewAmount -= SetText;
    }

}
