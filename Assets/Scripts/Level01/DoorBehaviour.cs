using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level01
{
    public class DoorBehaviour : MonoBehaviour
    {
        public string sceneName;

        public void OnDoorClick()
        {
            transform.Rotate(new Vector3(0, 30, 0));
            GetComponent<BoxCollider>().enabled = false;
            StartCoroutine(_LoadSceneAfter());
        }

        IEnumerator _LoadSceneAfter()
        {
            yield return new WaitForSeconds(2f);
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}
