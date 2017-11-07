using System;
using NJ.Lawers.Mangement.Model;

namespace NJ.Lawers.Mangement.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItem("南京最牛律师事务所");
            callback(item, null);
        }
    }
}