/* 
 * Adyen Checkout API
 *
 * Adyen Checkout API provides a simple and flexible way to initiate and authorise online payments. You can use the same integration for payments made with cards (including 3D Secure), mobile wallets, and local payment methods (for example, iDEAL and Sofort).  This API reference provides information on available endpoints and how to interact with them. To learn more about the API, visit [Checkout documentation](https://docs.adyen.com/checkout).  ## Authentication Each request to the Checkout API must be signed with an API key. For this, obtain an API Key from your Customer Area, as described in [How to get the API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key). Then set this key to the `X-API-Key` header value, for example:  ``` curl -H \"Content-Type: application/json\" \\ -H \"X-API-Key: Your_Checkout_API_key\" \\ ... ``` Note that when going live, you need to generate a new API Key to access the [live endpoints](https://docs.adyen.com/development-resources/live-endpoints).  ## Versioning Checkout API supports versioning of its endpoints through a version suffix in the endpoint URL. This suffix has the following format: \"vXX\", where XX is the version number.  For example: ``` https://checkout-test.adyen.com/v66/payments ```
 *
 * OpenAPI spec version: 66
 * Contact: developer-experience@adyen.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// RecurringDetail
    /// </summary>
    [DataContract]
        public partial class RecurringDetail :  IEquatable<RecurringDetail>, IValidatableObject
    {
        /// <summary>
        /// The funding source of the payment method.
        /// </summary>
        /// <value>The funding source of the payment method.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FundingSourceEnum
        {
            /// <summary>
            /// Enum Debit for value: debit
            /// </summary>
            [EnumMember(Value = "debit")]
            Debit = 1        }
        /// <summary>
        /// The funding source of the payment method.
        /// </summary>
        /// <value>The funding source of the payment method.</value>
        [DataMember(Name="fundingSource", EmitDefaultValue=false)]
        public FundingSourceEnum? FundingSource { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringDetail" /> class.
        /// </summary>
        /// <param name="brand">Brand for the selected gift card. For example: plastix, hmclub..</param>
        /// <param name="brands">List of possible brands. For example: visa, mc..</param>
        /// <param name="configuration">The configuration of the payment method..</param>
        /// <param name="details">All input details to be provided to complete the payment with this payment method..</param>
        /// <param name="fundingSource">The funding source of the payment method..</param>
        /// <param name="group">group.</param>
        /// <param name="inputDetails">All input details to be provided to complete the payment with this payment method..</param>
        /// <param name="name">The displayable name of this payment method..</param>
        /// <param name="recurringDetailReference">The reference that uniquely identifies the recurring detail..</param>
        /// <param name="storedDetails">storedDetails.</param>
        /// <param name="type">The unique payment method code..</param>
        public RecurringDetail(string brand = default(string), List<string> brands = default(List<string>), Dictionary<string, string> configuration = default(Dictionary<string, string>), List<InputDetail> details = default(List<InputDetail>), FundingSourceEnum? fundingSource = default(FundingSourceEnum?), PaymentMethodGroup group = default(PaymentMethodGroup), List<InputDetail> inputDetails = default(List<InputDetail>), string name = default(string), string recurringDetailReference = default(string), StoredDetails storedDetails = default(StoredDetails), string type = default(string))
        {
            this.Brand = brand;
            this.Brands = brands;
            this.Configuration = configuration;
            this.Details = details;
            this.FundingSource = fundingSource;
            this.Group = group;
            this.InputDetails = inputDetails;
            this.Name = name;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredDetails = storedDetails;
            this.Type = type;
        }
        
        /// <summary>
        /// Brand for the selected gift card. For example: plastix, hmclub.
        /// </summary>
        /// <value>Brand for the selected gift card. For example: plastix, hmclub.</value>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public string Brand { get; set; }

        /// <summary>
        /// List of possible brands. For example: visa, mc.
        /// </summary>
        /// <value>List of possible brands. For example: visa, mc.</value>
        [DataMember(Name="brands", EmitDefaultValue=false)]
        public List<string> Brands { get; set; }

        /// <summary>
        /// The configuration of the payment method.
        /// </summary>
        /// <value>The configuration of the payment method.</value>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public Dictionary<string, string> Configuration { get; set; }

        /// <summary>
        /// All input details to be provided to complete the payment with this payment method.
        /// </summary>
        /// <value>All input details to be provided to complete the payment with this payment method.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<InputDetail> Details { get; set; }


        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public PaymentMethodGroup Group { get; set; }

        /// <summary>
        /// All input details to be provided to complete the payment with this payment method.
        /// </summary>
        /// <value>All input details to be provided to complete the payment with this payment method.</value>
        [DataMember(Name="inputDetails", EmitDefaultValue=false)]
        public List<InputDetail> InputDetails { get; set; }

        /// <summary>
        /// The displayable name of this payment method.
        /// </summary>
        /// <value>The displayable name of this payment method.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The reference that uniquely identifies the recurring detail.
        /// </summary>
        /// <value>The reference that uniquely identifies the recurring detail.</value>
        [DataMember(Name="recurringDetailReference", EmitDefaultValue=false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// Gets or Sets StoredDetails
        /// </summary>
        [DataMember(Name="storedDetails", EmitDefaultValue=false)]
        public StoredDetails StoredDetails { get; set; }

        /// <summary>
        /// The unique payment method code.
        /// </summary>
        /// <value>The unique payment method code.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecurringDetail {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Brands: ").Append(Brands).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  InputDetails: ").Append(InputDetails).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  StoredDetails: ").Append(StoredDetails).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecurringDetail);
        }

        /// <summary>
        /// Returns true if RecurringDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of RecurringDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurringDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Brands == input.Brands ||
                    this.Brands != null &&
                    input.Brands != null &&
                    this.Brands.SequenceEqual(input.Brands)
                ) && 
                (
                    this.Configuration == input.Configuration ||
                    this.Configuration != null &&
                    input.Configuration != null &&
                    this.Configuration.SequenceEqual(input.Configuration)
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.FundingSource == input.FundingSource ||
                    (this.FundingSource != null &&
                    this.FundingSource.Equals(input.FundingSource))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.InputDetails == input.InputDetails ||
                    this.InputDetails != null &&
                    input.InputDetails != null &&
                    this.InputDetails.SequenceEqual(input.InputDetails)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) && 
                (
                    this.StoredDetails == input.StoredDetails ||
                    (this.StoredDetails != null &&
                    this.StoredDetails.Equals(input.StoredDetails))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.Brands != null)
                    hashCode = hashCode * 59 + this.Brands.GetHashCode();
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.FundingSource != null)
                    hashCode = hashCode * 59 + this.FundingSource.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.InputDetails != null)
                    hashCode = hashCode * 59 + this.InputDetails.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RecurringDetailReference != null)
                    hashCode = hashCode * 59 + this.RecurringDetailReference.GetHashCode();
                if (this.StoredDetails != null)
                    hashCode = hashCode * 59 + this.StoredDetails.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}