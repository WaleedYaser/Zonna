using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level01
{
    public class LightLampBehaviour : MonoBehaviour
    {
        public int _toggle = 0;
        private float _timer = 0;
        private bool _isCount = false;
        private GvrAudioSource _lamp_sound;

        public GameObject lamp;
        public int solution;
        public int mytime;
        public CuboardBehaviour cuboardBehaviour;
        public GvrAudioSource cuboardOpenSound;

        void Start()
        {
            lamp.SetActive(false);
            _lamp_sound = GetComponent<GvrAudioSource>();
        }

        void Update()
        {
            if (_isCount)
            {
                _timer += Time.deltaTime;
            }

            if (_timer >= mytime && _toggle != 0)
            {
                CheckSolution();
                _isCount = false;
            }
        }


        public void CheckSolution()
        {
            if (_toggle == solution)
            {
                lamp.SetActive(true);
                foreach (Transform light in lamp.transform)
                {
                    light.gameObject.GetComponent<Light>().color = Color.green;
                }
                cuboardBehaviour.locked = false;
                cuboardOpenSound.Play();
            }

            else
            {
                lamp.SetActive(true);
                foreach (Transform light in lamp.transform)
                {
                    light.gameObject.GetComponent<Light>().color = Color.red;
                }
            }

            _timer = 0;
            _toggle = 0;
        }

        public void LightToggle()
        {
            foreach (Transform light in lamp.transform)
            {
                light.gameObject.GetComponent<Light>().color = new Color32(246, 255, 204, 255);
            }
            if (!lamp.activeInHierarchy)
            {
                lamp.SetActive(true);
                _toggle++;
            }

            else
            {
                lamp.SetActive(false);
            }
            _timer = 0;
        }

        public void OnLampClick()
        {
            if (_timer < mytime || _toggle == 0)
                LightToggle();

            _isCount = true;

            _lamp_sound.Play();
        }
    }
}
