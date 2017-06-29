using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level01
{
    public class RandomAppearanceBehaviour : MonoBehaviour
    {

        public float minRandomAppear;
        public float maxRandomAppear;
        public float minRandomDisappear;
        public float maxRandomDisappear;

        public GameObject toBeRandomized;

        private float _randomTime;
        private bool _flag = true;

        // Update is called once per frame
        void Update()
        {
            if (_flag)
            {
                _flag = false;
                StartCoroutine(ToggleObject());
            }
        }

        IEnumerator ToggleObject()
        {
            _randomTime = Random.Range(minRandomDisappear, maxRandomDisappear);
            toBeRandomized.SetActive(false);
            yield return new WaitForSeconds(_randomTime);

            _randomTime = Random.Range(minRandomAppear, maxRandomAppear);
            toBeRandomized.SetActive(true);
            yield return new WaitForSeconds(_randomTime);

            _flag = true;
        }
    }
}
