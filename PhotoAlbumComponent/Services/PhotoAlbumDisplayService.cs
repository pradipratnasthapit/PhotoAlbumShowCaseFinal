using System;
using System.Collections.Generic;
using System.Linq;

using Models;

namespace Services
{
   public class PhotoAlbumDisplayService
    {
        private string photoAlbumRequestURI;
        public PhotoAlbumDisplayService(string photoAlbumReqURI)
        {
            photoAlbumRequestURI = photoAlbumReqURI;
        }
        public void DisplayAlbumIdAndTitle()
        {
            PhotoAlbumService photoAlbumComp = new PhotoAlbumService();
            List<PhotoAlbum> photoAlbums = photoAlbumComp.GetPhotoAlbum(photoAlbumRequestURI);
            DisplayAlbumIdAndTitle(photoAlbums);
        }
        public  void DisplayAlbumIdAndTitle(int albumId)
        {
            PhotoAlbumService photoAlbumComp = new PhotoAlbumService();
            List<PhotoAlbum> photoAlbums = photoAlbumComp.GetPhotoAlbum(photoAlbumRequestURI,albumId);

            DisplayAlbumIdAndTitle(photoAlbums);
        }
        public void DisplayAlbumIdAndTitle(List<PhotoAlbum> photoAlbums)
        {
            var photoAlbumsGroupById =
                           from photoAlbum in photoAlbums
                           group photoAlbum by photoAlbum.albumId;

            foreach (var photoAlbumGroup in photoAlbumsGroupById)
            {
                Console.WriteLine("> photo-album {0}", photoAlbumGroup.Key);
                foreach (PhotoAlbum photoAlbum in photoAlbumGroup)
                {
                    Console.WriteLine("[{0}] {1}", photoAlbum.id, photoAlbum.title);
                }
            }
        }
    }
}
