// SF API version v57.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Card Payment Method
	///<para>SObject Name: CardPaymentMethod</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCardPaymentMethod : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CardPaymentMethod"; }
		}

		///<summary>
		/// Card Payment Method ID
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
		/// Card Payment Method Number
		/// <para>Name: CardPaymentMethodNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "cardPaymentMethodNumber")]
		[Updateable(false), Createable(false)]
		public string CardPaymentMethodNumber { get; set; }

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
		/// Last Viewed Date
		/// <para>Name: LastViewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastViewedDate { get; set; }

		///<summary>
		/// Last Referenced Date
		/// <para>Name: LastReferencedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastReferencedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastReferencedDate { get; set; }

		///<summary>
		/// Display Card Number
		/// <para>Name: DisplayCardNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "displayCardNumber")]
		[Updateable(false), Createable(false)]
		public string DisplayCardNumber { get; set; }

		///<summary>
		/// Expiry Month
		/// <para>Name: ExpiryMonth</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "expiryMonth")]
		public int? ExpiryMonth { get; set; }

		///<summary>
		/// Expiry Year
		/// <para>Name: ExpiryYear</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "expiryYear")]
		public int? ExpiryYear { get; set; }

		///<summary>
		/// Start Month
		/// <para>Name: StartMonth</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startMonth")]
		public int? StartMonth { get; set; }

		///<summary>
		/// Start Year
		/// <para>Name: StartYear</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startYear")]
		public int? StartYear { get; set; }

		///<summary>
		/// Card Type
		/// <para>Name: CardType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cardType")]
		[Updateable(false), Createable(true)]
		public string CardType { get; set; }

		///<summary>
		/// Card Type Category
		/// <para>Name: CardTypeCategory</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cardTypeCategory")]
		[Updateable(false), Createable(false)]
		public string CardTypeCategory { get; set; }

		///<summary>
		/// Auto Card Type
		/// <para>Name: AutoCardType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "autoCardType")]
		[Updateable(false), Createable(true)]
		public string AutoCardType { get; set; }

		///<summary>
		/// Card Category
		/// <para>Name: CardCategory</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cardCategory")]
		[Updateable(false), Createable(true)]
		public string CardCategory { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: AccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accountId")]
		public string AccountId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: Account</para>
		///</summary>
		[JsonProperty(PropertyName = "account")]
		[Updateable(false), Createable(false)]
		public SfAccount Account { get; set; }

		///<summary>
		/// Street
		/// <para>Name: PaymentMethodStreet</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodStreet")]
		public string PaymentMethodStreet { get; set; }

		///<summary>
		/// City
		/// <para>Name: PaymentMethodCity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodCity")]
		public string PaymentMethodCity { get; set; }

		///<summary>
		/// State
		/// <para>Name: PaymentMethodState</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodState")]
		public string PaymentMethodState { get; set; }

		///<summary>
		/// Postal Code
		/// <para>Name: PaymentMethodPostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodPostalCode")]
		public string PaymentMethodPostalCode { get; set; }

		///<summary>
		/// Country
		/// <para>Name: PaymentMethodCountry</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodCountry")]
		public string PaymentMethodCountry { get; set; }

		///<summary>
		/// Latitude
		/// <para>Name: PaymentMethodLatitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodLatitude")]
		public double? PaymentMethodLatitude { get; set; }

		///<summary>
		/// Longitude
		/// <para>Name: PaymentMethodLongitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodLongitude")]
		public double? PaymentMethodLongitude { get; set; }

		///<summary>
		/// GeoCode Accuracy
		/// <para>Name: PaymentMethodGeocodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodGeocodeAccuracy")]
		public string PaymentMethodGeocodeAccuracy { get; set; }

		///<summary>
		/// Payment Method Address
		/// <para>Name: PaymentMethodAddress</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodAddress")]
		[Updateable(false), Createable(false)]
		public Address PaymentMethodAddress { get; set; }

		///<summary>
		/// Nickname
		/// <para>Name: NickName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "nickName")]
		public string NickName { get; set; }

		///<summary>
		/// Card Holder Name
		/// <para>Name: CardHolderName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cardHolderName")]
		public string CardHolderName { get; set; }

		///<summary>
		/// Card BIN
		/// <para>Name: CardBin</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cardBin")]
		[Updateable(false), Createable(true)]
		public int? CardBin { get; set; }

		///<summary>
		/// Card Last Four
		/// <para>Name: CardLastFour</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cardLastFour")]
		[Updateable(false), Createable(true)]
		public int? CardLastFour { get; set; }

		///<summary>
		/// Registered Card Email
		/// <para>Name: Email</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "email")]
		public string Email { get; set; }

		///<summary>
		/// Comments
		/// <para>Name: Comments</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "comments")]
		public string Comments { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		///<summary>
		/// Input Card Number
		/// <para>Name: InputCardNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "inputCardNumber")]
		[Updateable(false), Createable(true)]
		public string InputCardNumber { get; set; }

		///<summary>
		/// Card Holder First Name
		/// <para>Name: CardHolderFirstName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cardHolderFirstName")]
		public string CardHolderFirstName { get; set; }

		///<summary>
		/// Card Holder Last Name
		/// <para>Name: CardHolderLastName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cardHolderLastName")]
		public string CardHolderLastName { get; set; }

		///<summary>
		/// Company Name
		/// <para>Name: CompanyName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyName")]
		public string CompanyName { get; set; }

		///<summary>
		/// GatewayToken
		/// <para>Name: GatewayToken</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayToken")]
		public string GatewayToken { get; set; }

		///<summary>
		/// Gateway Token Details
		/// <para>Name: GatewayTokenDetails</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayTokenDetails")]
		public string GatewayTokenDetails { get; set; }

		///<summary>
		/// Payment Gateway ID
		/// <para>Name: PaymentGatewayId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentGatewayId")]
		[Updateable(false), Createable(true)]
		public string PaymentGatewayId { get; set; }

		///<summary>
		/// ReferenceTo: PaymentGateway
		/// <para>RelationshipName: PaymentGateway</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentGateway")]
		[Updateable(false), Createable(false)]
		public SfPaymentGateway PaymentGateway { get; set; }

		///<summary>
		/// Processing Mode
		/// <para>Name: ProcessingMode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "processingMode")]
		[Updateable(false), Createable(true)]
		public string ProcessingMode { get; set; }

		///<summary>
		/// MAC Address
		/// <para>Name: MacAddress</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "macAddress")]
		public string MacAddress { get; set; }

		///<summary>
		/// Phone
		/// <para>Name: Phone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phone")]
		public string Phone { get; set; }

		///<summary>
		/// IP Address
		/// <para>Name: IpAddress</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ipAddress")]
		public string IpAddress { get; set; }

		///<summary>
		/// Audit Email
		/// <para>Name: AuditEmail</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "auditEmail")]
		public string AuditEmail { get; set; }

		///<summary>
		/// Gateway Result Code
		/// <para>Name: GatewayResultCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayResultCode")]
		public string GatewayResultCode { get; set; }

		///<summary>
		/// Gateway Result Code Description
		/// <para>Name: GatewayResultCodeDescription</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayResultCodeDescription")]
		public string GatewayResultCodeDescription { get; set; }

		///<summary>
		/// Salesforce Result Code
		/// <para>Name: SfResultCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sfResultCode")]
		public string SfResultCode { get; set; }

		///<summary>
		/// Gateway Date
		/// <para>Name: GatewayDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayDate")]
		public DateTimeOffset? GatewayDate { get; set; }

		///<summary>
		/// Gateway Token Encrypted
		/// <para>Name: GatewayTokenEncrypted</para>
		/// <para>SF Type: encryptedstring</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayTokenEncrypted")]
		public string GatewayTokenEncrypted { get; set; }

		///<summary>
		/// Auto Pay
		/// <para>Name: IsAutoPayEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAutoPayEnabled")]
		public bool? IsAutoPayEnabled { get; set; }

		///<summary>
		/// Payment Method Type
		/// <para>Name: PaymentMethodType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodType")]
		public string PaymentMethodType { get; set; }

		///<summary>
		/// Payment Method SubType
		/// <para>Name: PaymentMethodSubType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodSubType")]
		[Updateable(false), Createable(true)]
		public string PaymentMethodSubType { get; set; }

		///<summary>
		/// Payment Method Details
		/// <para>Name: PaymentMethodDetails</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodDetails")]
		[Updateable(false), Createable(true)]
		public string PaymentMethodDetails { get; set; }

	}
}
