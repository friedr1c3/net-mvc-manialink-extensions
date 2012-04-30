using System;
using System.IO;
using System.Web.Mvc;

namespace ManiaLink.Extensions.Elements
{
	/// <summary>
	/// Manialink element
	/// </summary>
	public abstract class ManialinkElement : IDisposable
	{
		#region Fields

		/// <summary>
		/// The _disposed.
		/// </summary>
		private bool _disposed;

		/// <summary>
		/// The _viewContext.
		/// </summary>
		private ViewContext _viewContext;

		/// <summary>
		/// The _writer.
		/// </summary>
		private TextWriter _writer;

		/// <summary>
		/// The _element.
		/// </summary>
		private string _element;

		/// <summary>
		/// The _containsContent.
		/// </summary>
		private bool _selfClosing;

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="ManialinkElement" /> class.
		/// </summary>
		/// <param name="viewContext">An object that encapsulates the information that is required in order to render a view.</param>
		/// <param name="element">The XML element name.</param>
		/// <param name="selfClosing">When true, a full closing tag will be applied, else no closing tag will be applied.</param>
		internal ManialinkElement(ViewContext viewContext, string element, bool selfClosing)
		{
			if (viewContext == null)
			{
				throw new ArgumentNullException("viewContext");
			}

			if(String.IsNullOrEmpty(element))
			{
				throw new ArgumentNullException("element");
			}

			this._viewContext = viewContext;
			this._writer = viewContext.Writer;
			this._element = element;
			this._selfClosing = selfClosing;
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// Releases all resources that are used by the current <see cref="ManialinkElement" /> class.
		/// </summary>
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Releases unmanaged and, optionally, managed resources used by the current instance of the <see cref="ManialinkElement" /> class.
		/// </summary>
		/// <param name="disposing"></param>
		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				this._disposed = true;

				// Render the end tag if the element is not a self-closing element.
				if (!this._selfClosing)
				{
					this._writer.Write("</" + this._element + ">");
				}

				if (this._viewContext != null)
				{
					this._viewContext.OutputClientValidation();
				}
			}
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the element name.
		/// </summary>
		public string ElementName
		{
			get
			{
				return this._element;
			}
		}

		/// <summary>
		/// Gets whether or not the element should is a self-closing element.
		/// </summary>
		public bool SelfClosing
		{
			get
			{
				return this._selfClosing;
			}
		}

		#endregion
	}
}