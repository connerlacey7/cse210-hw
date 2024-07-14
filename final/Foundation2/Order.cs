class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }

        total += _customer.IsInUSA() ? 5 : 35;

        return total;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (var product in _products)
        {
            label += $"{product.Name} ({product.ProductId})\n";
        }

        return label;
    }

    public string ShippingLabel()
    {
        return $"{_customer.Name}\n{_customer.Address}";
    }
}