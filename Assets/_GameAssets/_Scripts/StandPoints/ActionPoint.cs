using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ActionPoint : StandPoint
{
    public Transform _pointMesh;
    public Renderer _pointMaterial;

    float _highLightTime = 1f;
    float _highLightAmount = 0.03f;

    [ContextMenu("highlight")]
    public void highLightActionPoint(){
        _pointMesh.DOScale(_pointMesh.localScale+_highLightAmount*Vector3.one,_highLightTime);
        _pointMaterial.material.DOColor(Color.green,_highLightTime);
    }

    [ContextMenu("dehighlight")]
    public void dehighLightActionPoint(){
        _pointMesh.DOScale(_pointMesh.localScale-_highLightAmount*Vector3.one,_highLightTime);
        _pointMaterial.material.DOColor(Color.white,_highLightTime);
    }
}
