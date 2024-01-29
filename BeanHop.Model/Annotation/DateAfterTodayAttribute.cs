using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Model.Annotation
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class DateAfterTodayAttribute : ValidationAttribute
    {
    //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //    {
    //        if (value != null && value is DateTime DateTimeValue)
    //        {
    //            DateTime today = DateTime.F(DateTime.Now.Date);

    //            if (DateTimeValue <= today)
    //            {
    //                return new ValidationResult("Ngày hết hạn phải sau ngày hôm nay.");
    //            }
    //        }

    //        return ValidationResult.Success;
    //    }
    }
}
