class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string Name => _name;
    public string ProductId => _productId;
}