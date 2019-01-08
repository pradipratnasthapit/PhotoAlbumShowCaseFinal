using System.Collections.Generic;

using Models;
using NUnit.Framework;

using PhotoAlbumComponents;

namespace PhotoAlbumUnitTestProject
{
    [TestFixture]
    public class PhotoAlbumUnitTest
    {
        [Test]
        public void GetPhotoAlbums()
        {
            PhotoAlbumComponent paComp = new PhotoAlbumComponent();
            string photoAlbumRequestURI = GetAlbumRequestURI();
            List<PhotoAlbum> photoAlbums = paComp.GetPhotoAlbum(photoAlbumRequestURI);
            int resultPhotoAlbumCoust = photoAlbums.Count;
            int expectedPhotoAlbumCount = 5000;
            Assert.AreEqual(expectedPhotoAlbumCount, resultPhotoAlbumCoust);

        }
        [TestCase(3)]
        //[TestCase(150)]
        //[TestCase(100)]
        public void GetPhotoAlbums(int albumId)
        {
            PhotoAlbumComponent paComp = new PhotoAlbumComponent();
            string photoAlbumRequestURI = GetAlbumRequestURI();
            List<PhotoAlbum> photoAlbums = paComp.GetPhotoAlbum(photoAlbumRequestURI, albumId);
            int resultPhotoAlbumCoust = photoAlbums.Count;
            int expectedPhotoAlbumCount = 50;
            Assert.AreEqual(expectedPhotoAlbumCount, resultPhotoAlbumCoust);

        }
        public string GetAlbumRequestURI()
        {
            return "https://jsonplaceholder.typicode.com/photos";
        }
    }
}
