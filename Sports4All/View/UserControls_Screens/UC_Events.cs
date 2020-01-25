using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using Sports4All.Controller;
using Sports4All.UserControls_Items;

namespace Sports4All
{
    public partial class UC_Events : UserControl
    {
        private BrowseController _browseController;

        public UC_Events()
        {
            InitializeComponent();
            _browseController = new BrowseController();
        }

        private void UC_Events_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            PopulateItems();
        }

        private void PopulateItems()
        {
            ICollection<int> idSportsWithEvents = _browseController.GetSportsIds();
            ICollection<Sport> sportsWithEvents = _browseController.GetSports(idSportsWithEvents);

            flpEvents.Controls.Clear();

            List<String> imageList = new List<string>
            {
                "https://dovethemes.com/wp-content/uploads/2016/12/Eiffel-Tower-Theme.jpg",
            };

            UC_EventItem[] listItems = new UC_EventItem[sportsWithEvents.Count];


            WebClient w = new WebClient();
            byte[] imageByte = w.DownloadData(imageList[0]);
            MemoryStream stream = new MemoryStream(imageByte);


            for (int i = 0; i < sportsWithEvents.Count; i++)
            {
                listItems[i] = new UC_EventItem
                {
                    Title = sportsWithEvents.ElementAt(i).Name,
                    Image = Image.FromStream(stream),
                    Id = sportsWithEvents.ElementAt(i).SportId
                };


                flpEvents.Controls.Add(listItems[i]);
            }

        }

        private Image RoundCorners(Image image, int cornerRadius)
        {
            cornerRadius *= 2;
            Bitmap roundedImage = new Bitmap(image.Width, image.Height);
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            gp.AddArc(0 + roundedImage.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            gp.AddArc(0 + roundedImage.Width - cornerRadius, 0 + roundedImage.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            gp.AddArc(0, 0 + roundedImage.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            using (Graphics g = Graphics.FromImage(roundedImage))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.SetClip(gp);
                g.DrawImage(image, Point.Empty);
            }
            return roundedImage;
        }
    }
}
