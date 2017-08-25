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

        // Use this for initialization
        void Start()
        {
            _videoPlayer = GetComponent<VideoPlayer>();
            RussiaPuzzle.SetActive(false);
            _videoPlayer.enabled = false;
        }

        public void OnTvClick()
        {
            if (_videoPlayer.enabled == false)
            {
                _videoPlayer.enabled = true;
                JoyStick.SetActive(false);
                RussiaPuzzle.SetActive(true);
            }
            else
            {
                JoyStick.SetActive(true);
                _videoPlayer.enabled = false;
                RussiaPuzzle.SetActive(false);
            }

        }
    }
}
