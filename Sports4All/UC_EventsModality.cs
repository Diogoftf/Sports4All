﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_EventsModality : UserControl
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_EventsModality));
        private readonly MyEventsController _eventsController = new MyEventsController();
        private string _sportName { get; set; }

        private bool _controlSub = false;
        public UC_EventsModality()
        {
            _sportName = "Futebol"; // VALOR PARA TESTE
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

            if (!DesignMode) ListEventsBySport();

        }

        private void ListEventsBySport()
        {
            if (flpEventListModality.Controls.Count > 0)
                flpEventListModality.Controls.Clear();
            var EventsbySport = _eventsController.EventsbySport(_sportName);
            var EventsbySportCount = EventsbySport.Count;
            UC_EventModalityItem[] listitems = new UC_EventModalityItem[EventsbySportCount];

            for (int i = 0; i < EventsbySportCount; i++)
            {
                var usersCount = EventsbySport.ToList()[i].Users.Count;
                var maxUsers = EventsbySport.ToList()[i].MaxPlayers;
                var hour = EventsbySport.ToList()[i].StartDate.ToShortTimeString();
                var month = EventsbySport.ToList()[i].StartDate.ToLongDateString();
                month = month.Substring(6, 3).ToUpper();
                listitems[i] = new UC_EventModalityItem
                {
                    Owner = EventsbySport.ToList()[0].Reserve.UserId,
                    SportGround = EventsbySport.ToList()[0].Reserve.Ground.Park.Name,
                    Hour = EventsbySport.ToList()[i].StartDate.ToShortTimeString(),
                    Day = Convert.ToString(EventsbySport.ToList()[i].StartDate.Day),
                    Month = month,
                    Lotation = usersCount + "/" + maxUsers

                };
                if (usersCount == maxUsers) listitems[i].DisableJoinEventbtn(); // remove botao para se juntar ao evento
                flpEventListModality.Controls.Add(listitems[i]);
            }
        }

        
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
