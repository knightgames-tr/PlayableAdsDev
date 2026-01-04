using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    LevelManager _levelManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void toggleNavmeshAgent(bool toggle){

    }

    int _currentQueueNo = -1;
    int _currentLineNo = -1;
    public void moveToPosition(Vector3 targetPosition, int queueNo, int lineNo){
        toggleNavmeshAgent(true);
        
        _currentQueueNo = queueNo;
        _currentLineNo = lineNo;
    }

    public void reachedQueuePosition(){
        _levelManager.reachedQueuePosition(_currentQueueNo, _currentLineNo, this);
    }
    public void reachedQueuePosition(int queueNo){
        _levelManager.reachedQueuePosition(queueNo, _currentLineNo, this);
    }
}
