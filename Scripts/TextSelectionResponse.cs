using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSelectionResponse : MonoBehaviour, ISelectionResponse
{
    [SerializeField] public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = Instantiate(canvas);
        canvas.enabled = false;
    }

    void ISelectionResponse.OnDeselect(Transform selection)
    {
        canvas.enabled = false;
    }

    void ISelectionResponse.OnSelect(Transform selection)
    {
        canvas.enabled = true;
        var selectionTransform = selection.GetComponent<Transform>();
        var pos = selectionTransform.position + (new Vector3(0, 1, 0) * (float)1.5);
        canvas.GetComponent<Transform>().position = pos;
    }
}
