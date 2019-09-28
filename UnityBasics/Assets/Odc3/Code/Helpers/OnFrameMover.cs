using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc3
{
	public class OnFrameMover : MonoBehaviour
	{
		[SF] private List<PointDefinition> _pointDefinitions;

		private void Awake()
		{
			_pointDefinitions = _pointDefinitions.OrderBy( point => point.frame ).ToList();
		}

		private void Update()
		{
			if(_pointDefinitions[0].frame == Time.frameCount )
			{
				transform.position = _pointDefinitions[0].position;
				_pointDefinitions.RemoveAt( 0 );
				if(_pointDefinitions.Count < 1 )
				{
					Destroy( this );
				}
			}
		}

		[System.Serializable]
		protected struct PointDefinition
		{
			public int frame;
			public Vector3 position;
		}
	}
}
