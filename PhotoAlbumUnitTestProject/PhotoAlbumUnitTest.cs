using System.Collections.Generic;

using NUnit.Framework;
using Services;
using Models;

namespace PhotoAlbumUnitTestProject
{
    [TestFixture]
    public class PhotoAlbumUnitTest
    {
        [Test]
        public void GetPhotoAlbumsAndCompareWithKnownCount()
        {
            PhotoAlbumService paComp = new PhotoAlbumService();
            string photoAlbumRequestURI = GetAlbumRequestURI();
            List<PhotoAlbum> photoAlbums = paComp.GetPhotoAlbum(photoAlbumRequestURI);
            int resultPhotoAlbumCoust = photoAlbums.Count;
            int expectedPhotoAlbumCount = 5000;
            Assert.AreEqual(expectedPhotoAlbumCount, resultPhotoAlbumCoust);

        }
        [TestCase(3)]
        //[TestCase(150)]
        //[TestCase(100)]
        public void GetPhotoAlbumsAndCompareWithKnowCount(int albumId)
        {
            PhotoAlbumService paComp = new PhotoAlbumService();
            string photoAlbumRequestURI = GetAlbumRequestURI();
            List<PhotoAlbum> photoAlbums = paComp.GetPhotoAlbum(photoAlbumRequestURI, albumId);
            int resultPhotoAlbumCount = photoAlbums.Count;
            int expectedPhotoAlbumCount = 50;
            Assert.AreEqual(expectedPhotoAlbumCount, resultPhotoAlbumCount);

        }
        public string GetAlbumRequestURI()
        {
            return "https://jsonplaceholder.typicode.com/photos";
        }
    }
}
