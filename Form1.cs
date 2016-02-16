using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace xRel
{
    public partial class Releasefinder_v1 : Form
    {
       
        private Code code;

        public Releasefinder_v1()
        {
            code = new Code();
            InitializeComponent();
            comboBox_Quality.SelectedIndex = 0;
            txtb_title.Focus();

        }

        private void lbtitles_clear()
        {
            listbox_releasetitle.Items.Clear();
            code.releases.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbtitles_clear();
            code.searchForReleases(txtb_title.Text, comboBox_Quality.Text, txtbx_number.Text);
            lB_release_getitems();
            listbox_releasetitle.Sorted = true;


        }

        private void listbox_releasetitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listbox_releasetitle.Items.Count != 0)
            {
                if (code.releases != null)
                {
                    foreach (Release release in code.releases)
                    {
                        if (listbox_releasetitle.Text.Equals(release.release_title))
                        {
                            Release_Details rlde = new Release_Details();
                            rlde.release = release;
                            rlde.Show();
                        }

                    }
                }
           }
       }

        public void lB_release_getitems()
        {
            foreach (Release release in code.releases)
            {
                listbox_releasetitle.Items.Add(release.release_title);
            }
        }

    }
}
