using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;


[CreateAssetMenu]
public class FloatSO : ScriptableObject
{

    [SerializeField]
    private float value, initialValue;


    public Sprite icon;
    public string floatName;


    public float Value { get => value;}


    public event Action<float> ValueChangedBy = delegate { };
    public event Action<float> ValueSetToNewAmount = delegate { };



    public void ChangeAmountBy(float changeBy)
    {
        value += changeBy;
        value = Mathf.Clamp(value, 0f, value);

        ValueChangedBy(changeBy);
    }


    public void SetNewAmount(float newAmount)
    {
        value = newAmount;
        value = Mathf.Clamp(value, 0f, value);

        ValueSetToNewAmount(newAmount);
    }


    public void ResetValue()
    {
        value = initialValue;

    }

}
