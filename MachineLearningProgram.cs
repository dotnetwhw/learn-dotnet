using System;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace learn_dotnet
{
    public class MachineLearningProgram
    {
        public class HouseData
        {
            public float Size { get; set; }
            public float Price { get; set; }
        }

        public class Prediction
        {
            [ColumnName("Score")]
            public float Price { get; set; }
        }

        public static void Internal_Main(string[] args)
        {
            var ctx = new MLContext();
            
            // 1. Import or creating training data
            var houseData = new[] {
                new HouseData(){Size = 1.1F, Price = 1.2F},
                new HouseData(){Size = 1.9F, Price = 2.3F},
                new HouseData(){Size = 2.8F, Price = 3.0F},
                new HouseData(){Size = 3.4F, Price = 3.7F},
                new HouseData(){Size = 4.4F, Price = 5.2F},
                new HouseData(){Size = 5.5F, Price = 7.2F},
            };

            var trainingData = ctx.Data.LoadFromEnumerable(houseData);
            
            // 2.
            var pipeline = ctx.Transforms.Concatenate("Features", new[] {"Size"})
                .Append(ctx.Regression.Trainers.Sdca(labelColumnName: "Price", maximumNumberOfIterations: 100));
            
            // 3. training model
            var model = pipeline.Fit(trainingData);
            
            // 4. Make a prediction
            var size = new HouseData() { Size = 6.0F };
            var price = ctx.Model.CreatePredictionEngine<HouseData, Prediction>(model).Predict(size);
            
            Console.WriteLine($"Predicted price for size: {size.Size*1000} sq ft = {price.Price*100:C}");

        }
    }
}