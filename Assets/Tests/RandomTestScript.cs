using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;


public class RandomTestScript {

    [Test]
    public void RandomTestScriptSimplePasses() {
        // Use the Assert class to test conditions.
        // https://docs.unity3d.com/ja/current/ScriptReference/Random.Range.html

        int resultInt=0;
        int resultFloat=0;
        float floatR = 0;
        int intR = 0;

        for (int i = 0; i < 1000000000; i++)
        {
            floatR = Random.Range(0.0f, 100.0f);
            if (floatR < 20.0f)
            {
                resultFloat++;
            }
            intR= Random.Range(0, 10);
            if (intR < 2)
            {
                resultInt++;
            }
        }
        Debug.Log(resultFloat);
        Debug.Log(resultInt);
    }

}
