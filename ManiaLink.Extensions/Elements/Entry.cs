using System.Web.Mvc;

namespace ManiaLink.Extensions.Elements
{
	/// <summary>
	/// Manialink XML entry.
	/// </summary>
	public class Entry : ManialinkElement
	{
		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewContext"></param>
		public Entry(ViewContext viewContext)
			: base(viewContext, "entry", true)
		{
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// 
		/// </summary>
		public void EndEntry()
		{
			this.Dispose(true);
		}

		#endregion
	}
}