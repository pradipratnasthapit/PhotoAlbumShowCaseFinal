using System;
using System.Collections.Generic;
using System.Linq;

using Models;
using Services;

namespace PhotoAlbumProject
{
    class DisplayAlbumInfo
    {
        private string photoAlbumRequestURI;
        public DisplayAlbumInfo(string photoAlbumReqURI)
        {
            photoAlbumRequestURI = photoAlbumReqURI;
        }
        public void DisplayAlbumIdAndTitle()
        {
            PhotoAlbumService paService = new PhotoAlbumService();
            List<PhotoAlbum> photoAlbums = paService.GetPhotoAlbum(photoAlbumRequestURI);
            DisplayAlbumIdAndTitle(photoAlbums);
        }
        public void DisplayAlbumIdAndTitle(int albumId)
        {
            PhotoAlbumService paService = new PhotoAlbumService();
            List<PhotoAlbum> photoAlbums = paService.GetPhotoAlbum(photoAlbumRequestURI, albumId);
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
