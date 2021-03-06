// Generated by UblSharp.Tests.Generator
using System;
using System.Collections.Generic;
using System.Xml;
using UblSharp;
using UblSharp.CommonAggregateComponents;
using UblSharp.CommonExtensionComponents;
using UblSharp.UnqualifiedDataTypes;
using UblSharp.XmlDigitalSignature;
using UblSharp.Tests.Util;

namespace UblSharp.Tests.Samples
{
    internal class UBLProductActivity21Example3
    {
        public static ProductActivityType Create()
        {
            var doc = new ProductActivityType
            {
                UBLVersionID = "2.1",
                ID = "ID0113",
                CopyIndicator = false,
                IssueDate = "2010-04-08",
                Note = new List<TextType>()
                {
                    new TextType
                    {
                        Value = "Report about sales of goods in Beta Shop's shops located in Bologna."
                    }
                },
                ActivityPeriod = new PeriodType
                {
                    StartDate = "2010-04-07"
                },
                SenderParty = new PartyType
                {
                    PartyName = new List<PartyNameType>()
                    {
                        new PartyNameType
                        {
                            Name = "Beta Shop"
                        }
                    },
                    PostalAddress = new AddressType
                    {
                        StreetName = "Via Emilia",
                        BuildingNumber = "1",
                        CityName = "Modena",
                        PostalZone = "41121",
                        Country = new CountryType
                        {
                            IdentificationCode = "IT",
                            Name = "Italy"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "Mr Delta",
                        Telephone = "0039 059 33000000",
                        Telefax = "0039 059 33000055",
                        ElectronicMail = "delta@betashop.it"
                    }
                },
                ReceiverParty = new PartyType
                {
                    PartyName = new List<PartyNameType>()
                    {
                        new PartyNameType
                        {
                            Name = "Arancio Forniture spa"
                        }
                    },
                    PostalAddress = new AddressType
                    {
                        Floor = "5",
                        Room = "29",
                        StreetName = "Via Dell'Arcoveggio",
                        BuildingNumber = "403",
                        Department = "Marketing Office",
                        CityName = "Bologna",
                        PostalZone = "40129",
                        Country = new CountryType
                        {
                            IdentificationCode = "IT",
                            Name = "Italy"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "Mr Rossi",
                        Telephone = "0039 051 23000000",
                        Telefax = "0039 051 23000023",
                        ElectronicMail = "rossi@arancioforniture.it"
                    }
                },
                SupplyChainActivityDataLine = new List<ActivityDataLineType>()
                {
                    new ActivityDataLineType
                    {
                        ID = "1",
                        SupplyChainActivityTypeCode = "SALES",
                        ActivityOriginLocation = new LocationType
                        {
                            Description = new List<TextType>()
                            {
                                new TextType
                                {
                                    Value = "Shop in the city center"
                                }
                            },
                            Address = new AddressType
                            {
                                StreetName = "Via Rizzoli",
                                BuildingNumber = "208",
                                CityName = "Bologna",
                                PostalZone = "40121",
                                Country = new CountryType
                                {
                                    IdentificationCode = "IT",
                                    Name = "Italy"
                                }
                            }
                        },
                        SalesItem = new List<SalesItemType>()
                        {
                            new SalesItemType
                            {
                                Quantity = new QuantityType
                                {
                                    unitCode = "NAR",
                                    Value = 8M
                                },
                                Item = new ItemType
                                {
                                    Description = new List<TextType>()
                                    {
                                        new TextType
                                        {
                                            Value = "shirt"
                                        }
                                    },
                                    BuyersItemIdentification = new ItemIdentificationType
                                    {
                                        ID = "SH009"
                                    },
                                    SellersItemIdentification = new ItemIdentificationType
                                    {
                                        ID = "DD88"
                                    }
                                }
                            },
                            new SalesItemType
                            {
                                Quantity = new QuantityType
                                {
                                    unitCode = "NAR",
                                    Value = 3M
                                },
                                Item = new ItemType
                                {
                                    Description = new List<TextType>()
                                    {
                                        new TextType
                                        {
                                            Value = "trousers"
                                        }
                                    },
                                    BuyersItemIdentification = new ItemIdentificationType
                                    {
                                        ID = "TH009"
                                    },
                                    SellersItemIdentification = new ItemIdentificationType
                                    {
                                        ID = "DA008"
                                    }
                                }
                            }
                        },
                    }
                },
            };
            doc.Xmlns = new System.Xml.Serialization.XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("cbc","urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
                new XmlQualifiedName("cac","urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
            });
            return doc;
        }
    }
}
