using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Constants.Messages
{
    public class ProductMessage
    {
        public const string NameRequired = "Name is required.";
        public const string NameExceeded = "Name must not exceed 128 characters.";
        public const string DescriptionRequired = "Description is required.";
        public const string DescriptionExceeded = "Description must not exceed 512 characters.";
        public const string ImageUrlRequired = "Image is required.";
        public const string ImageUrlExceeded = "Name must not exceed 1028 characters.";
    }
}
