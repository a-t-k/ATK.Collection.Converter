using System.Data;
using ATK.Collection.Converter.Converter.ExcelExtensions;
using Microsoft.Data.Analysis;

namespace ATK.Collection.Converter.Converter.DataTableExtensions;

public class DataTableConverter(DataTable data)
{
    protected readonly DataTable data = data;

    public (DataFrame DataFrame, object Test) To =>
    (
        new DataTableToDataFrameConverter().Convert(data),
        Test: new object()
    );

    public (List<T> List, object Test) ToGeneric<T>()
    {
        return (
            new DataTableToGenericListConverter().Convert<T>(data),
            Test: new object()
        );
    }

    public (bool ExcelDocument, object Test) SaveAs(string fileName)
    {
        return (
            new ExcelDocumentCreator().Save(data, fileName),
            Test: new object()
        );
    }
}