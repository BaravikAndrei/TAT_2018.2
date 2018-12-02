using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DEV8
{
    /// <summary>
    /// Creates List of Vehicle based on XML file.
    /// </summary>
    class ListFromXMLdataBase
    {

        private static readonly ListFromXMLdataBase instance = new ListFromXMLdataBase();
        
        /// <summary>
        /// Singleton
        /// </summary>
        private ListFromXMLdataBase() { }

        /// <summary>
        /// Access.
        /// </summary>
        /// <returns>instance.</returns>
        public static ListFromXMLdataBase GetInstance()
        {
            return instance;
        }

        /// <summary>
        /// Parse XML file.
        /// </summary>
        /// <param name="path">Path to the XML file.</param>
        /// <returns>List of cars.></returns>
        public List<Car> MakeListFromXMLdataBase(string path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            XmlElement xRoot = xDoc.DocumentElement;
            StringBuilder brand = new StringBuilder();
            StringBuilder model = new StringBuilder();
            int quantity = 0;
            decimal price = 0;
            List<Car> carList = new List<Car>();
            byte counter = 0;
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "brand")
                    {
                        brand.Append(childnode.InnerText);
                        counter++;
                    }
                    else if (childnode.Name == "model")
                    {
                        model.Append(childnode.InnerText);
                        counter++;
                    }
                    else if (childnode.Name == "quantity")
                    {
                        quantity = Convert.ToInt32(childnode.InnerText);
                        counter++;
                    }
                    else if (childnode.Name == "price")
                    {
                        price = Convert.ToDecimal(childnode.InnerText);
                        counter++;
                    }
                    if (counter == 4)
                    {
                        Car car = new Car(brand.ToString(), model.ToString(), quantity, price);
                        carList.Add(car);
                        brand.Clear();
                        model.Clear();
                        counter = 0;
                    }
                }
            }
            return carList;
        }
    }
}
