using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc5
{
	public class SpawnCubes : MonoBehaviour
	{
		[SF] private GameObject _cubePrefab;
		[SF][Range(1, 2000)] private int _spawnCount;
		[SF][Range(1, 100)] private int _maxAttempts;
		[SF] private GameObject _terrain;
		[SF] private LayerMask _cubeLayer;

		private Bounds _terrainBounds;
		private BoxCollider _cubeBoxCollider;

		private void Start()
		{
			_terrainBounds = _terrain.GetComponent<MeshRenderer>().bounds;
			_cubeBoxCollider = _cubePrefab.GetComponent<BoxCollider>();
			_terrainBounds.size -= _cubeBoxCollider.size;

			// Spróbujmy postawić 'klocka' tyle razy ile zostsało zazdane
			for (int i = 0; i < _spawnCount; i++ )
			{
				TrySpawn();
			}
		}

		/// <summary>
		/// Wybieramy losową pozycję i próbujemy jej użyć, jeżeli jest już zajęta losujemy następną, 
		/// robimy tak aż nie osiągniemy maksymalnej ilościu prób
		/// </summary>
		void TrySpawn()
		{
			var rcPosition = RandomPosition;
			int attempt = 0;
			while ( IsColliding( rcPosition ) && attempt < _maxAttempts )
			{
				rcPosition = RandomPosition;
				attempt++;
			}
			// Kolidujemy i wykorzystaliśmy maksymalną ilość prób więc nie spawn'ujemy 
			if ( attempt == _maxAttempts )
			{
				return;
			}
			Instantiate( _cubePrefab, rcPosition, Quaternion.identity );
		}

		bool IsColliding(Vector3 position )
		{
			return Physics.CheckBox( position + _cubeBoxCollider.center, _cubeBoxCollider.size / 2, Quaternion.identity, _cubeLayer );
		}

		Vector3 RandomPosition => new Vector3( Random.Range( _terrainBounds.min.x, _terrainBounds.max.x ),
			_terrain.transform.position.y,
			Random.Range( _terrainBounds.min.z, _terrainBounds.max.z ) );
	}
}