using Microsoft.Data.Analysis;
using Microsoft.DotNet.Interactive.Formatting.TabularData;

namespace ATK.Collection.Converter.Converter.TabularDataResourceExtensions;

/// <summary>
///   Converter 
/// </summary>
public class TabularDataResourceConverter(TabularDataResource data)
{
    protected readonly TabularDataResource data = data;

    public (DataFrame DataFrame, object Test) To =>
    (
        DataFrame: new TabularDataResourceToDataFrameConverter().Convert(data),
        Test: new object()
    );
}