using System.Web.Mvc;

namespace ManiaLink.Extensions.Elements
{
	/// <summary>
	/// Manialink XML video.
	/// </summary>
	public class Video : ManialinkElement
	{
		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewContext"></param>
		public Video(ViewContext viewContext)
			: base(viewContext, "video", true)
		{
		}

		#endregion
	}
}