// SF API version v50.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Test Suite Membership
	///<para>SObject Name: TestSuiteMembership</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfTestSuiteMembership : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "TestSuiteMembership"; }
		}

		///<summary>
		/// Test Suite Membership ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Createable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Createable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Createable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Createable(false)]
		public SfUser LastModifiedBy { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Test Suite ID
		/// <para>Name: ApexTestSuiteId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "apexTestSuiteId")]
		[Updateable(false), Createable(true)]
		public string ApexTestSuiteId { get; set; }

		///<summary>
		/// ReferenceTo: ApexTestSuite
		/// <para>RelationshipName: ApexTestSuite</para>
		///</summary>
		[JsonProperty(PropertyName = "apexTestSuite")]
		[Updateable(false), Createable(false)]
		public SfApexTestSuite ApexTestSuite { get; set; }

		///<summary>
		/// Class ID
		/// <para>Name: ApexClassId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "apexClassId")]
		[Updateable(false), Createable(true)]
		public string ApexClassId { get; set; }

		///<summary>
		/// ReferenceTo: ApexClass
		/// <para>RelationshipName: ApexClass</para>
		///</summary>
		[JsonProperty(PropertyName = "apexClass")]
		[Updateable(false), Createable(false)]
		public SfApexClass ApexClass { get; set; }

	}
}
