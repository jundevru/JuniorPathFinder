// Интерфейс сохраняемого объекта

namespace JuniorPathFinderCore.Storage
{
    public interface IStorageObject
    {
        byte[] GetBytes();
        void SetBytes(byte[] data);
    }
}
