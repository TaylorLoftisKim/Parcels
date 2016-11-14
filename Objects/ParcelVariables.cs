namespace Parcel.Objects
{
  public class ParcelVariables
  {
    private int _height;
    private int _weight;
    private int _width;
    private int _length;
    private int _volume;
    private int _price;

    public int GetHeight()
    {
      return _height;
    }
    public int GetWeight()
    {
      return _weight;
    }
    public int GetWidth()
    {
      return _width;
    }
    public int GetLength()
    {
      return _length;
    }
    public int GetVolume()
    {
      return _volume;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }
    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }
    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }
    public void SetLength(int newLength)
    {
      _length = newLength;
    }
    public int SetVolume()
    {
      _volume = _width * _height * _length;
      return _volume;
    }
    public int SetPrice()
    {
      _price = _width + _height + _length;
      return _price;
    }
  }
}
