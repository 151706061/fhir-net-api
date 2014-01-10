﻿using Hl7.Fhir.Model;
using Hl7.Fhir.Support;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Hl7.Fhir.Serialization
{
    public class XmlDomFhirReader : IFhirReader
    {
        XObject _current;

        public XmlDomFhirReader(XmlReader reader)
        {
            var settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;
            settings.IgnoreWhitespace = true;

            var internalReader = XmlReader.Create(reader, settings);
            XDocument doc;

            try
            {
                doc = XDocument.Load(internalReader, LoadOptions.SetLineInfo);
            }
            catch (XmlException xec)
            {
                throw Error.Format("Cannot parse xml: " + xec.Message);
            }

            setRoot(doc);
        }

        internal XmlDomFhirReader(XObject root)
        {
            setRoot(root);
        }

        private void setRoot(XObject root)
        {
            if (root is XDocument)
                _current = ((XDocument)root).Root;
            else
                _current = root;
        }

        public string GetResourceTypeName(bool nested)
        {
            if (nested)
            {
                if (_current is XElement)
                    _current = ((XElement)_current).FirstNode;
            }

            if (_current is XElement)

                return ((XElement)_current).Name.LocalName;
            else
                throw Error.Format("Cannot get resource type name: reader not at an element");
        }


        private static readonly XName XHTMLDIV = XHtml.XHTMLNS + "div";

        public IEnumerable<Tuple<string, IFhirReader>> GetMembers()
        {
            if (_current is XElement)
            {
                var rootElem = (XElement)_current;
                var result = new List<Tuple<string, IFhirReader>>();

                // First, any attributes
                result.AddRange(rootElem.Attributes()
                    .Where(xattr => xattr.Name.LocalName != "xmlns")
                    .Select(xattr => Tuple.Create(xattr.Name.LocalName, (IFhirReader)new XmlDomFhirReader(xattr))));

                foreach(var node in rootElem.Nodes())
                {
                    if(node is XText)
                    {
                        // A nested text node (the content attribute of a Binary)
                        result.Add(Tuple.Create(SerializationConfig.BINARY_CONTENT_MEMBER_NAME, (IFhirReader)new XmlDomFhirReader(node)));
                    }
                    else if(node is XElement)
                    {
                        var elem = (XElement)node;
                        
                        // All normal elements
                        if(elem.Name.NamespaceName == SerializationUtil.FHIRNS)
                            result.Add(Tuple.Create(elem.Name.LocalName, (IFhirReader)new XmlDomFhirReader(elem)));

                        // The special xhtml div element
                        else if(elem.Name == XHTMLDIV)
                            result.Add(Tuple.Create(XHTMLDIV.LocalName,
                                (IFhirReader)new XmlDomFhirReader(buildDivXText(elem))));

                        else
                            throw Error.Format("Encountered unsupported element: {0}", elem.Name.ToString());
                    }
                    else if(node is XComment)
                    {
                        // nothing
                    }
                    else
                        throw Error.Format("Encountered unexpected element member of type {0}", node.GetType().Name);
                }

                return result;
            }
            else
                throw Error.Format("Cannot get members: reader not at an element");
            
        }

        private XText buildDivXText(XElement elem)
        {
 	        return new XText(elem.ToString(SaveOptions.DisableFormatting));
        }


        public IEnumerable<IFhirReader> GetArrayElements()
        {
            // Xml does not support arrays like Json. This method won't be called if CurrentToken is never set to Array
            throw new NotImplementedException();
        }

        public object GetPrimitiveValue()
        {
            if (_current is XAttribute)
                return ((XAttribute)_current).Value;

            else if (_current is XText)
                return ((XText)_current).Value;

            else
                throw Error.Format("Parser is not at a primitive value");
        }

        public TokenType CurrentToken
        {
            get
            {
                // Note: <div> XElements have already been tranformed to an XText with the <div> content,
                // so no special checking necessary
                if (_current is XElement)
                    return TokenType.Object;
                if (_current is XAttribute)
                    return TokenType.String;
                if (_current is XText)
                    return TokenType.String;
                else
                    throw Error.Format("Parser cannot handle xml objects of type {0}", _current.GetType().Name);
            }
        }

        public int LineNumber
        {
            get 
            {
                var li = (IXmlLineInfo)_current;

                if(!li.HasLineInfo())
                    throw Error.InvalidOperation("No lineinfo available. Please read the Xml document using LoadOptions.SetLineInfo.");

                return li.LineNumber;
            }
        }

        public int LinePosition
        {
            get
            {
                var li = (IXmlLineInfo)_current;

                if (!li.HasLineInfo())
                    throw Error.InvalidOperation("No lineinfo available. Please read the Xml document using LoadOptions.SetLineInfo.");

                return li.LinePosition;
            }
        }
    }
}