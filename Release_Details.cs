using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace xRel
{
    public partial class Release_Details : Form
    {
        public Release release { get; set; }

        public Release_Details()
        {
            InitializeComponent();
        }

        public void setVariables()
        {

        }

        private void tbLayoutTable_Details_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Release_Details_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.imdb.com/title/" + release.iMDBID.Split(':')[1];
            llbl_IMDB.Links.Add(link);

            LinkLabel.Link link2 = new LinkLabel.Link();
            link2.LinkData = release.nfolink;
            llbl_nfo.Links.Add(link2);

            txt_Title.Text = release.release_title;
            lbl_video_type.Text = release.video_type;
            lbl_audio_type.Text = release.audio_type;
            lbl_size.Text = release.size;
            lbl_rating.Text = "Rating: " + release.rating;
            llbl_IMDB.Text = release.iMDBID;
            lbl_size_unit.Text = "Size: (" + release.unit + ")";
        }

        private void llbl_IMDB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void getPoster()
        {
            String uRL = "http://api.xrel.to/api/ext_info/info.xml?id=" + release.xRelID;
            String xML;
            WebClient wc = new WebClient();
            try
            {
                xML = wc.DownloadString(uRL);

                XDocument xdoc = XDocument.Parse(xML, LoadOptions.None);

                if (xdoc.Root.Name == "ext_info")
                {

                    Release r = new Release();
                    MessageBox.Show("ext");
                    if (xdoc.Elements("cover_url").Any())
                    {
                        MessageBox.Show("ext_info");

                    }

                }
            }
            catch
            {
                MessageBox.Show("Exception FC: 0x0003");
            }
        }

        private void llbl_nfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}
