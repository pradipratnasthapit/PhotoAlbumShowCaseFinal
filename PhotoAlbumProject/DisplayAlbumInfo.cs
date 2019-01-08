using Models;
using PhotoAlbumComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            PhotoAlbumComponent paComp = new PhotoAlbumComponent();
            List<PhotoAlbum> photoAlbums = paComp.GetPhotoAlbum(photoAlbumRequestURI);
            DisplayAlbumIdAndTitle(photoAlbums);
        }
        public void DisplayAlbumIdAndTitle(int albumId)
        {
            PhotoAlbumComponent paComp = new PhotoAlbumComponent();
            List<PhotoAlbum> photoAlbums = paComp.GetPhotoAlbum(photoAlbumRequestURI, albumId);
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
