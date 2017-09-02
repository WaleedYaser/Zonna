using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level01
{
    public class MapBehaviour : MonoBehaviour
    {
        public PlayerColletions collections;

        public GameObject emptyCollectionsUI;

        [Header("Puzzles solved")]
        public bool EgyptPuzzle;
        public bool JapanPuzzle;
        public bool FrancePuzzle;
        public bool RussiaPuzzle;
        public bool USAPuzzle;
        public bool YemenPuzzle;

        [Header("Solution Pins")]
        public GameObject EgyptPin;
        public GameObject JapanPin;
        public GameObject RussiaPin;
        public GameObject FrancePin;
        public GameObject USAPin;
        public GameObject YemenPin;

        // Use this for initialization
        void Start()
        {
            emptyCollectionsUI.SetActive(false);
            _InitializePins();
        }

        private void _InitializePins()
        {
            EgyptPin.SetActive(false);
            JapanPin.SetActive(false);
            RussiaPin.SetActive(false);
            FrancePin.SetActive(false);
            USAPin.SetActive(false);
            YemenPin.SetActive(false);
        }

        public bool IsWon()
        {
            int c = 0;

            if (EgyptPuzzle)
                c++;
            if (JapanPuzzle)
                c++;
            if (RussiaPuzzle)
                c++;
            if (FrancePuzzle)
                c++;
            if (USAPuzzle)
                c++;
            if (YemenPuzzle)
                c++;

            if (c >= 5)
                return true;
            else
                return false;
        }

        public void OnMapClick()
        {
            bool haveCollections = collections.EgyptPuzzle
                                || collections.JapanPuzzle
                                || collections.RussiaPuzzle
                                || collections.FrancePuzzle
                                || collections.USAPuzzle
                                || collections.YemenPuzzle;

            if (IsWon())
            {
                gameObject.SetActive(false);
            }

            else if (haveCollections)
            {
                if (collections.EgyptPuzzle)
                {
                    EgyptPuzzle = true;
                    EgyptPin.SetActive(true);
                    collections.EgyptPuzzle = false;
                }
                if (collections.JapanPuzzle)
                {
                    JapanPuzzle = true;
                    JapanPin.SetActive(true);
                    collections.JapanPuzzle = false;
                }
                if (collections.RussiaPuzzle)
                {
                    RussiaPuzzle = true;
                    RussiaPin.SetActive(true);
                    collections.RussiaPuzzle = false;
                }
                if (collections.FrancePuzzle)
                {
                    FrancePuzzle = true;
                    FrancePin.SetActive(true);
                    collections.FrancePuzzle = false;
                }
                if (collections.USAPuzzle)
                {
                    USAPuzzle = true;
                    USAPin.SetActive(true);
                    collections.USAPuzzle = false;
                }
                if (collections.YemenPuzzle)
                {
                    YemenPuzzle = true;
                    YemenPin.SetActive(true);
                    collections.YemenPuzzle = false;
                }
            }

            else
            {
                emptyCollectionsUI.SetActive(true);
                StartCoroutine(DisableObjectAfter(emptyCollectionsUI, 2));
            }
        }

        IEnumerator DisableObjectAfter(GameObject item, float time)
        {
            yield return new WaitForSeconds(time);
            item.SetActive(false);
        }
    }
}
