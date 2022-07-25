using ApiCashRegistry.Tools;
using CashRegistryEntityFrameWork.Classes;
using CashRegistryEntityFrameWork.Repositories;

namespace ApiCashRegistry.Services
{
    public class ProductService
    {
        private BaseRepository<Product> _productRepository;

        public ProductService(BaseRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductResponseDTO> GetProducts()
        {
            List<ProductResponseDTO> products = new List<ProductResponseDTO>();
            foreach(Product product in _productRepository.FindAll())
            {
                products.Add(new ProductResponseDTO(product.Id, product.Title, product.Price, product.Stock));
            }
            return products;
        }

        public ProductResponseDTO GetProduct(int id)
        {
            Product product = _productRepository.Find(p => p.Id == id);
            return new ProductResponseDTO(product.Id, product.Title, product.Price, product.Stock);
        }

        public ProductResponseDTO AddProduct(ProductRequestDTO productRequestDTO)
        {
            Product product = new Product()
            {
                Title = productRequestDTO.Title,
                Price = productRequestDTO.Price,
                Stock = productRequestDTO.Stock,
            };
            _productRepository.Create(product);
            return new ProductResponseDTO(product.Id, product.Title, product.Price, product.Stock);
        }
    }
}
