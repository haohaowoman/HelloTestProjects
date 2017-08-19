using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class MaxWordAttribute : ValidationAttribute, IClientValidatable
    {
        private readonly int _maxLength;
        public MaxWordAttribute(int MaxLength):base("too many words {0}")
        {
            _maxLength = MaxLength;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule();
            rule.ErrorMessage = FormatErrorMessage(metadata.DisplayName);
            rule.ValidationParameters.Add("wordcount", _maxLength);
            rule.ValidationType = "maxlength";
            yield return rule;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if ((value as string).Split(' ').Length > _maxLength)
                {
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }
            }
            return base.IsValid(value, validationContext);
        }
    }
}