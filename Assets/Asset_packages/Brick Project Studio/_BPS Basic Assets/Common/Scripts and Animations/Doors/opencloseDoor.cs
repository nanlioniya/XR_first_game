using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{

	public class opencloseDoor : MonoBehaviour
	{
		bool flag1, flag2, flag3, flag4;

		public Animator openandclose;
		public bool open;
		public Transform Player;

		void Start()
		{
			flag1 = false;
			flag2 = false;
			flag3 = false;
			flag4 = false;

		}

        private void Update()
        {
			flag1 = FindObjectOfType<Look_horizontally>().isHorizontally;
			flag2 = FindObjectOfType<Touching_Head>().Head_touched;
			flag3 = FindObjectOfType<Open_window>().done;
			flag4 = FindObjectOfType<Feed>().done;

			if (flag1 && flag2 && flag3 && flag4)
			{
				gameObject.GetComponent<Animator>().Play("Opening");

			}

		}

		IEnumerator opening()
		{
			print("you are opening the door");
			openandclose.Play("Opening");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			openandclose.Play("Closing");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}