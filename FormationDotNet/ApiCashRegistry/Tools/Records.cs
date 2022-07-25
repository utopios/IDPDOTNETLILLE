namespace ApiCashRegistry.Tools
{
    public class Records
    {
    }

    public record ProductRequestDTO(string Title, decimal Price, int Stock);

    public record ProductResponseDTO(int Id, string Title, decimal Price, int Stock);
}
