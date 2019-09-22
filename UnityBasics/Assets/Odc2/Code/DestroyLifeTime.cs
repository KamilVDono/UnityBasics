using UnityEngine;

namespace Odc2
{
	public class DestroyLifeTime : MonoBehaviour
	{
		private GameObject _gameObject;

		void Awake()
		{
			_gameObject = new GameObject( "Test" );
			//Destroy( _gameObject );
			DestroyImmediate( _gameObject );
			CheckIfDestroyed();
		}

		void Start()
		{
			CheckIfDestroyed();
		}


		void Update()
		{
			//Destroy( _gameObject );
			//DestroyImmediate( _gameObject );
			CheckIfDestroyed();
		}
		
		// Sprawdza czy GameObject jest null'em
		void CheckIfDestroyed()
		{
			Debug.Log( _gameObject == null ? $"{Time.frameCount} Jest null" : $"{Time.frameCount} Nie jest null" );

			if ( ( gameObject ?? null ) == null )
			{
				Debug.Log( "Jest null bez Unity check" );
			}
			else
			{
				Debug.Log( "Nie jest null bez Unity check" );
			}
		}
	}
}

