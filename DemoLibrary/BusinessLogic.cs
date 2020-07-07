using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BusinessLogic(IDataAccess dataAccess, ILogger logger)
        {
            _dataAccess = dataAccess;
            _logger = logger;

        }
        public void ProcessData()
        {
            
            _logger.log("starting the processing of data");
            Console.WriteLine("Processing---");
            _dataAccess.LoadData();
            _dataAccess.SaveData("processed info");
            _logger.log("finishing the processing of data");
        }
    }
}
