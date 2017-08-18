using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlAtributes : MonoBehaviour {

	[Header("Atributes")]
	[SerializeField] private float _energy;
	[SerializeField] private float _humor;
	[SerializeField] private float _money;

	[Header("Taxes")]
	[SerializeField] private float _energyLoseTax;
	[SerializeField] private float _humorLoseTax;
	[SerializeField] private float _energyGainTax;
	[SerializeField] private float _humorGainTax;

	[Header("Panel")]
	[SerializeField] private GameObject _atributePanel;
	
	public void LoseEnergy(){
		_energy -= _energyLoseTax;
	}
	private void LoseHumor(){
		_humor -= _humorLoseTax;
	}
	public void LoseMoney(float price){
		_money -= price;
	}
	public void GainEnergy(){
		_energy -= _energyGainTax;
	}
	public void GainHumor(){
		_humor -= _humorGainTax;
	}
	public void GainMoney(float price){
		_money += price;
	}
}
