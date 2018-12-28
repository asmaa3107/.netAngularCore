using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class PhotoGallery
    {
        public PhotoGallery()
        {
            Photo = new HashSet<Photo>();
            PhotoGalleryLanguage = new HashSet<PhotoGalleryLanguage>();
        }

        public int PhotoGalleryId { get; set; }
        public bool Ispublished { get; set; }
        public DateTime PhotoGalleryDate { get; set; }
        public int? FkPhotoGalleryDisplayId { get; set; }
        public int? PhotoGalleryOrder { get; set; }
        public string ImagePath { get; set; }

        public Setting FkPhotoGalleryDisplay { get; set; }
        public ICollection<Photo> Photo { get; set; }
        public ICollection<PhotoGalleryLanguage> PhotoGalleryLanguage { get; set; }
    }
}
