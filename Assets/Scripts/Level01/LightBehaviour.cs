using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level01
{
    public class LightBehaviour : MonoBehaviour
    {

        public GameObject roomLight;
        public GameObject puzzleLight;
        public GameObject SwitchButton;

        private bool _switchOn = true;
        private GvrAudioSource _audioSource;

        void Start()
        {
            _audioSource = GetComponent<GvrAudioSource>();
            puzzleLight.SetActive(false);
            roomLight.SetActive(true);
        }

        public void OnSwitchClick()
        {
            _AnimateSwitch();
            _switchOn = !_switchOn;
            roomLight.SetActive(_switchOn);
            puzzleLight.SetActive(!_switchOn);
            if (_switchOn)
            {
                RenderSettings.ambientIntensity = 1f;
            }
            else
            {
                RenderSettings.ambientIntensity = 0.3f;

            }
            _audioSource.Play();
        }

        private void _AnimateSwitch()
        {
            if (_switchOn)
            {
                SwitchButton.transform.rotation.Set(0f, 0f, -7, 1f);
            }
            else
            {
                SwitchButton.transform.rotation.Set(0f, 0f, 0, 1f);
            }
        }
    }
}
