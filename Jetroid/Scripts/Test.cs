using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public IEnumerator waitFiveSeconds()
    {
        Debug.Log("Hello there");

        yield return new WaitForSeconds(5.0f);

        Debug.Log(". 5 seconds passed");
    }
}
