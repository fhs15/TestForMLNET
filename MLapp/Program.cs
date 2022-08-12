using MLapp;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Load sample data
var imageBytes = File.ReadAllBytes(@"D:\Downloads\archive (4)\pokemon\Abra\00000000.png");
MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
{
    ImageSource = imageBytes,
};

//Load model and predict output
var result = MLModel1.Predict(sampleData);
Console.WriteLine(result.PredictedLabel);