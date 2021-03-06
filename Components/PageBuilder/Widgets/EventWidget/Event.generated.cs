//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.CMS;

[assembly: RegisterDocumentType(Event.CLASS_NAME, typeof(Event))]

namespace CMS.DocumentEngine.Types.CMS
{
	/// <summary>
	/// Represents a content item of type Event.
	/// </summary>
	public partial class Event : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "CMS.Event";


		/// <summary>
		/// The instance of the class that provides extended API for working with Event fields.
		/// </summary>
		private readonly EventFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// EventID.
		/// </summary>
		[DatabaseIDField]
		public int EventID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("EventID"), 0);
			}
			set
			{
				SetValue("EventID", value);
			}
		}


		/// <summary>
		/// Event name.
		/// </summary>
		[DatabaseField]
		public string EventName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("EventName"), @"");
			}
			set
			{
				SetValue("EventName", value);
			}
		}


		/// <summary>
		/// Event Summary.
		/// </summary>
		[DatabaseField]
		public string EventSummary
		{
			get
			{
				return ValidationHelper.GetString(GetValue("EventSummary"), @"");
			}
			set
			{
				SetValue("EventSummary", value);
			}
		}


		/// <summary>
		/// Event Details.
		/// </summary>
		[DatabaseField]
		public string EventDetails
		{
			get
			{
				return ValidationHelper.GetString(GetValue("EventDetails"), @"");
			}
			set
			{
				SetValue("EventDetails", value);
			}
		}


		/// <summary>
		/// Event Location.
		/// </summary>
		[DatabaseField]
		public string EventLocation
		{
			get
			{
				return ValidationHelper.GetString(GetValue("EventLocation"), @"");
			}
			set
			{
				SetValue("EventLocation", value);
			}
		}


		/// <summary>
		/// Event date and time.
		/// </summary>
		[DatabaseField]
		public DateTime EventDate
		{
			get
			{
				return ValidationHelper.GetDateTime(GetValue("EventDate"), DateTimeHelper.ZERO_TIME);
			}
			set
			{
				SetValue("EventDate", value);
			}
		}


		/// <summary>
		/// Event File.
		/// </summary>
		[DatabaseField]
		public Guid EventFile
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("EventFile"), Guid.Empty);
			}
			set
			{
				SetValue("EventFile", value);
			}
		}


		/// <summary>
		/// Event Link.
		/// </summary>
		[DatabaseField]
		public string EventLink
		{
			get
			{
				return ValidationHelper.GetString(GetValue("EventLink"), @"");
			}
			set
			{
				SetValue("EventLink", value);
			}
		}


		/// <summary>
		/// Send Email to Subscribers.
		/// </summary>
		[DatabaseField]
		public bool EmailToSubscribers
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("EmailToSubscribers"), false);
			}
			set
			{
				SetValue("EmailToSubscribers", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Event fields.
		/// </summary>
		[RegisterProperty]
		public EventFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Event fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class EventFields : AbstractHierarchicalObject<EventFields>
		{
			/// <summary>
			/// The content item of type Event that is a target of the extended API.
			/// </summary>
			private readonly Event mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="EventFields" /> class with the specified content item of type Event.
			/// </summary>
			/// <param name="instance">The content item of type Event that is a target of the extended API.</param>
			public EventFields(Event instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// EventID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.EventID;
				}
				set
				{
					mInstance.EventID = value;
				}
			}


			/// <summary>
			/// Event name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.EventName;
				}
				set
				{
					mInstance.EventName = value;
				}
			}


			/// <summary>
			/// Event Summary.
			/// </summary>
			public string Summary
			{
				get
				{
					return mInstance.EventSummary;
				}
				set
				{
					mInstance.EventSummary = value;
				}
			}


			/// <summary>
			/// Event Details.
			/// </summary>
			public string Details
			{
				get
				{
					return mInstance.EventDetails;
				}
				set
				{
					mInstance.EventDetails = value;
				}
			}


			/// <summary>
			/// Event Location.
			/// </summary>
			public string Location
			{
				get
				{
					return mInstance.EventLocation;
				}
				set
				{
					mInstance.EventLocation = value;
				}
			}


			/// <summary>
			/// Event date and time.
			/// </summary>
			public DateTime Date
			{
				get
				{
					return mInstance.EventDate;
				}
				set
				{
					mInstance.EventDate = value;
				}
			}


			/// <summary>
			/// Event File.
			/// </summary>
			public DocumentAttachment File
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("EventFile");
				}
			}


			/// <summary>
			/// Event Link.
			/// </summary>
			public string Link
			{
				get
				{
					return mInstance.EventLink;
				}
				set
				{
					mInstance.EventLink = value;
				}
			}


			/// <summary>
			/// Send Email to Subscribers.
			/// </summary>
			public bool EmailToSubscribers
			{
				get
				{
					return mInstance.EmailToSubscribers;
				}
				set
				{
					mInstance.EmailToSubscribers = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Event" /> class.
		/// </summary>
		public Event() : base(CLASS_NAME)
		{
			mFields = new EventFields(this);
		}

		#endregion
	}
}