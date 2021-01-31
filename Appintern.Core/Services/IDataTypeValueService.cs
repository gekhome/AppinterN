using System.Collections.Generic;
using System.Web.Mvc;

namespace Appintern.Core.Services
{
    public interface IDataTypeValueService
    {
        IEnumerable<SelectListItem> GetItemsFromValueListDataType(string dataTypeName, string[] selectedValues);
    }
}
