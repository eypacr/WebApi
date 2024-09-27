namespace Entities.Exceptions
{
    public sealed class BookNotFoundException : NotFoundException
    {
        public BookNotFoundException(int id) 
            : base($"kitap: {id} bulunamadı.")
        {
        }
    }
}
