using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class PhotoGalleryLanguage
    {
        public int PhotoGalleryLanguageId { get; set; }
        public string PhotoGalleryName { get; set; }
        public int FkPhotoGalleryId { get; set; }
        public string LanguageName { get; set; }

        public PhotoGallery FkPhotoGallery { get; set; }
    }
}
