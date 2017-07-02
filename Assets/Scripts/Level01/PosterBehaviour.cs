using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level01
{
    public class PosterBehaviour : MonoBehaviour
    {
        public Transform dropTransform;

        public void OnPosterClick()
        {
            transform.rotation = dropTransform.rotation;
            transform.position = dropTransform.position;
            GetComponent<MeshCollider>().enabled = false;
        }

    }
}
