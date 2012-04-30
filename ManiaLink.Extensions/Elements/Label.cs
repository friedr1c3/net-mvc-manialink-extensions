using System.Web.Mvc;

namespace ManiaLink.Extensions.Elements
{
	/// <summary>
	/// Manialink XML label.
	/// </summary>
	public class Label : ManialinkElement
	{
		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewContext"></param>
		public Label(ViewContext viewContext)
			: base(viewContext, "label", true)
		{
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// 
		/// </summary>
		public void EndLabel()
		{
			this.Dispose(true);
		}

		#endregion
	}
}