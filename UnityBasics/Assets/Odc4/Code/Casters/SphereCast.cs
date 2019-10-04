using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc4
{
	public class SphereCast : MonoBehaviour, ICaster
	{
		[SF] private float _radius;

		public bool Cast( Ray ray, out RaycastHit hitInfo, float maxDistance, int layers )
		{
			return Physics.SphereCast( ray.origin, _radius, ray.direction, out hitInfo, maxDistance, layers );
		}

		public RaycastHit[] CastAll( Ray ray, float maxDistance, int layers )
		{
			return Physics.SphereCastAll( ray.origin, _radius, ray.direction,  maxDistance, layers );
		}

		public int CastNonAlloc( Ray ray, RaycastHit[] results, float maxDistance, int layers )
		{
			return Physics.SphereCastNonAlloc( ray.origin, _radius, ray.direction, results, maxDistance, layers );
		}
	}
}
