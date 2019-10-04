using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc4
{
	public class CapsuleCaster : MonoBehaviour, ICaster
	{
		[SF] private Vector3 _startCenterOffset;
		[SF] private Vector3 _endCenterOffset;
		[SF] private float _radius;
		[SF] private Camera _camera;

		public bool Cast( Ray ray, out RaycastHit hitInfo, float maxDistance, int layers )
		{
			var rotation = _camera.transform.rotation;
			var startCenter = rotation * _startCenterOffset + ray.origin;
			var endCenter = rotation * _endCenterOffset + ray.origin;

			return Physics.CapsuleCast( startCenter, endCenter, _radius, ray.direction, out hitInfo, maxDistance, layers );
		}

		public RaycastHit[] CastAll( Ray ray, float maxDistance, int layers )
		{
			var rotation = _camera.transform.rotation;
			var startCenter = rotation * _startCenterOffset + ray.origin;
			var endCenter = rotation * _endCenterOffset + ray.origin;

			return Physics.CapsuleCastAll( startCenter, endCenter, _radius, ray.direction, maxDistance, layers );
		}

		public int CastNonAlloc( Ray ray, RaycastHit[] results, float maxDistance, int layers )
		{
			var rotation = _camera.transform.rotation;
			var startCenter = rotation * _startCenterOffset + ray.origin;
			var endCenter = rotation * _endCenterOffset + ray.origin;

			return Physics.CapsuleCastNonAlloc( startCenter, endCenter, _radius, ray.direction, results, maxDistance, layers );
		}
	}
}
