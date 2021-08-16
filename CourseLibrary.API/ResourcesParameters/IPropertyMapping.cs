using CourseLibrary.API.Services;
using System.Collections.Generic;

namespace CourseLibrary.API.ResourcesParameters
{
    public interface IPropertyMapping
    {
        Dictionary<string, PropertyMappingValue> _mappingDictionary { get; }
    }
}