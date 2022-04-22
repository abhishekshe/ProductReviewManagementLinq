using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReviewManagementWithLinq
{
    class ProductManagement
    {
        public readonly DataTable dataTable = new DataTable();
       
        public void TopRecords(List<ProductReview> listReview)
        {
           
            var recordedData = (from productReviews in listReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
           
            var recordData = listReview.OrderByDescending(r => r.Rating).Take(3);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
            }
        }

        
        public void SelectedRecords(List<ProductReview> listReview)
        {
           
            var recordData = listReview.Where(r => r.Rating > 3 && (r.ProductId == 1 || r.ProductId == 4 || r.ProductId == 9)).ToList();
           
            var recordedData = (from productReviews in listReview
                                where productReviews.Rating > 3 && (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9)
                                select productReviews);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
            }
        }

       
        public void countOfReviews(List<ProductReview> listProductReview)
        {
           
            var recordData = listProductReview.GroupBy(r => r.UserId).Select(r => new { productId = r.Key, count = r.Count() });
           
            var recordedData = from products in listProductReview
                               group products by products.UserId into g
                               select new
                               {
                                   userId = g.Key,
                                   count = g.Count()
                               };

            foreach (var list in recordedData)
            {
                Console.WriteLine("UserId:-" + list.userId + " Count:-" + list.count);
            }
        }
       
        public void retrieveProductIDandreview(List<ProductReview> productReviewList)
        {
            var recordData = productReviewList.Select(r => new { r.ProductId, r.Review });
            foreach (var list in recordData)
            {
                Console.WriteLine("product Id:-" + list.ProductId + " Review :-" + list.Review);
            }
        }
       
        public void SkippingRecords(List<ProductReview> productReviewList)
        {
            var recordData = productReviewList.Skip(5);
            var recordedData = (from products in productReviewList
                                select products).Skip(5);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
            }

        }
       
        public void RetrievingRecords(DataTable table)
        {
           
            var recordData = from products in table.AsEnumerable()
                             where (products.Field<string>("isLike") == true.ToString())
                             select products;
           
            var recordedData = table.AsEnumerable().Where(r => r.Field<string>("isLike") == true.ToString());
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.Field<string>("productId") + " UserId:-" + list.Field<string>("userId") + " Ratings:-" + list.Field<string>("ratings") + " Review:-" + list.Field<string>("reviews") + " IsLike:-" + list.Field<string>("isLike"));
            }
        }
       
        public void AverageRatingForUserId(List<ProductReview> productReviewList)
        {
            var recordData = productReviewList.GroupBy(r => r.UserId).Select(r => new { userId = r.Key, averageRatings = r.Average(x => x.Rating) });
            var recordedData = from products in productReviewList
                               group products by products.UserId into p
                               select new { userId = p.Key, averageRatings = p.Average(x => x.Rating) };

            foreach (var list in recordData)
            {
                Console.WriteLine("user Id:-" + list.userId + " Ratings :" + list.averageRatings);
            }

        }
       
        public void AverageRatingForUserIDUsingDataTable(DataTable table)
        {
           
            var recordData = table.AsEnumerable().GroupBy(r => r.Field<string>("userId")).Select(r => new { userid = r.Key, averageRatings = r.Average(x => Convert.ToInt32(x.Field<string>("ratings"))) });
            foreach (var list in recordData)
            {
                Console.WriteLine("user Id:-" + list.userid + " Ratings :" + list.averageRatings);
            }
        }
       
        public void ReviewMessageRetrieval(DataTable table)
        {
            var recordData = table.AsEnumerable().Where(r => r.Field<string>("reviews") == "Average");
            foreach (var list in recordData)
            {
               
                Console.WriteLine("ProductId:-" + list.Field<string>("productId") + " UserId:-" + list.Field<string>("userId") + " Ratings:-" + list.Field<string>("ratings") + " Review:-" + list.Field<string>("reviews") + " IsLike:-" + list.Field<string>("isLike"));
            }

        }
    }
}