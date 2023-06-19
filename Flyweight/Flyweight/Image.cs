namespace Flyweight
{
    internal class Image
    {
        public string Picture { get; private set; }

        public Image(string picture)
        {
            Picture = picture;
        }

        public static Image Load(string picture)
        {
            return new Image(picture);
        } 
    }
}
