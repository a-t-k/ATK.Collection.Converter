using System.Data;
using Microsoft.Data.Analysis;

namespace ATK.Collection.Converter.Converter.ListExtensions;

public class ListConverter<T>(List<T> data)
{
    protected readonly List<T> data = data;

    public (DataTable DataTable, DataFrame DataFrame) To =>
    (
        DataTable: new ListToDataTableConverter().Convert(data),
        DataFrame: new ListToDataFrameConverter().Convert<T>(data)
    );
}