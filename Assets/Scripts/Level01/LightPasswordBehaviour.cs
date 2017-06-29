using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPasswordBehaviour : MonoBehaviour {

    public GameObject[] lights;
    public string password;
    private int[] _keys;

	// Use this for initialization
	void Start () {
        
        _keys = new int[password.Length];
        foreach (var light in lights)
        {
            light.SetActive(false);
        }

        int i = 0;
        foreach (var key in password)
        {
            _keys[i] = int.Parse(key.ToString());
            i++;
        }
        StartCoroutine(LightsDancing());
	}
	
	IEnumerator LightsDancing()
    {
        while (true)
        {
            foreach (var key in _keys)
            {
                lights[key].SetActive(true);
                yield return new WaitForSeconds(1f);
                lights[key].SetActive(false);
                yield return new WaitForSeconds(0.5f);
            }
            yield return new WaitForSeconds(2f);
        }
    }
}
