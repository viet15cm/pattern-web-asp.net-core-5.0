﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.ModelValidations
{
    public class FileImagesVallidations : ValidationAttribute
    {
        private readonly string[] _extensions;

        public FileImagesVallidations(string[] extensions)
        {
            _extensions = extensions;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string errorType;
            if (!IsValidAllowedExtensions(value))
            {
                errorType = "đuôi mở rộng phải là (.jpg .jpeg .png) !";
            }
            else
            {
                return ValidationResult.Success;
            }

            ErrorMessage = $"{validationContext.DisplayName} dữ liệu  {errorType}";

            return new ValidationResult(ErrorMessage);
        }

        bool IsValidAllowedExtensions(object value)
        {
            var file = value as IFormFile [];
            if (file != null)
            {
                foreach (var item in file)
                {

                    var extension = Path.GetExtension(item.FileName);
                    if (!_extensions.Contains(extension.ToLower()))
                    {
                        return false;
                    }

                }
            }

            return true;
        }

    }
}
