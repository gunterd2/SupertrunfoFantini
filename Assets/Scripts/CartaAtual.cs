using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class CartaAtual : MonoBehaviour 
{
	public int Jogador;

	public string id;
	public string nome;
	public int forca;
	public int velocidade;
	public int habilidade;
	public int equipamento;
	public int inteligencia;
	public Texture texturaCarta;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (texturaCarta != this.GetComponent<MeshRenderer>().material.mainTexture)
		{
			this.GetComponent<MeshRenderer>().material.mainTexture = texturaCarta;
		}
	
			
	
	}
}
