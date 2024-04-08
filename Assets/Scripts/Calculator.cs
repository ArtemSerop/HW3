using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public float SummaNum1 = 3.2f;
    public float SummaNum2 = 2.4f;
    [HideInInspector]
    public float SummaResult;

    [Space]
    public float SubtractingNum1 = 4.4f;
    public float SubtractingNum2 = 3.3f;
    [HideInInspector]
    public float SubtractingResult;

    [Space]
    public float MultiplyingNum1 = 2.5f;
    public float MultiplyingNum2 = 4.2f;
    [HideInInspector]
    public float MultiplyingResult;

    [Space]
    public float DividingNum1 = 1.8f;
    public float DividingNum2 = 1.5f;
    [HideInInspector]
    public float DividingResult;

    private void Start()
    {
        Summa();
        Subtracting();
        Multiplying();
        Dividing();
    }

    private void Summa()
    {
        SummaResult = SummaNum1 + SummaNum2;
        Debug.Log(SummaResult);
    }

    private void Subtracting()
    {
        SubtractingResult = SubtractingNum1 - SubtractingNum2;
        Debug.Log(SubtractingResult);
    }

    private void Multiplying()
    {
        MultiplyingResult = MultiplyingNum1 * MultiplyingNum2;
        Debug.Log(MultiplyingResult);
    }

    private void Dividing()
    {
        DividingResult = DividingNum1 / DividingNum2;
        Debug.Log(DividingResult);
    }
}