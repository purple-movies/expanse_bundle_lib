using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System;
using UnityEngine.Events;

public class OnClickInvoker : MonoBehaviour
{
    [Serializable] public class TriggerEvent : UnityEvent<BaseEventData>
    { }

    [Serializable] public class Entry
    {
        public EventTriggerType eventID = EventTriggerType.PointerClick;
        public TriggerEvent callback = new TriggerEvent();
    }

    [SerializeField] private List<Entry> m_Delegates;

    protected OnClickInvoker()
    { }

    public List<Entry> triggers
    {
        get
        {
            if (m_Delegates == null)
                m_Delegates = new List<Entry>();
            return m_Delegates;
        }
        set { m_Delegates = value; }
    }

    public virtual void OnPointerEnter(PointerEventData eventData)
    {
        Execute(EventTriggerType.PointerEnter, eventData);
    }

    public virtual void OnPointerExit(PointerEventData eventData)
    {
        Execute(EventTriggerType.PointerExit, eventData);
    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        Execute(EventTriggerType.PointerDown, eventData);
    }

    public virtual void OnPointerUp(PointerEventData eventData)
    {
        Execute(EventTriggerType.PointerUp, eventData);
    }

    public virtual void OnPointerClick(PointerEventData eventData)
    {
        Execute(EventTriggerType.PointerClick, eventData);
    }

    void OnMouseDown()
    {
        OnPointerDown(null);
    }

    private void Execute(EventTriggerType id, BaseEventData eventData)
    {
        for (int i = 0, imax = triggers.Count; i < imax; ++i)
        {
            var ent = triggers[i];
            if (ent.eventID == id && ent.callback != null)
                ent.callback.Invoke(eventData);
        }
    }
}
