using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.AspNet.OData;
using PointOfSalesV2.Entities;

namespace PointOfSalesV2.Repository
{
    public static class ExpressionExtensions
    {
        public static MemberExpression GetNestedMemberExpression(this ParameterExpression parameter, string propertyName)
        {
            if (parameter == null) { return null; }

            MemberExpression memExp = null;

            foreach (String part in propertyName.Split('.'))
            {
                if (memExp == null)
                    memExp = Expression.Property(parameter, part);
                else
                    memExp = Expression.Property(memExp, part);
            }

            return memExp;
        }

        public static PropertyInfo GetNestedPropertyInfo(this Type source, string propertyName)
        {
            if (source == null) { return null; }

            PropertyInfo info = null;

            foreach (String part in propertyName.Split('.'))
            {
                if (info == null)
                {
                    info = source.GetProperty(part);
                }
                else
                    info = info.PropertyType.GetProperty(part);
            }

            return info;
        }
    }
}
