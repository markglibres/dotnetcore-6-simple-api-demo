namespace CustomerNamespace
{
    record Customer (Guid Id, string Fullname);
    interface ICustomerService
    {
        Customer Current();
    }

    class CustomerService: ICustomerService
    {
        public Customer Current() => new Customer(Guid.NewGuid(), "Mark");
    }    
}
