using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace XML_Basics
{
    class ProblemsSolutoions
    {
        static void Main()
        {
            Console.WriteLine("-- 1. Loading Catalog XML");
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");//1
            ExtractAllAlbumNames(doc);//2
            ExtractArtistsAndNumbersOfAlbums(doc);//3
            ExtractArtistsAndNumberOfAlbums(doc);//4
            ExtractArtistsAndNumberOfAlbumsXPATH(doc);//5
            DeleteAlbums(doc);//6
            OldAlbumsDomAndXPATH(doc);//7
            OldAlbumsLinqToXML();//8,12
        }
        public static void ExtractAllAlbumNames (XmlDocument doc)
        {
            Console.WriteLine("-- 2. Extracting all Album Names");
            var albumNode = doc.DocumentElement.ChildNodes;
            foreach (XmlNode node in albumNode)
            {
                Console.WriteLine("Album name: {0}", node["name"].InnerText);
            }
        }
        public static void ExtractArtistsAndNumbersOfAlbums(XmlDocument doc)
        {
            Console.WriteLine("-- 3. Extracting all Artists Names Alphabetically");
            var albumNodes = doc.DocumentElement.ChildNodes;
            var artistNames = new SortedSet<string>();
            foreach (XmlNode albumNode in albumNodes)
            {
                var artistName = albumNode["artist"].InnerText;
                artistNames.Add(artistName);
            }
            foreach (var artistName in artistNames)
            {
                Console.WriteLine(artistName);
            }
        }
        public static void ExtractArtistsAndNumberOfAlbums(XmlDocument doc)
        {
            Console.WriteLine("-- 4. Extracting all Artists Names and their Album Count");
            var albumNodes = doc.DocumentElement.ChildNodes;
            var artistAlbumsCount = new Dictionary<string, int>();
            foreach (XmlNode albumNode in albumNodes)
            {
                var artistName = albumNode["artist"].InnerText;
                if (!artistAlbumsCount.ContainsKey(artistName))
                {
                    artistAlbumsCount.Add(artistName, 0);
                }

                artistAlbumsCount[artistName]++;
            }

            foreach (var artist in artistAlbumsCount)
            {
                Console.WriteLine("{0} has {1} albums", artist.Key, artist.Value);
            }
        }

        public static void ExtractArtistsAndNumberOfAlbumsXPATH(XmlDocument doc)
        {
            Console.WriteLine("-- 5. Extracting all Artists Names and their Album Count using XPATH");
            var albumNodes = doc.DocumentElement.ChildNodes;
            var artistAlbumsCount = new Dictionary<string, int>();
            string xPathQuery = "/album/name";
            foreach (XmlNode albumNode in albumNodes)
            {
                var artistName = albumNode["artist"].InnerText;
                if (!artistAlbumsCount.ContainsKey(artistName))
                {
                    artistAlbumsCount.Add(artistName, 0);
                }

                artistAlbumsCount[artistName]++;
            }

            foreach (var artist in artistAlbumsCount)
            {
                Console.WriteLine("{0} has {1} albums", artist.Key, artist.Value);
            }
        }

        public static void DeleteAlbums(XmlDocument doc)
        {
            Console.WriteLine("-- 6. Delete Albums with higher price than 20");
            var albumNodes = doc.DocumentElement.ChildNodes;
            var numberFormat = new NumberFormatInfo();
            int count = 0;
            for (int i = albumNodes.Count-1; i >= 0; i--)
            {
                var albumPrice = Decimal.Parse(albumNodes[i]["price"].InnerText,numberFormat);
                if (albumPrice > 20m)
                {
                    albumNodes[i].ParentNode.RemoveChild(albumNodes[i]);
                    count++;
                }
            }
            doc.Save("../../cheap-albums-catalog.xml");
            Console.WriteLine("{0} albums with prise over 20", count);
        }

        public static void OldAlbumsDomAndXPATH(XmlDocument doc)
        {
            Console.WriteLine("-- 7. Albums who are 5 years old or newer DOM and XPATH");
            var albumNodes = doc.SelectNodes("/music-catalog/album");
            var numberFormat = new NumberFormatInfo();
            var currentYear = new DateTime().Year;
            foreach (XmlNode albumNode in albumNodes)
            {
                int albumYear = int.Parse(albumNode["year"].InnerText);
                if (albumYear >= currentYear-5)
                {
                    Console.WriteLine("Title: {0} Price: {1}",albumNode["name"].InnerText,albumNode["price"].InnerText);
                }
            }
        }

        public static void OldAlbumsLinqToXML()
        {
            Console.WriteLine("-- 8. Albums who are 5 years old or newer LINQ To XML");
            XDocument doc = XDocument.Load("../../catalog.xml");
            
            var currentYear = new DateTime().Year;
            var albums =
                from album in doc.Descendants("album")
                where int.Parse(album.Element("year").Value) >= currentYear - 5
                select new
                {
                    Name = album.Element("name").Value,
                    Price = album.Element("price").Value
                };

            doc.Elements("albums").Elements("album")
                .Where(y => int.Parse(y.Element("year").Value) >= DateTime.Now.Year - 5)
                .Select(a => new
                {
                    Title = a.Element("name").Value,
                    Price = decimal.Parse(a.Element("price").Value)
                });
            foreach (var album in albums)
            {
                Console.WriteLine("Title: {0} Price: {1}", album.Name, album.Price);
            }
        }
    }
}
