using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ItemController : MonoBehaviour
{
    public int amount = 5;                             //기본 값 설정

    Sequence sequence;
    
    public enum ITEMTYPE : int                          //enum 값으로 아이템 Type을 설정
    {
        HP_ITEM,
        EXP_ITEM
    }

    public ITEMTYPE itemtype = ITEMTYPE.HP_ITEM;        //기본적으로 HP 아이템으로 선언

    public void Start()
    {
        sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveY(0.1f, -13));
        sequence.Join(transform.DORotate(new Vector3(0, 100, 0), 1));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }

    public void OnDestroy()
    {
        sequence.Kill();
    }
}