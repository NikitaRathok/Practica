using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using num1.Models;
using num1.Interfaces;
using System.Xml;
using Microsoft.Build.Framework;
using System.IO.Log;

namespace num1.Share
{
    public class XmlDocumentWorker : IXmlWorker
    {
        private readonly XmlDocument _document;
        private readonly ILogger _logger;
        private string _xmlFilePath;

        public XmlDocumentWorker(ILogger logger)
        {
            _logger = logger;
            _document = new XmlDocument();
        }

        public void Add(Country country)
        {
            var xRoot = _document.DocumentElement;
            XmlElement countryElem = _document.CreateElement("country");

            XmlAttribute nameAttribute = _document.CreateAttribute("name");
            XmlText nameText = _document.CreateTextNode(country.Name);
            nameAttribute.AppendChild(nameText);

            XmlElement areaElem = _document.CreateElement("area");
            XmlText areaInnerText = _document.CreateTextNode(country.Area.ToString());
            areaElem.AppendChild(areaInnerText);

            countryElem.AppendChild(areaElem);

            XmlElement populationElem = _document.CreateElement("population");
            XmlText populationInnerText = _document.CreateTextNode(country.Population.ToString());
            populationElem.AppendChild(populationInnerText);

            countryElem.AppendChild(populationElem);

            xRoot.AppendChild(populationElem);

            xRoot.AppendChild(countryElem);
            _document.Save(_xmlFilePath);
        }

        public void Delete(string name)
        {
            var xRoot = _document.DocumentElement;

            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0)
                {
                    var attributeName = xNode.Attributes.GetNamedItem("name");
                    try
                    {
                        var attributeNameText = attributeName?.InnerText;

                        if (attributeNameText.Equals(name))
                        {
                            xRoot.RemoveChild(xNode);
                        }
                    }
                    catch (Exception ex) when (ex is XmlException || ex is NullReferenceException)
                    {
                        //_logger.LogWarning(ex.Message, nameof(attributeName));
                    }
                }
            }
        }

        public Country FindBy(string name)
        {
            Country country = null;
            var xRoot = _document.DocumentElement;

            foreach (XmlNode xmlNode in xRoot)
            {
                country = GetCountry(xmlNode);

                if (country.Name.Equals(name))
                {
                    return country;
                }
            }
            return country;
        }

        public List<Country> GetAll()
        {
            List<Country> countries = new List<Country>();
            var xRoot = _document.DocumentElement;

            foreach (XmlNode node in xRoot)
            {
                var country = GetCountry(node);
                countries.Add(country);
            }
            return countries;
        }

        public void Load(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            _document.Load(xmlFilePath);
        }

        private Country GetCountry(XmlNode node)
        {
            var country = new Country();

            if (node.Attributes.Count > 0)
            {
                var attributeName = node.Attributes.GetNamedItem("Name");
                country.Name = attributeName?.Value;
            }

            foreach (XmlNode childNode in node.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("area"))
                    {
                        country.Area = double.Parse(childNode.InnerText);
                    }

                    if (childNode.Name.Equals("population"))
                    {
                        country.Population = double.Parse(childNode.InnerText);
                    }
                }

                catch (Exception ex) when (ex is FormatException
                    || ex is NullReferenceException)
                {
                    //_logger.LogError(ex.Message, ex.StackTrace,
                      //  nameof(childNode.InnerText));
                }
            }
            return country;
        }
    }
}
