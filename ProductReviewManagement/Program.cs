using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProductReviewManagementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManagement productManagement = new ProductManagement();
            DataTableForProductManagement dataTableForProductManagement = new DataTableForProductManagement();
            
            Console.WriteLine("Welcome to Product Review Management");


            
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1,UserId=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=2,UserId=2,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=3,UserId=3,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=4,UserId=4,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=5,UserId=02,Rating=3,Review="Average",isLike=false},
                new ProductReview(){ProductId=6,UserId=03,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=7,UserId=14,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=8,UserId=13,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=9,UserId=9,Rating=2,Review="Bad",isLike=false},
                new ProductReview(){ProductId=10,UserId=10,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=11,UserId=05,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=12,UserId=08,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=13,UserId=06,Rating=3,Review="Average",isLike=true},
                new ProductReview(){ProductId=14,UserId=08,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=15,UserId=02,Rating=3,Review="Average",isLike=false},
                new ProductReview(){ProductId=16,UserId=01,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=17,UserId=07,Rating=2,Review="Bad",isLike=false },
                new ProductReview(){ProductId=18,UserId=03,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=19,UserId=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=20,UserId=10,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=21,UserId=10,Rating=3,Review="Average",isLike=true},
                new ProductReview(){ProductId=22,UserId=13,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=23,UserId=15,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=24,UserId=12,Rating=2,Review="Bad",isLike=false},
                new ProductReview(){ProductId=25,UserId=11,Rating=4,Review="nice",isLike=true},

            };
            bool check = true;
            dataTableForProductManagement.AddDataTable();
            while (check)
            {
                Console.WriteLine("\nPlease enter 1 to print all the product details");
                Console.WriteLine("Please enter 2 to get top records of data based on product ratings");
                Console.WriteLine("Pleae enter 3 to get records with rating greater than 3 and product id in 1,4,9.");
                Console.WriteLine("please press 4 to get count of reviews grouped by user id");
                Console.WriteLine("Please enter 5 to get product id and review from data");
                Console.WriteLine("Please enter 6 to skip top 5 records");
                Console.WriteLine("Please enter 7 to retrieve records where is like is true using data table");
                Console.WriteLine("Please enter 8 to get average ratings based on user id using data table ");
                Console.WriteLine("Please enter 9 to get all the records for average review");
                Console.WriteLine("Please enter 10 to get all records sorted for user id =10");
                Console.WriteLine("Please press any other key to exit");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        foreach (var list in productReviewList)
                        {
                            Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
                        }
                        break;
                    case "2":
                       
                        productManagement.TopRecords(productReviewList);
                        break;
                    case "3":
                      
                        productManagement.SelectedRecords(productReviewList);
                        break;
                    case "4":
                       
                        productManagement.countOfReviews(productReviewList);
                        break;
                    case "5":
                      
                        productManagement.retrieveProductIDandreview(productReviewList);
                        break;
                    case "6":
                       
                        productManagement.SkippingRecords(productReviewList);
                        break;
                    case "7":
                       
                        dataTableForProductManagement.CallForRetrievingData();
                        break;
                    case "8":
                       
                        productManagement.AverageRatingForUserId(productReviewList);
                        
                        dataTableForProductManagement.CallForAverageRatings();
                        break;
                    case "9":
                      
                        dataTableForProductManagement.CallForReviewRetrieval();
                        break;
                    case "10":
                       
                        dataTableForProductManagement.CallForSpecificUserId();
                        break;
                    default:
                        check = false;
                        break;
                }
            }
           

        }
    }
}