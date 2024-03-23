namespace Library.Entities;


public static class BookListEntity
{
    
    public static Dictionary<int, BookEntity> books = [];
    public static void Add(BookEntity book)
    {
        books.Add(book.Id, book);
    }
    public static void Update(BookEntity book)
    {
        books.Remove(book.Id);
        books.Add(book.Id, book);
    }

    public static void Delete(int id)
    {
        books.Remove(id);
    }
}
