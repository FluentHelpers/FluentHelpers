using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FluentHelpers.Extensions
{
    public static class TrimExtensions
    {
        // trim
        // trim left

        // source : https://stackoverflow.com/questions/7726714/trim-all-string-properties
        public static TSelf TrimAllStrings<TSelf>(this TSelf obj)
        {
            if (obj != null)
            {
                if (obj is IEnumerable)
                {
                    foreach (var listItem in obj as IEnumerable)
                    {
                        listItem.TrimAllStrings();
                    }
                }
                else
                {
                    BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;

                    foreach (PropertyInfo p in obj.GetType().GetProperties(flags))
                    {
                        Type currentNodeType = p.PropertyType;
                        if (currentNodeType == typeof(String))
                        {
                            string currentValue = (string)p.GetValue(obj, null);
                            if (currentValue != null)
                            {
                                p.SetValue(obj, currentValue.Trim(), null);
                            }
                        }
                        // see http://stackoverflow.com/questions/4444908/detecting-native-objects-with-reflection
                        else if (currentNodeType != typeof(object) && Type.GetTypeCode(currentNodeType) == TypeCode.Object)
                        {
                            p.GetValue(obj, null).TrimAllStrings();
                        }
                    }
                }
            }

            return obj;
        }

    }
}
