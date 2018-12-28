using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Photo
    {
        public int PhotoId { get; set; }
        public int FkPhotoGalleryId { get; set; }
        public bool IsPublished { get; set; }
        public int? PhotoOrder { get; set; }
        public string PhotoResizedPath { get; set; }
        public string PhotoTnumbnailPath { get; set; }
        public string PhotoToolTip { get; set; }

        public PhotoGallery FkPhotoGallery { get; set; }
    }
}
