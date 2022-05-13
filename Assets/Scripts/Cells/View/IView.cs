namespace Cells.View
{
    public interface IView<T>
    {
        void Setup(T obj, Graphic graphic);
    }
}