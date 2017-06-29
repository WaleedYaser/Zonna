using UnityEngine;
using System.Collections;

namespace Level01
{
    public class TvBehaviour : MonoBehaviour
    {

        public GameObject JoyStick;
        public GameObject germanyPuzzle;
        private GifBehaviour _gifComponent;
        private GvrAudioSource _audioSource;
        private MeshRenderer _meshRenderer;


        // Use this for initialization
        void Start()
        {
            germanyPuzzle.SetActive(false);
            _gifComponent = GetComponent<GifBehaviour>();
            _audioSource = GetComponent<GvrAudioSource>();
            _meshRenderer = GetComponent<MeshRenderer>();
            _meshRenderer.material.color = Color.black;
        }

        public void OnTvClick()
        {
            if (_gifComponent.enabled == false)
            {
                JoyStick.SetActive(false);
                _gifComponent.enabled = true;
                _meshRenderer.material.color = Color.white;
                _audioSource.Play();
                germanyPuzzle.SetActive(true);
            }
            else
            {
                JoyStick.SetActive(true);
                _gifComponent.enabled = false;
                _audioSource.Stop();
                _meshRenderer.material.color = Color.black;
                germanyPuzzle.SetActive(false);
            }

        }
    }
}
