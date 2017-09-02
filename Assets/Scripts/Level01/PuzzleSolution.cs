using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level01
{
    public class PuzzleSolution : MonoBehaviour
    {
        public PlayerColletions collections;
        public GameObject onClickUI;
        public GameObject onEnterUI;

        public enum Countries
        {
            Egypt,
            Russia,
            France,
            Japan,
            USA,
            Yemen
        };
        public Countries country;

        private void Start()
        {
            onClickUI.SetActive(false);
        }

        public void OnSolutionClick()
        {
            _AddCountry();
            gameObject.SetActive(false);
            GameObject.Destroy(onEnterUI);
            onClickUI.SetActive(true);
            GameObject.Destroy(onClickUI, 3);
        }

        private void _AddCountry()
        {
            switch (country)
            {
                case Countries.Egypt:
                    collections.EgyptPuzzle = true;
                    break;
                case Countries.France:
                    collections.FrancePuzzle = true;
                    break;
                case Countries.Russia:
                    collections.RussiaPuzzle = true;
                    break;
                case Countries.Japan:
                    collections.JapanPuzzle = true;
                    break;
                case Countries.USA:
                    collections.USAPuzzle = true;
                    break;
                case Countries.Yemen:
                    collections.YemenPuzzle = true;
                    break;
            }
        }

    }
}
