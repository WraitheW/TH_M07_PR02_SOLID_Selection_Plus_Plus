using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorSelectionResponse : MonoBehaviour, ISelectionResponse
{
    [SerializeField] public GameObject indicatorPrefab;
    
    void Start()
    {
        indicatorPrefab = Instantiate(indicatorPrefab);
        indicatorPrefab.SetActive(false);
    }
    public void OnDeselect(Transform selection)
    {
        indicatorPrefab.SetActive(false);
    }

    public void OnSelect(Transform selection)
    {
        if (indicatorPrefab.activeSelf == false)
        {
            var yHeight = selection.localScale.y;
            indicatorPrefab.SetActive(true);
            indicatorPrefab.GetComponent<Rotate>().RotateCube();
            var selectionTransform = selection.GetComponent<Transform>();
            var pos = selectionTransform.position + (new Vector3(0, yHeight, 0) * (float)1.75);
            indicatorPrefab.GetComponent<Transform>().position = pos;
        }

        
    }
}
