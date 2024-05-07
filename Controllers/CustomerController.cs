using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestApi.Models;

public class CustomerController : ControllerBase
{
    private readonly CustomerRepository _customerRepository;

    public CustomerController(CustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    [HttpGet]
    [Route("api/customer/count")]
    public int GetCustomerCount()
    {
        return _customerRepository.GetCustomerCount();
    }

    [HttpGet]
    [Route("api/customer/list")]
    public List<Customer> GetCustomers()
    {
        return _customerRepository.GetCustomers();
    }
}
