using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level01
{
    public class PasswordPadBehaviour : MonoBehaviour
    {

        public float displayTime;
        private float _timer = 0;
        private bool _flag;

        private void Update()
        {
            if (_flag)
            {
                _timer += Time.deltaTime;
                if (_timer > displayTime)
                {
                    _Decativate();
                    _timer = 0;
                }
            }

        }
        public void OnPointerExit()
        {
            _flag = true;
        }

        public void OnPointerEnter()
        {
            _flag = false;
            _timer = 0;
        }

        private void _Decativate()
        {
            gameObject.SetActive(false);
        }

    }
}
