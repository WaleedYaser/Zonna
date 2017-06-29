using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Level01
{
    public class PasswardButtonBehaviour : MonoBehaviour
    {
        public InputField entry;
        public string password;
        public SafeBehaviour safe;
        public GameObject unlockedUI;
        public GameObject lockedUI;
        public GameObject passwordPad;

        private void Start()
        {
            unlockedUI.SetActive(false);
            lockedUI.SetActive(false);
        }

        public void EnterNumber(string digit)
        {
            entry.text += digit;
        }

        public void C_Button()
        {
            if (entry.text != "")
            {
                entry.text = entry.text.ToString()
                                       .Substring(0, entry.text.Length - 1);
            }
        }

        public void Submit()
        {
            if (entry.text == password)
            {
                safe.locked = false;
                unlockedUI.SetActive(true);
                StartCoroutine(DeactivateUI());
                passwordPad.SetActive(false);  
            }
            else
            {
                entry.text = "";
                passwordPad.SetActive(false);
                StartCoroutine(DisablyUnlockedUI());
            }
        }

        IEnumerator DeactivateUI()
        {
            yield return new WaitForSeconds(2);
            unlockedUI.SetActive(false);
        }

        IEnumerator DisablyUnlockedUI()
        {
            lockedUI.SetActive(true);
            yield return new WaitForSeconds(2);
            lockedUI.SetActive(false);
        }


    }
}
