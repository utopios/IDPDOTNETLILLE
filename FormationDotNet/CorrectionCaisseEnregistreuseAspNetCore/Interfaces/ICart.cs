using CashRegistryEntityFrameWork.Classes;

namespace CorrectionCaisseEnregistreuseAspNetCore.Interfaces
{
    public interface ICart
    {
        public bool AddProduct(int productId);

        public bool RemoveProduct(int productId);

        public int TotalProducts { get; }

        public Order GetOrder();
    }
}
