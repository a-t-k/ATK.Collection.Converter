using Microsoft.Data.Analysis;

namespace ATK.Collection.Converter.Converter.DataFrameExtensions;

public class DataFrameConverter(DataFrame data)
{
    protected readonly DataFrame data = data;
}