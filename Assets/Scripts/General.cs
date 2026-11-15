


using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public static class General
{
    



    public static IEnumerator DelayFunction(Action function, float time)
    {
        yield return new WaitForSeconds(time);

        function.Invoke();
    }
}
