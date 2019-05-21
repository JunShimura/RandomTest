using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;


public class RandomTestScript
{

    [Test]
    public void RandomTestScriptSimplePasses()
    {
        // Use the Assert class to test conditions.
        // https://docs.unity3d.com/ja/current/ScriptReference/Random.Range.html

        int resultInt = 0;
        int resultFloat = 0;
        float floatR = 0;
        int intR = 0;
        float time = Time.realtimeSinceStartup;
        for (int i = 0; i < 1000000000; i++)
        {
            floatR = Random.Range(0.0f, 100.0f);
            if (floatR < 20.0f)
            {
                resultFloat++;
            }
        }
        Debug.Log( "処理時間:"+(Time.realtimeSinceStartup - time));
        Debug.Log(resultFloat);
        time = Time.realtimeSinceStartup;
        for (int i = 0; i < 1000000000; i++)
        {
            intR = Random.Range(0, 10);
            if (intR < 2)
            {
                resultInt++;
            }
        }
        Debug.Log("処理時間:" + (Time.realtimeSinceStartup - time));
        Debug.Log(resultInt);
    }

}
