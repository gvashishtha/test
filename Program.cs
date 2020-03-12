using System;
using IowaHouseML;
using IowaHouseML.ConsoleApp;

namespace IowaHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelBuilder.CreateModel(TRAIN_DATA_FILEPATH: args[0], MODEL_FILEPATH: args[1]);
        }
    }
}
