using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc4
{
	public class BoxCaster : MonoBehaviour, ICaster
	{
		[SF] private Vector3 _boxHalfSize = new Vector3(0.5f, 0.5f, 0.5f);
		[SF] private Camera _camera;

		public bool Cast( Ray ray, out RaycastHit hitInfo, float maxDistance, int layers )
		{
			return Physics.BoxCast( ray.origin, _boxHalfSize, ray.direction, out hitInfo, Quaternion.Euler( _camera.transform.forward ), maxDistance, layers );
		}

		public RaycastHit[] CastAll( Ray ray, float maxDistance, int layers )
		{
			return Physics.BoxCastAll( ray.origin, _boxHalfSize, ray.direction, Quaternion.Euler( _camera.transform.forward ), maxDistance, layers );
		}

		public int CastNonAlloc( Ray ray, RaycastHit[] results, float maxDistance, int layers )
		{
			return Physics.BoxCastNonAlloc( ray.origin, _boxHalfSize, ray.direction, results, Quaternion.Euler( _camera.transform.forward ), maxDistance, layers );
		}
	}
}
