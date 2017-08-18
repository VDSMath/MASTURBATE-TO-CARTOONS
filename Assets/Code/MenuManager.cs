using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

	[SerializeField] private List<SOHousePart> _houseParts;
	private int _actualHousePart;

	private Color _color;
	private string _headerTitle;

	private Image _background;
	private Text _header;
	
	private GameObject _uiObjPrefab;

	private void Start(){
		_background = GameObject.Find("BACKGROUND").GetComponent<Image>();
		_header = GameObject.Find("TITLE").GetComponent<Text>();

		NewHousePart(_actualHousePart);
	}
	private void NewHousePart(int i){
		_color = _houseParts[i].backgroundColor;
		_headerTitle = _houseParts[i].headerTitle;
		SetStagedHousePartProperties();
	}
	private void SetStagedHousePartProperties(){
		_background.color = _color;
		_header.text = _headerTitle;
		_uiObjPrefab = Instantiate(_houseParts[_actualHousePart].uiObjectsPrefab,Vector3.zero,Quaternion.identity,transform);
		_uiObjPrefab.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
	}
	public void ChangeToRight(){
		Destroy(_uiObjPrefab.gameObject);
		_actualHousePart++;
		if(_actualHousePart >= _houseParts.Count){
			_actualHousePart = 0;
		}
		NewHousePart(_actualHousePart);
	}
	public void ChangeToLeft(){
		Destroy(_uiObjPrefab.gameObject);
		_actualHousePart--;
		if(_actualHousePart < 0){
			_actualHousePart = _houseParts.Count - 1;
		}
		NewHousePart(_actualHousePart);
	}
}
