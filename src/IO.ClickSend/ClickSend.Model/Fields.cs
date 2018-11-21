/* 
 * ClickSend v3 REST API
 *
 *  This is the official [ClickSend](https://clicksend.com) SDK.  *You'll need to create a free account to use the API. You can register [here](https://www.clicksend.com/signup).*  You can use our API documentation along with the SDK. Our API docs can be found [here](https://developers.clicksend.com). 
 *
 * OpenAPI spec version: 3.1.0
 * Contact: support@clicksend.com
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using ClickSendDateConverter = IO.ClickSend.Client.ClickSendDateConverter;

namespace IO.ClickSend.ClickSend.Model
{
    /// <summary>
    /// Contains all details for the main contact.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class Fields :  IEquatable<Fields>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fields" /> class.
        /// </summary>
        /// <param name="phoneNumber">Your phone number in E.164 format. Must be provided if no fax number or email..</param>
        /// <param name="custom1">custom1.</param>
        /// <param name="email">Your email. Must be provided if no phone number or fax number..</param>
        /// <param name="faxNumber">Your fax number. Must be provided if no phone number or email..</param>
        /// <param name="firstName">Your first name..</param>
        /// <param name="addressLine1">Your street address.</param>
        /// <param name="addressLine2">addressLine2.</param>
        /// <param name="addressCity">Your nearest city.</param>
        /// <param name="addressState">Your current state.</param>
        /// <param name="addressPostalCode">Your current postcode.</param>
        /// <param name="addressCountry">Your current country.</param>
        /// <param name="organizationName">Your organisation name.</param>
        /// <param name="custom2">custom2.</param>
        /// <param name="custom3">custom3.</param>
        /// <param name="custom4">custom4.</param>
        /// <param name="lastName">Your last name.</param>
        public Fields(string phoneNumber = default(string), string custom1 = default(string), string email = default(string), string faxNumber = default(string), string firstName = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressCity = default(string), string addressState = default(string), string addressPostalCode = default(string), string addressCountry = default(string), string organizationName = default(string), string custom2 = default(string), string custom3 = default(string), string custom4 = default(string), string lastName = default(string))
        {
            this.PhoneNumber = phoneNumber;
            this.Custom1 = custom1;
            this.Email = email;
            this.FaxNumber = faxNumber;
            this.FirstName = firstName;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressCity = addressCity;
            this.AddressState = addressState;
            this.AddressPostalCode = addressPostalCode;
            this.AddressCountry = addressCountry;
            this.OrganizationName = organizationName;
            this.Custom2 = custom2;
            this.Custom3 = custom3;
            this.Custom4 = custom4;
            this.LastName = lastName;
        }
        
        /// <summary>
        /// Your phone number in E.164 format. Must be provided if no fax number or email.
        /// </summary>
        /// <value>Your phone number in E.164 format. Must be provided if no fax number or email.</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Custom1
        /// </summary>
        [DataMember(Name="custom_1", EmitDefaultValue=false)]
        public string Custom1 { get; set; }

        /// <summary>
        /// Your email. Must be provided if no phone number or fax number.
        /// </summary>
        /// <value>Your email. Must be provided if no phone number or fax number.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Your fax number. Must be provided if no phone number or email.
        /// </summary>
        /// <value>Your fax number. Must be provided if no phone number or email.</value>
        [DataMember(Name="fax_number", EmitDefaultValue=false)]
        public string FaxNumber { get; set; }

        /// <summary>
        /// Your first name.
        /// </summary>
        /// <value>Your first name.</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Your street address
        /// </summary>
        /// <value>Your street address</value>
        [DataMember(Name="address_line_1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine2
        /// </summary>
        [DataMember(Name="address_line_2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Your nearest city
        /// </summary>
        /// <value>Your nearest city</value>
        [DataMember(Name="address_city", EmitDefaultValue=false)]
        public string AddressCity { get; set; }

        /// <summary>
        /// Your current state
        /// </summary>
        /// <value>Your current state</value>
        [DataMember(Name="address_state", EmitDefaultValue=false)]
        public string AddressState { get; set; }

        /// <summary>
        /// Your current postcode
        /// </summary>
        /// <value>Your current postcode</value>
        [DataMember(Name="address_postal_code", EmitDefaultValue=false)]
        public string AddressPostalCode { get; set; }

        /// <summary>
        /// Your current country
        /// </summary>
        /// <value>Your current country</value>
        [DataMember(Name="address_country", EmitDefaultValue=false)]
        public string AddressCountry { get; set; }

        /// <summary>
        /// Your organisation name
        /// </summary>
        /// <value>Your organisation name</value>
        [DataMember(Name="organization_name", EmitDefaultValue=false)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or Sets Custom2
        /// </summary>
        [DataMember(Name="custom_2", EmitDefaultValue=false)]
        public string Custom2 { get; set; }

        /// <summary>
        /// Gets or Sets Custom3
        /// </summary>
        [DataMember(Name="custom_3", EmitDefaultValue=false)]
        public string Custom3 { get; set; }

        /// <summary>
        /// Gets or Sets Custom4
        /// </summary>
        [DataMember(Name="custom_4", EmitDefaultValue=false)]
        public string Custom4 { get; set; }

        /// <summary>
        /// Your last name
        /// </summary>
        /// <value>Your last name</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Fields {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Custom1: ").Append(Custom1).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FaxNumber: ").Append(FaxNumber).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
            sb.Append("  AddressState: ").Append(AddressState).Append("\n");
            sb.Append("  AddressPostalCode: ").Append(AddressPostalCode).Append("\n");
            sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  Custom2: ").Append(Custom2).Append("\n");
            sb.Append("  Custom3: ").Append(Custom3).Append("\n");
            sb.Append("  Custom4: ").Append(Custom4).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
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
            return this.Equals(input as Fields);
        }

        /// <summary>
        /// Returns true if Fields instances are equal
        /// </summary>
        /// <param name="input">Instance of Fields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Fields input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Custom1 == input.Custom1 ||
                    (this.Custom1 != null &&
                    this.Custom1.Equals(input.Custom1))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FaxNumber == input.FaxNumber ||
                    (this.FaxNumber != null &&
                    this.FaxNumber.Equals(input.FaxNumber))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AddressCity == input.AddressCity ||
                    (this.AddressCity != null &&
                    this.AddressCity.Equals(input.AddressCity))
                ) && 
                (
                    this.AddressState == input.AddressState ||
                    (this.AddressState != null &&
                    this.AddressState.Equals(input.AddressState))
                ) && 
                (
                    this.AddressPostalCode == input.AddressPostalCode ||
                    (this.AddressPostalCode != null &&
                    this.AddressPostalCode.Equals(input.AddressPostalCode))
                ) && 
                (
                    this.AddressCountry == input.AddressCountry ||
                    (this.AddressCountry != null &&
                    this.AddressCountry.Equals(input.AddressCountry))
                ) && 
                (
                    this.OrganizationName == input.OrganizationName ||
                    (this.OrganizationName != null &&
                    this.OrganizationName.Equals(input.OrganizationName))
                ) && 
                (
                    this.Custom2 == input.Custom2 ||
                    (this.Custom2 != null &&
                    this.Custom2.Equals(input.Custom2))
                ) && 
                (
                    this.Custom3 == input.Custom3 ||
                    (this.Custom3 != null &&
                    this.Custom3.Equals(input.Custom3))
                ) && 
                (
                    this.Custom4 == input.Custom4 ||
                    (this.Custom4 != null &&
                    this.Custom4.Equals(input.Custom4))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Custom1 != null)
                    hashCode = hashCode * 59 + this.Custom1.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FaxNumber != null)
                    hashCode = hashCode * 59 + this.FaxNumber.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressCity != null)
                    hashCode = hashCode * 59 + this.AddressCity.GetHashCode();
                if (this.AddressState != null)
                    hashCode = hashCode * 59 + this.AddressState.GetHashCode();
                if (this.AddressPostalCode != null)
                    hashCode = hashCode * 59 + this.AddressPostalCode.GetHashCode();
                if (this.AddressCountry != null)
                    hashCode = hashCode * 59 + this.AddressCountry.GetHashCode();
                if (this.OrganizationName != null)
                    hashCode = hashCode * 59 + this.OrganizationName.GetHashCode();
                if (this.Custom2 != null)
                    hashCode = hashCode * 59 + this.Custom2.GetHashCode();
                if (this.Custom3 != null)
                    hashCode = hashCode * 59 + this.Custom3.GetHashCode();
                if (this.Custom4 != null)
                    hashCode = hashCode * 59 + this.Custom4.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}