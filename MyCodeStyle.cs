using System;
using UnityEngine;

public class MyCodeStyle : MonoBehaviour
 {
    // Constants: UpperCase SnakeCase
    public const int CONTSTANT_FIELD = 56;

    // Properties: PascalCase
    public static MyCodeStyle Instance { get; private set; }

    // Events: PascalCase
    public event EventHandler OnSomethingHappened;

    // Fields: camelCase
    private float memberVariable;

    // Function Names: PascalCase
    private void awake()
    {
        Instance = this;

        DoSomething(10f);
    }

    // Function Params: _camelCase
    private void DoSomething(float _time)
    {
        // Do something...
        memberVariable = _time + Time.deltaTime;
        if (memberVariable > 0)
        {
            // Do something else
        }
    }
}