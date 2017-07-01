using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level01
{
    public class BlockBehaviour : MonoBehaviour
    {

        private Rigidbody _blockRigidBody;
        private bool _flag = true;
        private GvrAudioSource _audioSource;

        // Use this for initialization
        void Start()
        {
            _blockRigidBody = GetComponent<Rigidbody>();
            _audioSource = GetComponent<GvrAudioSource>();
        }


        public void OnBuzzleClick()
        {
            if (_flag)
                _blockRigidBody.velocity = new Vector3(1, 1, 1);
            else
                _blockRigidBody.velocity = new Vector3(-1, -1, -1);
            _flag = !_flag;
            _audioSource.Play();
        }
    }
}