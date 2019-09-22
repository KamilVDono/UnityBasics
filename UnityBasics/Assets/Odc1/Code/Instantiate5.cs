using System.Collections;
using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc1
{
	public class Instantiate5 : MonoBehaviour
	{
		[SF] private GameObject _prefab;
		[SF] private Vector2Int _gridSize;
		[SF] private Vector2 _gridSpacing;
		[SF] private float _zPosition;

		void Start()
		{
			// Stworzenie rodzica dla elementów grid'u, aby zachować porządek w hierarchii
			Transform gridParentTransform = new GameObject("GridParent").transform;
			//gridParentTransform.position = new Vector3( 150, 15, 15 );

			// Wyznaczamy pierwszą pozycję na osi X
			float startX;
			if ( IsEven( _gridSize.x ) )
			{
				startX = ( _gridSize.x - 1f ) / 2f * _gridSpacing.x;
			}
			else
			{
				startX = _gridSize.x / 2 * _gridSpacing.x;
			}
			startX = -startX; // Chcemy od prawej do lewej (jest to umowne i zależne od rotacji kamery)

			// Wyznaczamy pierwszą pozycję na osi X
			float startY;
			if ( IsEven( _gridSize.y ) )
			{
				startY = ( _gridSize.y - 1f ) / 2f * _gridSpacing.y;
			}
			else
			{
				startY = _gridSize.y / 2 * _gridSpacing.y;
			}

			// Przechodzimy po grid'zie (najpierw wiersz po wierszu)
			for ( int y = 0; y < _gridSize.y; y++ ) // 
			{
				for ( int x = 0; x < _gridSize.x; x++ )
				{
					Vector3 spawnPoint = new Vector3(startX + _gridSpacing.x * x, startY - _gridSpacing.y * y, _zPosition);
					Quaternion rotation = Quaternion.identity; // Random.rotation;
					Instantiate( _prefab, spawnPoint, rotation, gridParentTransform );
				}
			}

			// Pojawianie elementów grid'u rozciągnięte w czasie
			//StartCoroutine( SpawnGridCoroutine( startX, startY, gridParentTransform ) );
		}

		/// <summary>
		/// Sprawdza czy wartość jest parzysta
		/// </summary>
		/// <returns>True - jeżeli wartość jest parzysta, w przeciwnym wypadku False </returns>
		bool IsEven( int value )
		{
			return value % 2 == 0;
		}

		// Pojawianie elementów grid'u rozciągnięte w czasie
		//private IEnumerator SpawnGridCoroutine( float startX, float startY, Transform gridParentTransform )
		//{
		//	var wait = new WaitForSeconds( 0.1f ); ;
		//	// Przechodzimy po grid'zie (najpierw wiersz po wierszu)
		//	for ( int y = 0; y < _gridSize.y; y++ ) // 
		//	{
		//		for ( int x = 0; x < _gridSize.x; x++ )
		//		{
		//			Vector3 spawnPoint = new Vector3(startX + _gridSpacing.x * x, startY - _gridSpacing.y * y, _zPosition);
		//			Quaternion rotation = Random.rotation;
		//			Instantiate( _prefab, spawnPoint, rotation, gridParentTransform );
		//			yield return wait;
		//		}
		//	}
		//}
	}
}
