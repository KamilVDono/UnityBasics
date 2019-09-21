using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Odc0_5
{
	public class HelloWorld : MonoBehaviour
	{
		[SerializeField] private string _text;

		public string Text
		{
			get => _text;
			private set => _text = value;
		}

		private void Awake()
		{
			Debug.Log( $"Hello World: {Text}" );
		}
	}
}

