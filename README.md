# PhotoAlbumShowCaseFinal
Repository for LT ShowCase Final

Project: PhotoAlbumUnitTestProject
  Used NUnit as Testing Framework

Project: PhotoAlbumComponent
  Separate Class Library to help Main program with Display output in Console and Get Data from given WebServivce.
User JSON to Deserialize Object returned from WebService

Project: PhotoAlbumProject
  Main Project which uses different component provided in PhotoAlbumComponent Project to Display required output in Console.
  We have added one Assembly Refrence "System.Configuration" so that we can extract out WebService URI to app.config.
