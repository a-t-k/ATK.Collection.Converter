using System.Data;
using Microsoft.Data.Analysis;

namespace ATK.Collection.Converter.Converter.DataTableExtensions;

public class DataTableToDataFrameConverter
{
    public DataFrame Convert(DataTable dataTable)
    {
        var dataFrame = new DataFrame();

        // values from columns are then strings
        // the values can be read from database directly with
        // DataFrame.LoadFrom(DbDataAdapter adapter)
        // or use this
        // DataFrame.LoadFrom(IEnumerable<IList<object>> vals, IList<(string, Type)> columnInfos)
        foreach (DataColumn column in dataTable.Columns)
        {
            var values = dataTable.AsEnumerable().Select(r => r.Field<object>(column.ColumnName)?.ToString()).ToArray();
            DataFrameColumn dataFrameColumn = DataFrameColumn.Create(column.ColumnName, values);
            dataFrame.Columns.Add(dataFrameColumn);
        }

        return dataFrame;
    }
}