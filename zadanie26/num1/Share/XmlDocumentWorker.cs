using Microsoft.Build.Framework;
using num1.Interface;
using num1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace num1.Share
{
    public class XmlDocumentWorker:IXmlWorker
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
                
        }
    }
}
