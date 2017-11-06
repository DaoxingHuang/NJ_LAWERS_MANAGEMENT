using System;

namespace NJ.Lawers.Mangement.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            

            var item = new DataItem("Change your title as you expected");
            callback(item, null);
        }
    }
}