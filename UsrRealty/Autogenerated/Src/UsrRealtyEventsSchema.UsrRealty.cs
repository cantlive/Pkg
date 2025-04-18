namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b06a7305-457b-4e8d-942c-e647d906b17c");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("372b0eed-2283-4fbe-a536-dd1b7e20ce79");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,193,110,219,48,12,189,23,232,63,16,198,14,54,16,8,237,117,221,10,44,65,58,20,40,182,161,113,123,25,118,80,100,198,85,33,75,134,40,167,203,134,254,251,40,203,105,92,167,3,250,46,182,201,199,71,62,154,86,54,72,173,84,8,37,122,47,201,109,130,88,56,187,209,117,231,101,208,206,158,158,252,61,61,1,70,71,218,214,176,218,81,192,230,98,28,26,23,54,141,179,255,77,122,20,75,27,116,208,72,239,225,136,229,22,109,136,212,68,254,217,39,118,125,244,70,243,24,22,125,190,82,15,216,200,111,236,2,62,67,118,71,254,22,165,9,187,172,248,149,138,218,110,109,180,2,101,36,17,164,220,27,50,240,17,230,146,240,173,76,146,25,118,48,82,116,91,158,90,87,8,91,167,43,248,110,87,114,203,94,114,183,126,68,21,128,208,86,232,103,144,20,231,184,97,99,189,238,23,95,19,96,113,144,27,41,71,172,121,12,241,162,182,151,193,226,226,53,45,233,130,239,13,177,243,60,5,138,84,48,33,87,168,116,35,13,180,94,171,184,166,84,37,190,98,40,119,45,86,11,103,186,198,222,75,211,225,167,129,122,153,199,85,254,136,252,108,218,90,111,32,79,74,151,112,126,182,71,241,154,52,113,21,129,226,154,22,210,42,52,88,241,16,193,119,248,242,107,199,160,224,227,81,240,89,146,172,177,196,166,53,50,196,177,45,62,193,141,83,210,232,63,114,109,112,213,243,242,193,204,29,161,231,187,181,188,124,62,90,113,139,228,58,175,152,228,60,171,204,142,219,68,28,238,37,157,90,54,131,236,168,3,137,126,53,215,84,58,55,215,117,250,202,10,81,186,97,130,226,29,54,120,252,20,16,87,206,55,50,228,19,123,220,248,92,156,205,63,28,109,59,34,60,120,247,212,219,95,254,86,216,70,131,251,250,41,253,249,240,57,188,242,227,249,31,6,86,196,81,229,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("10da0c5d-5849-e6c4-7a42-54d133cb894f"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("372b0eed-2283-4fbe-a536-dd1b7e20ce79"),
				CreatedInSchemaUId = new Guid("b06a7305-457b-4e8d-942c-e647d906b17c"),
				ModifiedInSchemaUId = new Guid("b06a7305-457b-4e8d-942c-e647d906b17c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b06a7305-457b-4e8d-942c-e647d906b17c"));
		}

		#endregion

	}

	#endregion

}

