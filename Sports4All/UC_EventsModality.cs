using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports4All
{
    public partial class UC_EventsModality : UserControl
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_EventsModality));

        private bool _controlSub = false;
        public UC_EventsModality()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mouseHover(object sender, EventArgs e)
        {
            if (!_controlSub) tbSubNotification.Visible = true;

        }

        private void mouseLeave(object sender, EventArgs e)
        {
            tbSubNotification.Visible = false;
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (!_controlSub)
            {
                tbSubNotification.Visible = false;
                _controlSub = true;
                //this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
                btnSub.Image = ((System.Drawing.Image)(resources.GetObject("sub_Button")));
                showNotification("Recinto Subscrito!", "O recinto X foi subscrito com Sucesso.Aceda às suas Subscrições para " +
                                  " gerir todos os seus favoritos!!!");
            }
            //retira subscrição!
            else
            {
                btnSub.Image = ((System.Drawing.Image)(resources.GetObject("subButton.Image")));
                _controlSub = false;

            }

        }
        private void showNotification(string title, string body)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.Visible = true;

            if (title != null)
            {
                notifyIcon.BalloonTipTitle = title;
            }

            if (body != null)
            {
                notifyIcon.BalloonTipText = body;
            }

            notifyIcon.ShowBalloonTip(30000);
        }

        private void onLoad(object sender, EventArgs e)
        {
            // flowlayoutpanel.autoscrool =false;
            // flowlayoutt.horizontalScrool.Enabled = false;
            //  // flowlayoutpanel.autoscrool =false;
            PopulateList();

        }

        private void PopulateList()
        {
            UC_EventModalityItem[] listitems = new UC_EventModalityItem[20];

            for (int i = 0; i < listitems.Length; i++)
            {
                listitems[i] = new UC_EventModalityItem();
                listitems[i].Day = "05";
                listitems[i].Month = "Jan";
                //add to flowlayout
                if (flpEventListModality.Controls.Count < 0)
                {

                    flpEventListModality.Controls.Clear();
                }
                else
                {
                    flpEventListModality.Controls.Add(listitems[i]);
                }
            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


    }
}
