using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level01
{
    public class CuboardBehaviour : MonoBehaviour
    {
        public GameObject lockedUI;
        public GameObject france_Puzzle;
        public bool locked;

        // Use this for initialization
        void Start()
        {
            france_Puzzle.SetActive(false);
            lockedUI.SetActive(false);
            locked = true;
        }

        public void OnCuboardClick()
        {
            if (locked)
            {
                lockedUI.SetActive(true);
                StartCoroutine(DisableAfter());
            }
            else
            {
                locked = false;
                GetComponent<Rigidbody>().AddForce(50, 0, 0);
                GetComponent<BoxCollider>().enabled = false;
                france_Puzzle.SetActive(true);
            }

        }

        IEnumerator DisableAfter()
        {
            yield return new WaitForSeconds(2f);
            lockedUI.SetActive(false);
        }
    }
}
