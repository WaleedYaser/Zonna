using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MainMenuLevel
{
    public class LoadLevelAsyncBehaviour : MonoBehaviour
    {
        public string sceneName;
        public Text[] loadingTexts;
        public Transform[] progressbars;

        // Use this for initialization
        void Start()
        {
            StartCoroutine(AsynchronousLoad(sceneName));
        }

        IEnumerator AsynchronousLoad(string scene)
        {
            yield return new WaitForSeconds(0.1f) ;

            AsyncOperation ao = SceneManager.LoadSceneAsync(scene);
            ao.allowSceneActivation = false;

            while (!ao.isDone)
            {
                // [0, 0.9] > [0, 1]
                float progress = Mathf.Clamp01(ao.progress / 0.9f);

                foreach (var bar in progressbars)
                {
                    bar.localScale = new Vector3(progress,
                                                 bar.transform.localScale.y,
                                                 bar.transform.localScale.z);
                }

                // Loading completed
                if (ao.progress == 0.9f)
                {
                    foreach (var text in loadingTexts)
                    {
                        text.text = "Press any key to start...";
                    }
                    
                    if (Input.anyKey)
                        ao.allowSceneActivation = true;
                }

                yield return null;
            }
        }
    }
}
