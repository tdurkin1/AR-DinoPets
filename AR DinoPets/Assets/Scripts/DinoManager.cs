using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DinoManager : MonoBehaviour
{
    [SerializeField] MakeAppearOnPlane dinoPlacer;
    [SerializeField] Transform triceratopsPen;
    [SerializeField] Transform velociraptorPen;

    

    public void PlaceTriceratops()
    {
        dinoPlacer.content = triceratopsPen;
    }

    public void PlaceVelociraptor()
    {
        dinoPlacer.content = triceratopsPen;
    }
}


