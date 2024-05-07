using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestApi.Models;

public class SupplierController : ControllerBase
{
    private readonly SupplierRepository _supplierRepository;

    public SupplierController(SupplierRepository supplierRepository)
    {
        _supplierRepository = supplierRepository;
    }

    [HttpGet]
    [Route("api/supplier/count")]
    public int GetSupllierCount()
    {
        return _supplierRepository.GetSupllierCount();
    }

    [HttpGet]
    [Route("api/supplier/list")]
    public List<Supplier> GetSuppliers()
    {
        return _supplierRepository.GetSuppliers();
    }
}
