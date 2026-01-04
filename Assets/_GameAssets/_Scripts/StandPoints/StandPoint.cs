using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using MyBox;

public class StandPoint : MonoBehaviour
{

    public int _pointNo;
    [Separator]
    
    protected GameManager _gameManager;
    protected LevelManager _levelManager;
    public virtual void Start(){
        _gameManager = GameManager.Instance;
        _levelManager = LevelManager.Instance;
    }

    protected bool _isStandPointActive{get;private set;} = false;
    public void togglePoint(bool value){
        _isStandPointActive = value;
    }

    protected bool _isStanding;
    public bool getIsStanding(){
        return _isStanding;
    }
    

    void OnTriggerEnter(Collider other) {
        if(other.transform.tag == "Player"){
            if(!_isStandPointActive){
                return;
            }
            _isStanding = true;
            _levelManager.onStandPoint(_pointNo);
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.transform.tag == "Player"){
            if(!_isStandPointActive){
                return;
            }
            _isStanding = false;
            _levelManager.offStandPoint(_pointNo);
        }
    }
}
