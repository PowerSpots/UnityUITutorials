using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FlexibleUI : MonoBehaviour
{
    public FlexibleUIData skinData;

    protected virtual void OnSkinUI()
    {

    }

    protected virtual void Awake()
    {
        this.OnSkinUI();
    }

    protected virtual void Update()
    {
        if (Application.isEditor)
        {
            this.OnSkinUI();
        }
    }

}