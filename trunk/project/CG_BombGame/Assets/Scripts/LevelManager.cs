using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	private static LevelManager _instance = null;

	public static LevelManager instance {
		get {
			if(!_instance) {

				_instance = GameObject.FindObjectOfType(typeof(LevelManager)) as LevelManager;
				if(!instance) {
					GameObject container = new GameObject();
					container.name = "LevelManager";
					_instance = container.AddComponent<LevelManager>();
				}
			}

			return _instance;
		}
	}
}
