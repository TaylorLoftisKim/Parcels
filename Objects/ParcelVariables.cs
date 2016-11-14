namespace Parcel.Objects
{
  public class ParcelVariables
  {
    private int _height;
    private int _weight;
    private int _width;
    private int _length;
    private int _volume;

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
    public void SetVolume(int newWidth, int newHeight, int newLength, int newVolume)
    {
      newVolume = newWidth * newHeight * newLength;
    }
  }
}
