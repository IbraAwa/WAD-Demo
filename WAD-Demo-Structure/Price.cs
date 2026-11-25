// === LES STRUCTURES (struct) ===

internal struct Price
{
    public decimal Amount;

    public string Currency;

    public Price(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }
}