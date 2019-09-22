using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc1
{
	public class Instantiate3 : MonoBehaviour
	{
		[SF] private GameObject[] _prefabs;
		[SF] private Transform _prefabsParent;

		void Start()
		{
			// przechodzimy przez wszystkie elementy w tablicy
			foreach ( var prefab in _prefabs ) 
			{
				//Instantiate( prefab ); // Sposób gdzie mamy bałagan w hierarchii
				Instantiate( prefab, _prefabsParent ); // A tu już jest porządek :)
			}
		}
	}
}
