using UnityEngine;
using System.Collections;
using UnityEngine.Video;

namespace Level01
{
    public class TvBehaviour : MonoBehaviour
    {

        public GameObject JoyStick;
        public GameObject RussiaPuzzle;
        private VideoPlayer _videoPlayer;
        private MeshRenderer _meshRenderer;

        // Use this for initialization
        void Start()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
            _videoPlayer = GetComponent<VideoPlayer>();
            RussiaPuzzle.SetActive(false);
            _videoPlayer.enabled = false;
            _meshRenderer.enabled = false;
        }

        public void OnTvClick()
        {
            if (_videoPlayer.enabled == false)
            {
                _videoPlayer.enabled = true;
                JoyStick.SetActive(false);
                RussiaPuzzle.SetActive(true);
                _meshRenderer.enabled = true;
            }
            else
            {
                JoyStick.SetActive(true);
                _videoPlayer.enabled = false;
                RussiaPuzzle.SetActive(false);
                _meshRenderer.enabled = false;
            }

        }
    }
}
