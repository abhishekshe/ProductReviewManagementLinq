using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementWithLinq
{
    class DataTableForProductManagement
    {
        DataTable table = new DataTable();
        ProductManagement productManagement = new ProductManagement();
        
        public void AddDataTable()
        {

            table.Columns.Add("productId");
            table.Columns.Add("userId");
            table.Columns.Add("ratings");
            table.Columns.Add("reviews");
            table.Columns.Add("isLike");
            table.Rows.Add("1", 10, 5, "Good", true);
            table.Rows.Add("2", 3, 4, "Good", true);
            table.Rows.Add("3", 4, 4, "Good", true);
            table.Rows.Add("4", 5, 5, "Good", true);
            table.Rows.Add("5", 4, 3, "Average", true);
            table.Rows.Add("6", 5, 1, "Bad", false);
            table.Rows.Add("7", 10, 5, "Good", true);
            table.Rows.Add("8", 10, 5, "Good", true);
            table.Rows.Add("9", 3, 4, "Good", true);
            table.Rows.Add("10", 10, 2, "Bad", false);
            table.Rows.Add("11", 3, 3, "Average", true);
            table.Rows.Add("12", 10, 3, "Average", false);
        }
       
        public void CallForRetrievingData()
        {  
            productManagement.RetrievingRecords(table);
        }
       
        public void CallForAverageRatings()
        {
            productManagement.AverageRatingForUserIDUsingDataTable(table);
        }
        
        public void CallForReviewRetrieval()
        {
            productManagement.ReviewMessageRetrieval(table);
        }
       
        public void CallForSpecificUserId()
        {
            productManagement.SelectRecordsForUserId(table);
        }

    }

}