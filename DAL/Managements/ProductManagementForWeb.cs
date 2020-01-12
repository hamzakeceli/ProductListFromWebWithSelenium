using Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Managements
{
    public class ProductManagementForWeb
    {

        
        public List<Product> GetProdutsFromWeb(Mall mall, string FilterString)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(mall.MallUrl);
            List<Product> products = new List<Product>();
            string productName, PriceString, DiscountedPriceString;
            decimal productPrice, productDiscountedPrice;


            if (mall.MallName == "N11")
            {

                driver.FindElement(By.Id("searchData")).SendKeys(FilterString);
                driver.FindElement(By.ClassName("searchBtn")).Click();


                for (int i = 1; i < 10; i++)
                {
                    // By.XPath("//*[@id='view']/ul/li[" + i + "]/div[1]/div[1]/a/h3")
                    productName = driver.FindElement(By.XPath("//*[@id='view']/ul/li[" + i + "]/div[1]/div[1]/a/h3")).Text;
                    PriceString = driver.FindElement(By.XPath("//*[@id='view']/ul/li[" + i + "]/div[1]/div[2]/a[1]")).Text;
                    DiscountedPriceString = driver.FindElement(By.XPath("//*[@id='view']/ul/li[" + i + "]/div[1]/div[2]/a[2]")).Text;

                    //string decimal çeviri
                    PriceString = PriceString.Replace(".", "");
                    PriceString = PriceString.Replace(" TL", "");
                    productPrice = Convert.ToDecimal(PriceString);

                    DiscountedPriceString = DiscountedPriceString.Replace(".", "");
                    DiscountedPriceString = DiscountedPriceString.Replace(" TL", "");
                    productDiscountedPrice = Convert.ToDecimal(DiscountedPriceString);



                    Product product = new Product
                    {
                        ProductName = productName,
                        ProductPrice = productPrice,
                        DiscountedPrice = productDiscountedPrice,
                        ListingDate = DateTime.Now,
                        Mall = mall,
                    };

                    products.Add(product);
                }
            }
            else if (mall.MallName == "GittiGidiyor")
            {
                driver.FindElement(By.Id("search_word")).SendKeys(FilterString);
                driver.FindElement(By.Id("header-search-find-link")).Click();


                for (int i = 1; i < 10; i++)
                {

                    productName = driver.FindElement(By.XPath("//*[@class='clearfix']/ul/li[" + i + "]/a/div[1]/div[1]/div[1]/div[1]/h3")).Text;
                    PriceString = driver.FindElement(By.XPath("//*[@class='clearfix']/ul/li[" + i + "]//*[@class='market-price-sel']")).Text;
                    DiscountedPriceString = driver.FindElement(By.XPath("//*[@class='clearfix']/ul/li[" + i + "]//*[@class='fiyat robotobold price-txt']")).Text;
                    

                    //string decimal çeviri
                    PriceString = PriceString.Replace(".", "");
                    PriceString = PriceString.Replace(" TL", "");
                    productPrice = Convert.ToDecimal(PriceString);

                    DiscountedPriceString = DiscountedPriceString.Replace(".", "");
                    DiscountedPriceString = DiscountedPriceString.Replace(" TL", "");
                    productDiscountedPrice = Convert.ToDecimal(DiscountedPriceString);
                    


                    Product product = new Product
                    {
                        ProductName = productName,
                        ProductPrice = productPrice,
                        DiscountedPrice = productDiscountedPrice,
                        ListingDate = DateTime.Now,
                        Mall = mall,
                    };

                    products.Add(product);
                }
            }

            return products;

        }


    }
}
