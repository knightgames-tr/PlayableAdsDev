using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ActionPoint : StandPoint
{
    public Transform _pointMesh;
    public Renderer _pointMaterial;

    public override void togglePoint(bool value)
    {
        base.togglePoint(value);
        if(value){
            highLightActionPoint();
        }else{
            dehighLightActionPoint();
        }
    }

    float _highLightTime = 1f;
    float _highLightAmount = 0.03f;
    public void highLightActionPoint(){
        _pointMesh.DOScale(_pointMesh.localScale+_highLightAmount*Vector3.one,_highLightTime);
        _pointMaterial.material.DOColor(Color.green,_highLightTime);
    }

    public void dehighLightActionPoint(){
        _pointMesh.DOScale(_pointMesh.localScale-_highLightAmount*Vector3.one,_highLightTime);
        _pointMaterial.material.DOColor(Color.white,_highLightTime);
    }
}
