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
    /// AdditionalDataOpenInvoice
    /// </summary>
    [DataContract]
        public partial class AdditionalDataOpenInvoice :  IEquatable<AdditionalDataOpenInvoice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataOpenInvoice" /> class.
        /// </summary>
        /// <param name="openinvoicedataMerchantData">Holds different merchant data points like product, purchase, customer, and so on. It takes data in a Base64 encoded string.  The &#x60;merchantData&#x60; parameter needs to be added to the &#x60;openinvoicedata&#x60; signature at the end.  Since the field is optional, if it&#x27;s not included it does not impact computing the merchant signature.  Applies only to Klarna.  You can contact Klarna for the format and structure of the string..</param>
        /// <param name="openinvoicedataNumberOfLines">The number of invoice lines included in &#x60;openinvoicedata&#x60;.  There needs to be at least one line, so &#x60;numberOfLines&#x60; needs to be at least 1..</param>
        /// <param name="openinvoicedataLineItemNrCurrencyCode">The three-character ISO currency code..</param>
        /// <param name="openinvoicedataLineItemNrDescription">A text description of the product the invoice line refers to..</param>
        /// <param name="openinvoicedataLineItemNrItemAmount">The price for one item in the invoice line, represented in minor units.  The due amount for the item, VAT excluded..</param>
        /// <param name="openinvoicedataLineItemNrItemId">A unique id for this item. Required for RatePay if the description of each item is not unique..</param>
        /// <param name="openinvoicedataLineItemNrItemVatAmount">The VAT due for one item in the invoice line, represented in minor units..</param>
        /// <param name="openinvoicedataLineItemNrItemVatPercentage">The VAT percentage for one item in the invoice line, represented in minor units.  For example, 19% VAT is specified as 1900..</param>
        /// <param name="openinvoicedataLineItemNrNumberOfItems">The number of units purchased of a specific product..</param>
        /// <param name="openinvoicedataLineItemNrVatCategory">Required for AfterPay. The country-specific VAT category a product falls under.  Allowed values: * High * Low * None..</param>
        public AdditionalDataOpenInvoice(string openinvoicedataMerchantData = default(string), string openinvoicedataNumberOfLines = default(string), string openinvoicedataLineItemNrCurrencyCode = default(string), string openinvoicedataLineItemNrDescription = default(string), string openinvoicedataLineItemNrItemAmount = default(string), string openinvoicedataLineItemNrItemId = default(string), string openinvoicedataLineItemNrItemVatAmount = default(string), string openinvoicedataLineItemNrItemVatPercentage = default(string), string openinvoicedataLineItemNrNumberOfItems = default(string), string openinvoicedataLineItemNrVatCategory = default(string))
        {
            this.OpeninvoicedataMerchantData = openinvoicedataMerchantData;
            this.OpeninvoicedataNumberOfLines = openinvoicedataNumberOfLines;
            this.OpeninvoicedataLineItemNrCurrencyCode = openinvoicedataLineItemNrCurrencyCode;
            this.OpeninvoicedataLineItemNrDescription = openinvoicedataLineItemNrDescription;
            this.OpeninvoicedataLineItemNrItemAmount = openinvoicedataLineItemNrItemAmount;
            this.OpeninvoicedataLineItemNrItemId = openinvoicedataLineItemNrItemId;
            this.OpeninvoicedataLineItemNrItemVatAmount = openinvoicedataLineItemNrItemVatAmount;
            this.OpeninvoicedataLineItemNrItemVatPercentage = openinvoicedataLineItemNrItemVatPercentage;
            this.OpeninvoicedataLineItemNrNumberOfItems = openinvoicedataLineItemNrNumberOfItems;
            this.OpeninvoicedataLineItemNrVatCategory = openinvoicedataLineItemNrVatCategory;
        }
        
        /// <summary>
        /// Holds different merchant data points like product, purchase, customer, and so on. It takes data in a Base64 encoded string.  The &#x60;merchantData&#x60; parameter needs to be added to the &#x60;openinvoicedata&#x60; signature at the end.  Since the field is optional, if it&#x27;s not included it does not impact computing the merchant signature.  Applies only to Klarna.  You can contact Klarna for the format and structure of the string.
        /// </summary>
        /// <value>Holds different merchant data points like product, purchase, customer, and so on. It takes data in a Base64 encoded string.  The &#x60;merchantData&#x60; parameter needs to be added to the &#x60;openinvoicedata&#x60; signature at the end.  Since the field is optional, if it&#x27;s not included it does not impact computing the merchant signature.  Applies only to Klarna.  You can contact Klarna for the format and structure of the string.</value>
        [DataMember(Name="openinvoicedata.merchantData", EmitDefaultValue=false)]
        public string OpeninvoicedataMerchantData { get; set; }

        /// <summary>
        /// The number of invoice lines included in &#x60;openinvoicedata&#x60;.  There needs to be at least one line, so &#x60;numberOfLines&#x60; needs to be at least 1.
        /// </summary>
        /// <value>The number of invoice lines included in &#x60;openinvoicedata&#x60;.  There needs to be at least one line, so &#x60;numberOfLines&#x60; needs to be at least 1.</value>
        [DataMember(Name="openinvoicedata.numberOfLines", EmitDefaultValue=false)]
        public string OpeninvoicedataNumberOfLines { get; set; }

        /// <summary>
        /// The three-character ISO currency code.
        /// </summary>
        /// <value>The three-character ISO currency code.</value>
        [DataMember(Name="openinvoicedataLine[itemNr].currencyCode", EmitDefaultValue=false)]
        public string OpeninvoicedataLineItemNrCurrencyCode { get; set; }

        /// <summary>
        /// A text description of the product the invoice line refers to.
        /// </summary>
        /// <value>A text description of the product the invoice line refers to.</value>
        [DataMember(Name="openinvoicedataLine[itemNr].description", EmitDefaultValue=false)]
        public string OpeninvoicedataLineItemNrDescription { get; set; }

        /// <summary>
        /// The price for one item in the invoice line, represented in minor units.  The due amount for the item, VAT excluded.
        /// </summary>
        /// <value>The price for one item in the invoice line, represented in minor units.  The due amount for the item, VAT excluded.</value>
        [DataMember(Name="openinvoicedataLine[itemNr].itemAmount", EmitDefaultValue=false)]
        public string OpeninvoicedataLineItemNrItemAmount { get; set; }

        /// <summary>
        /// A unique id for this item. Required for RatePay if the description of each item is not unique.
        /// </summary>
        /// <value>A unique id for this item. Required for RatePay if the description of each item is not unique.</value>
        [DataMember(Name="openinvoicedataLine[itemNr].itemId", EmitDefaultValue=false)]
        public string OpeninvoicedataLineItemNrItemId { get; set; }

        /// <summary>
        /// The VAT due for one item in the invoice line, represented in minor units.
        /// </summary>
        /// <value>The VAT due for one item in the invoice line, represented in minor units.</value>
        [DataMember(Name="openinvoicedataLine[itemNr].itemVatAmount", EmitDefaultValue=false)]
        public string OpeninvoicedataLineItemNrItemVatAmount { get; set; }

        /// <summary>
        /// The VAT percentage for one item in the invoice line, represented in minor units.  For example, 19% VAT is specified as 1900.
        /// </summary>
        /// <value>The VAT percentage for one item in the invoice line, represented in minor units.  For example, 19% VAT is specified as 1900.</value>
        [DataMember(Name="openinvoicedataLine[itemNr].itemVatPercentage", EmitDefaultValue=false)]
        public string OpeninvoicedataLineItemNrItemVatPercentage { get; set; }

        /// <summary>
        /// The number of units purchased of a specific product.
        /// </summary>
        /// <value>The number of units purchased of a specific product.</value>
        [DataMember(Name="openinvoicedataLine[itemNr].numberOfItems", EmitDefaultValue=false)]
        public string OpeninvoicedataLineItemNrNumberOfItems { get; set; }

        /// <summary>
        /// Required for AfterPay. The country-specific VAT category a product falls under.  Allowed values: * High * Low * None.
        /// </summary>
        /// <value>Required for AfterPay. The country-specific VAT category a product falls under.  Allowed values: * High * Low * None.</value>
        [DataMember(Name="openinvoicedataLine[itemNr].vatCategory", EmitDefaultValue=false)]
        public string OpeninvoicedataLineItemNrVatCategory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalDataOpenInvoice {\n");
            sb.Append("  OpeninvoicedataMerchantData: ").Append(OpeninvoicedataMerchantData).Append("\n");
            sb.Append("  OpeninvoicedataNumberOfLines: ").Append(OpeninvoicedataNumberOfLines).Append("\n");
            sb.Append("  OpeninvoicedataLineItemNrCurrencyCode: ").Append(OpeninvoicedataLineItemNrCurrencyCode).Append("\n");
            sb.Append("  OpeninvoicedataLineItemNrDescription: ").Append(OpeninvoicedataLineItemNrDescription).Append("\n");
            sb.Append("  OpeninvoicedataLineItemNrItemAmount: ").Append(OpeninvoicedataLineItemNrItemAmount).Append("\n");
            sb.Append("  OpeninvoicedataLineItemNrItemId: ").Append(OpeninvoicedataLineItemNrItemId).Append("\n");
            sb.Append("  OpeninvoicedataLineItemNrItemVatAmount: ").Append(OpeninvoicedataLineItemNrItemVatAmount).Append("\n");
            sb.Append("  OpeninvoicedataLineItemNrItemVatPercentage: ").Append(OpeninvoicedataLineItemNrItemVatPercentage).Append("\n");
            sb.Append("  OpeninvoicedataLineItemNrNumberOfItems: ").Append(OpeninvoicedataLineItemNrNumberOfItems).Append("\n");
            sb.Append("  OpeninvoicedataLineItemNrVatCategory: ").Append(OpeninvoicedataLineItemNrVatCategory).Append("\n");
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
            return this.Equals(input as AdditionalDataOpenInvoice);
        }

        /// <summary>
        /// Returns true if AdditionalDataOpenInvoice instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataOpenInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataOpenInvoice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OpeninvoicedataMerchantData == input.OpeninvoicedataMerchantData ||
                    (this.OpeninvoicedataMerchantData != null &&
                    this.OpeninvoicedataMerchantData.Equals(input.OpeninvoicedataMerchantData))
                ) && 
                (
                    this.OpeninvoicedataNumberOfLines == input.OpeninvoicedataNumberOfLines ||
                    (this.OpeninvoicedataNumberOfLines != null &&
                    this.OpeninvoicedataNumberOfLines.Equals(input.OpeninvoicedataNumberOfLines))
                ) && 
                (
                    this.OpeninvoicedataLineItemNrCurrencyCode == input.OpeninvoicedataLineItemNrCurrencyCode ||
                    (this.OpeninvoicedataLineItemNrCurrencyCode != null &&
                    this.OpeninvoicedataLineItemNrCurrencyCode.Equals(input.OpeninvoicedataLineItemNrCurrencyCode))
                ) && 
                (
                    this.OpeninvoicedataLineItemNrDescription == input.OpeninvoicedataLineItemNrDescription ||
                    (this.OpeninvoicedataLineItemNrDescription != null &&
                    this.OpeninvoicedataLineItemNrDescription.Equals(input.OpeninvoicedataLineItemNrDescription))
                ) && 
                (
                    this.OpeninvoicedataLineItemNrItemAmount == input.OpeninvoicedataLineItemNrItemAmount ||
                    (this.OpeninvoicedataLineItemNrItemAmount != null &&
                    this.OpeninvoicedataLineItemNrItemAmount.Equals(input.OpeninvoicedataLineItemNrItemAmount))
                ) && 
                (
                    this.OpeninvoicedataLineItemNrItemId == input.OpeninvoicedataLineItemNrItemId ||
                    (this.OpeninvoicedataLineItemNrItemId != null &&
                    this.OpeninvoicedataLineItemNrItemId.Equals(input.OpeninvoicedataLineItemNrItemId))
                ) && 
                (
                    this.OpeninvoicedataLineItemNrItemVatAmount == input.OpeninvoicedataLineItemNrItemVatAmount ||
                    (this.OpeninvoicedataLineItemNrItemVatAmount != null &&
                    this.OpeninvoicedataLineItemNrItemVatAmount.Equals(input.OpeninvoicedataLineItemNrItemVatAmount))
                ) && 
                (
                    this.OpeninvoicedataLineItemNrItemVatPercentage == input.OpeninvoicedataLineItemNrItemVatPercentage ||
                    (this.OpeninvoicedataLineItemNrItemVatPercentage != null &&
                    this.OpeninvoicedataLineItemNrItemVatPercentage.Equals(input.OpeninvoicedataLineItemNrItemVatPercentage))
                ) && 
                (
                    this.OpeninvoicedataLineItemNrNumberOfItems == input.OpeninvoicedataLineItemNrNumberOfItems ||
                    (this.OpeninvoicedataLineItemNrNumberOfItems != null &&
                    this.OpeninvoicedataLineItemNrNumberOfItems.Equals(input.OpeninvoicedataLineItemNrNumberOfItems))
                ) && 
                (
                    this.OpeninvoicedataLineItemNrVatCategory == input.OpeninvoicedataLineItemNrVatCategory ||
                    (this.OpeninvoicedataLineItemNrVatCategory != null &&
                    this.OpeninvoicedataLineItemNrVatCategory.Equals(input.OpeninvoicedataLineItemNrVatCategory))
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
                if (this.OpeninvoicedataMerchantData != null)
                    hashCode = hashCode * 59 + this.OpeninvoicedataMerchantData.GetHashCode();
                if (this.OpeninvoicedataNumberOfLines != null)
                    hashCode = hashCode * 59 + this.OpeninvoicedataNumberOfLines.GetHashCode();
                if (this.OpeninvoicedataLineItemNrCurrencyCode != null)
                    hashCode = hashCode * 59 + this.OpeninvoicedataLineItemNrCurrencyCode.GetHashCode();
                if (this.OpeninvoicedataLineItemNrDescription != null)
                    hashCode = hashCode * 59 + this.OpeninvoicedataLineItemNrDescription.GetHashCode();
                if (this.OpeninvoicedataLineItemNrItemAmount != null)
                    hashCode = hashCode * 59 + this.OpeninvoicedataLineItemNrItemAmount.GetHashCode();
                if (this.OpeninvoicedataLineItemNrItemId != null)
                    hashCode = hashCode * 59 + this.OpeninvoicedataLineItemNrItemId.GetHashCode();
                if (this.OpeninvoicedataLineItemNrItemVatAmount != null)
                    hashCode = hashCode * 59 + this.OpeninvoicedataLineItemNrItemVatAmount.GetHashCode();
                if (this.OpeninvoicedataLineItemNrItemVatPercentage != null)
                    hashCode = hashCode * 59 + this.OpeninvoicedataLineItemNrItemVatPercentage.GetHashCode();
                if (this.OpeninvoicedataLineItemNrNumberOfItems != null)
                    hashCode = hashCode * 59 + this.OpeninvoicedataLineItemNrNumberOfItems.GetHashCode();
                if (this.OpeninvoicedataLineItemNrVatCategory != null)
                    hashCode = hashCode * 59 + this.OpeninvoicedataLineItemNrVatCategory.GetHashCode();
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