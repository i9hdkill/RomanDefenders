﻿using UnityEngine;
using UnityEngine.UI;

public class BuildingTooltip : Menu {

    [SerializeField]
    private Text title;
    [SerializeField]
    private Text description;
    [SerializeField]
    private Image sprite;
    [SerializeField]
    private Text amount;
    [SerializeField]
    private Canvas canvas;


    public void SetTooltip(string title, string description, int amount, Vector3 position) {
        this.title.text = title;
        this.description.text = description;
        sprite.sprite = Manager.Instance.ManaSprite;
        sprite.preserveAspect = true;
        this.amount.text = amount.ToString();
        Vector3 newPos = new Vector3(position.x - (325 * canvas.scaleFactor), position.y, position.z);
        transform.position = newPos;
        Show();
    }

}
