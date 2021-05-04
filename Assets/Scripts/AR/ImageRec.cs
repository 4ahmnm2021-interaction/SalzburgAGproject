using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ImageRec : MonoBehaviour
{
    private ARTrackedImageManager manager;

    void Awake()
    {
        manager = FindObjectOfType<ARTrackedImageManager>();
    }

    void OnEnable()
    {
        manager.trackedImagesChanged += OnImageChange;
    }

    void OnDisable()
    {
        manager.trackedImagesChanged -= OnImageChange;
    }

    public void OnImageChange(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
        }
    }
}
