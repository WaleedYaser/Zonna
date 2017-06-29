using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Level01
{
    public class SafeBehaviour : MonoBehaviour
    {
        public GameObject lockedUI;

        public GameObject passwordPad;

        public bool locked;

        // Use this for initialization
        void Start()
        {
            lockedUI.SetActive(false);
            passwordPad.SetActive(false);
            locked = true;
        }

        public void OnSafeClick()
        {
            if (locked)
            {
                passwordPad.SetActive(true);
                passwordPad.transform.GetChild(0).gameObject.SetActive(true);
            }
            else
            {
                locked = false;
                GetComponent<Rigidbody>().AddForce(-10, 0, 0);
                GetComponent<BoxCollider>().enabled = false;
            }
        }

    }
}
