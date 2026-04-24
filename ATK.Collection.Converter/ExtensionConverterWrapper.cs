using System.Data;
using ATK.Collection.Converter.Converter.DataTableExtensions;
using ATK.Collection.Converter.Converter.ListExtensions;
using ATK.Collection.Converter.Converter.TabularDataResourceExtensions;
using Microsoft.DotNet.Interactive.Formatting.TabularData;

namespace ATK.Collection.Converter;

public static class ExtensionConverterWrapper
{
    public static TabularDataResourceConverter Convert(this TabularDataResource data)
    {
        return new TabularDataResourceConverter(data);
    }

    public static ListConverter<T> Convert<T>(this List<T> data)
    {
        return new ListConverter<T>(data);
    }

    public static DataTableConverter Convert(this DataTable data)
    {
        return new DataTableConverter(data);
    }
}