using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level01
{
    public class LightGlowBehaviour : MonoBehaviour
    {

        public float minIntensity;
        public float maxIntensity;
        public float speed;

        private Light _lightComponent;
        private float _t = 0;
        private bool _increase = true;
        // Use this for initialization
        void Start()
        {
            _lightComponent = GetComponent<Light>();
        }

        // Update is called once per frame
        void Update()
        {
            _t += Time.deltaTime * speed;

            if (_increase)
                _lightComponent.intensity = Mathf.Lerp(minIntensity, maxIntensity, _t);
            else
                _lightComponent.intensity = Mathf.Lerp(maxIntensity, minIntensity, _t);

            if (_lightComponent.intensity == maxIntensity)
                _increase = false;
            if (_lightComponent.intensity == minIntensity)
                _increase = true;

            if (_t > 1)
            {
                _t = 0;
            }
        }
    }
}
