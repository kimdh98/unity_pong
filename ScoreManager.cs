using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoreManager : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreEvent;
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        BallController ball = collision.gameObject.GetComponent<BallController>();
        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreEvent.Invoke(eventData);
        }
    }
}
