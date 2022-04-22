//8.Implement the following method using reflection.The method should locate a public property on instance with the name passed in via the propertyName parameter, and set the property's value to propertyValue.    (10 points)
//void SetPropertyOnType<T>(T instance, string propertyName, string propertyValue)
//{

//}


using System;
using System.Reflection;

namespace Finexio
{
	public class Question_8
	{
		void SetPropertyOnType<T>(T instance, string propertyName, string propertyValue)
		{
			PropertyInfo pointerToProperty = typeof(T).GetProperty(propertyName);
			if (pointerToProperty != null)
			{				
				pointerToProperty.SetValue(instance, propertyValue, null);
			}			

		}
	}
}

