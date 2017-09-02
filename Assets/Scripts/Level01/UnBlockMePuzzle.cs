using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level01
{
    public class UnBlockMePuzzle : MonoBehaviour
    {
        public Rigidbody[] blocks_rigidbodies;
        public Transform explotion_position;
        public GameObject puzzle_Japan;

        // Use this for initialization
        void Start()
        {
            puzzle_Japan.SetActive(false);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Win_Piece")
            {
                foreach (var block in blocks_rigidbodies)
                {
                    block.useGravity = true;
                    block.constraints = RigidbodyConstraints.None;
                    block.AddExplosionForce(500f, explotion_position.position, 5f, 3f);
                    Destroy(block.GetComponent<BlockBehaviour>());
                }

                puzzle_Japan.SetActive(true);
            }
        }

    }
}
