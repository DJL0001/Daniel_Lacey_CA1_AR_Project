using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class TrackedImages : MonoBehaviour
{
        [SerializeField] private GameObject enemyshiptestPrefab;
        [SerializeField] private Vector3 prefabOffset;

        private GameObject enemyshiptest;
        private ARTrackedImageManager ARTrackedImageManager;

        private void onEnable()
    {
            ARTrackedImageManager = gameObject.GetComponent<ARTrackedImageManager>();

            ARTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }
        
        private void OnImageChanged(ARTrackedImagesChangedEventArgs fbx)
    {
            foreach (ARTrackedImage image in fbx.added)
        {
                enemyshiptest = Instantiate(enemyshiptestPrefab, image.transform);
                enemyshiptest.transform.position += prefabOffset;
        }
    }
}


