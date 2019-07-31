using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPropertiesEditor
{
	public enum TypeData
	{
		Text,
		Bool,
		Date,
		Num
	}

	class PropertyObject
	{

		private string _PropertyName ;
		private TypeData _Type_Data ;
		private string _Value;


		public PropertyObject()
		{
			_PropertyName = "";
			_Type_Data = TypeData.Text;
			_Value = "";

		}

		public string PropertyName
		{
			get
			{
				return _PropertyName;
			}
			set
			{
				_PropertyName = value;
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
	}
}
