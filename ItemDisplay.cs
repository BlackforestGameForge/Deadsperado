using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour {

    public ItemCreator item;

    public Text nameText;
    public Text descriptionText;

    public Image displaySprite;
    public Text type;
    public Text damage;
    public Text firerate;
    

	// Use this for initialization
	void Start () {
        nameText.text = item.name;
        displaySprite.sprite = item.art;
        descriptionText.text = item.description;
        damage.text = item.damage.ToString();
        firerate.text = item.firerate.ToString();
        type.text = item.type.ToString();
        
	}
	
	
}
