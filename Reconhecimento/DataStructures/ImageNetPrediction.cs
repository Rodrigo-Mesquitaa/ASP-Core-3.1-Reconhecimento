using Microsoft.ML.Data;

namespace Reconhecimento.DataStructures
{
    public class ImageNetPrediction
    {
        [ColumnName("grid")]
        public float[] PredictedLabels;
    }
}