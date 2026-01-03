using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StandPoint : MonoBehaviour
{
    public enum PointNo{
        Point1,
        Point2,
        Point3,
        Point4
    }

    public PointNo _pointNo;

    LevelManager _levelManager;
    void Start(){
        _levelManager = LevelManager.Instance;
    }

    void Update(){
        updateTimer();
    }

    float _timer;
    float _waitTime = 0.2f;
    void updateTimer(){
        if(!(_isStandPointActive && _isStandingInside)){
            return;
        }

        _timer += Time.deltaTime;
        if(_timer > _waitTime){
            _timer = 0;
            notifyManager();
        }
    }

    public virtual void notifyManager(){
        _levelManager.standPointTriggered(_pointNo);
    }

    public bool _isStandPointActive{get;private set;} = false;
    bool _isStandingInside = false;

    void OnTriggerEnter(Collider other) {
        if(other.transform.tag == "Player"){
            _isStandingInside = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.transform.tag == "Player"){
            _isStandingInside = false;
        }
    }
}
