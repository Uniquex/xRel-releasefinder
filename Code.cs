using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace xRel
{
    class Code
    {
        public List<Release> releases { get; set; }

        public Code()
        {
            releases = new List<Release>();
        }



        public void searchForReleases(String title, String quality, String amount)
        {
            String searchstring = title.Replace(" ", "%20") + "%20" + quality;
            parseXML(searchstring, amount);

        }

        private void parseXML(String searchString, String count)
        {
            String uRL = ("http://api.xrel.to/api/search/releases.xml"
                    + "?q=" + searchString + "&scene=1&p2p=0&limit=" + count);
            String xML;

            WebClient wc = new WebClient();
            try
            {
                xML = wc.DownloadString(uRL);

                XDocument xdoc = XDocument.Parse(xML, LoadOptions.None);

                if (xdoc.Root.Name == "releases_search")
                {
                    foreach (XElement release in xdoc.Root.Elements("results").Elements("release"))
                    {
                        Release r = new Release();

                        if (release.Elements("dirname").Any())
                        {
                            r.release_title = release.Element("dirname").Value;
                        }
                        if (release.Elements("link_href").Any())
                        {
                            r.nfolink = release.Element("link_href").Value;
                        }
                        if (release.Elements("video_type").Any())
                        {
                            r.video_type = release.Element("video_type").Value;
                        }
                        if (release.Elements("audio_type").Any())
                        {
                            r.audio_type = release.Element("audio_type").Value;
                        }
                        foreach (XElement size in xdoc.Root.Elements("results").Elements("release").Elements("size"))
                        {
                            if (size.Elements("number").Any())
                            {
                                r.size = size.Element("number").Value;
                            }
                            if (size.Elements("unit").Any())
                            {
                                r.unit = size.Element("unit").Value;
                            }
                        }
                        foreach (XElement ext_info in xdoc.Root.Elements("results").Elements("release").Elements("ext_info"))
                        {
                            if (ext_info.Elements("rating").Any())
                            {
                                //r.rating = ext_info.Element("rating").Value;
                            }
                        }
                        foreach (XElement uris in xdoc.Root.Elements("results").Elements("release").Elements("ext_info").Elements("uris"))
                        {
                            if (uris.Elements("uri").Any())
                            {
                                r.iMDBID = uris.Element("uri").Value;
                            }
                        }

                        if(r.release_title != null)
                        {
                            releases.Add(r);
                        }
                    }
                    
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Webexception");
            }
        }
    }
}
