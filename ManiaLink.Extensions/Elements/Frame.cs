using System.Web.Mvc;

namespace ManiaLink.Extensions.Elements
{
	/// <summary>
	/// Manialink XML frame.
	/// </summary>
	public class Frame : ManialinkElement
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="Frame"/> class with the specified view context.
		/// </summary>
		/// <param name="viewContext">An object that encapsulates the information that is required in order to render a view.</param>
		public Frame(ViewContext viewContext)
			: base(viewContext, "frame", false)
		{
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// Ends the Manialink XML frame and disposes of all resources.
		/// </summary>
		public void EndFrame()
		{
			this.Dispose(true);
		}

		#endregion
	}
}