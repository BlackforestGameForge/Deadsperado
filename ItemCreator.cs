using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="new Item",menuName ="Item")]
public class ItemCreator : ScriptableObject {


    public new string name;
    public string description;

    public Sprite art;

    public int damage;
    public int firerate;
    public string type;


	// Use this for initialization
	void Start () {
        
		
	}
	
}
