using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.swconst;

namespace CustomPropertiesEditor
{
	public enum TypeData
	{
		Text,
		YesOrNo,
		Date,
		Num
	}

	class PropertyObject
	{

		private string _fieldName ;
		private TypeData _Type_Data ;
		private string _Value;


		public PropertyObject()
		{
			_fieldName = "";
			_Type_Data = TypeData.Text;
			_Value = "";

		}

		public string FieldName
		{
			get
			{
				return _fieldName;
			}
			set
			{
				_fieldName = value;
			}
		 }
		public TypeData Type_Data
		{
			get
			{
				return _Type_Data;
			}
			set
			{
				_Type_Data = value;
			}
		}
		public string Value
		{
			get
			{
				return _Value;
			}
			set
			{
				_Value = value;
			}
		}

		public swCustomInfoType_e FieldType
		{
			get
			{
				if (Type_Data == TypeData.Text)
					return swCustomInfoType_e.swCustomInfoText;
				if (Type_Data == TypeData.YesOrNo)
					return swCustomInfoType_e.swCustomInfoYesOrNo;
				if (Type_Data == TypeData.Date)
					return swCustomInfoType_e.swCustomInfoDate;
				if (Type_Data == TypeData.Num)
					return swCustomInfoType_e.swCustomInfoNumber;

				return swCustomInfoType_e.swCustomInfoUnknown;
			}
		}

	}
}
