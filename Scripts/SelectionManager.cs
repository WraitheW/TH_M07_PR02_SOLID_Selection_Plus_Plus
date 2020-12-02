﻿using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";

    private ISelector _selector;
    private IRayProvider _rayProvider;
    private ISelectionResponse _selectionResponse;

    private Transform _currentselection;
    private Transform _selection;

    private void Awake()
    {
        _rayProvider = GetComponent<IRayProvider>();
        _selector = GetComponent<ISelector>();
        _selectionResponse = GetComponent<ISelectionResponse>();
    }

    private void Update()
    {
        if (_currentselection != null)
        {
            _selectionResponse.OnDeselect(_currentselection);
        }

        _selector.Check(_rayProvider.CreateRay());

        _currentselection = _selector.GetSelection();

        if (_currentselection != null)
        {
            _selectionResponse.OnSelect(_currentselection);
        }
    }
}