using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FamilyMemberExample
{	
	/// <summary>
	/// A family member
	/// </summary>
	public class FamilyMember
    {		
		#region Fields

		int height;
		int weight;

		#endregion

		#region Constructors

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="height">the height of the family member</param>
		/// <param name="weight">the weight of the family member</param>
		public FamilyMember(int height, int weight)
        {
			this.height = height;
			this.weight = weight;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets and sets the height 
		/// </summary>
		public int Height
        {
			get { return height; }
			set { height = value; }
		}

		/// <summary>
		/// Gets and sets the weight
		/// </summary>
		public int Weight
        {
			get { return weight; }
			set { weight = value; }
		}

		#endregion

		#region Public methods

		/// <summary>
		/// Makes the family member have fun
		/// </summary>
		public virtual void HaveFun()
        {
			Console.WriteLine("I'm writing code!");
		}

		#endregion
	}
}
