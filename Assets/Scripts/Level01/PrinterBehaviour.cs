using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level01
{
    public class PrinterBehaviour : MonoBehaviour
    {

        public GameObject paper;
        private GvrAudioSource _printer_Audio;

        // Use this for initialization
        void Start()
        {
            _printer_Audio = GetComponent<GvrAudioSource>();
            paper.SetActive(false);
        }

        public void OnPrinterClick()
        {
            _printer_Audio.Play();
            GetComponent<BoxCollider>().enabled = false;
            StartCoroutine(_DoAfterPrint());
        }

        IEnumerator _DoAfterPrint()
        {
            yield return new WaitUntil(() => !_printer_Audio.isPlaying);
            paper.SetActive(true);
        }
    }
}
