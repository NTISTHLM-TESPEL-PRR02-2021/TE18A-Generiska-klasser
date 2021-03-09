using System;

namespace GeneriskaKlasser
{
  public class GridTile<T>
  {
    public GridTile<T> top;
    public GridTile<T> bottom;
    public GridTile<T> left;
    public GridTile<T> right;

    public int cost;
    public int height;

    public T content;

  }
}
