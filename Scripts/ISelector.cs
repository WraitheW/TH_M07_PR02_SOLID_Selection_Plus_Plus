using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface ISelector
{
    void Check(Ray ray);
    Transform GetSelection();
}
